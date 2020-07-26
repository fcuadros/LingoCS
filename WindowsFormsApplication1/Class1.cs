
// Illustrates calling the Lingo DLL from C# to
// solve a simple transportation model.

using System;
using System.IO;
using System.Runtime.InteropServices;

// Our data structure to pass to the callback function
//[StructLayout(LayoutKind.Sequential)]
public struct CallbackData
{
   public int nCallbacks;
   public int nIterations;
   public double dObjective;
}

public class Class1
{
   // We need memory pointers to pass data to and from Lingo.
   // In order to work with pointers, a routine must be declared "unsafe".
   public unsafe static void x()
   {
      int nError = -1, nPointersNow = -1;
      //const string strModelFile = "\\Proyecto IOP\\Lingo_excel_pima_cotton.lng"; // Model file name
      const string strModelFile = @"C:\Users\Gerson\Desktop\Proyecto IOP\Lingo_excel_pima_cotton.lng";
      // Make sure model file exists
      if (!File.Exists(strModelFile))
      {
         Console.WriteLine("*** Unable to find model file: {0}\n", strModelFile);
         goto FinalExit;
      }

      // Get a pointer to a Lingo environment (must build for x64 with 64_bit Lingo)
      IntPtr pLingoEnv;
      pLingoEnv = lingo.LScreateEnvLng();
      if (pLingoEnv == IntPtr.Zero)
      {
         Console.WriteLine("Unable to create Lingo environment.\n");
         goto FinalExit;
      }


      // In the code below, we establish our callback functions. The solver
      // callback is called periodically by the solver when the model is processing.
      // The error callback is called whenever Lingo encounters an error.
      // Callbacks are optional -- you do not have to declare them if they aren't
      // needed.

      // Optionally, declare our callback data (allocate on global
      // heap to keep gc from relocating)
      CallbackData cbData;
      cbData.nCallbacks = 0;
      cbData.nIterations = -1;
      cbData.dObjective = 0.0;
      IntPtr myData = Marshal.AllocHGlobal(Marshal.SizeOf(cbData));
      Marshal.StructureToPtr(cbData, myData, true);

      // Pass a pointer to the solver callback and our data
      lingo.typCallback cb = new lingo.typCallback(Class1.MyCallback);
      nError = lingo.LSsetCallbackSolverLng(pLingoEnv, cb, myData);
      if (nError != lingo.LSERR_NO_ERROR_LNG) goto ErrorExit;

      // Pass a pointer to the error callback and our data
      lingo.typCallbackError cbError = new lingo.typCallbackError(Class1.MyErrorCallback);
      nError = lingo.LSsetCallbackErrorLng(pLingoEnv, cbError, myData);
      if (nError != lingo.LSERR_NO_ERROR_LNG) goto ErrorExit;


      // We need to pin lingo's transfer areas in memory to keep GC from relocating. C#
      // is a memory-managed language. This means it's garbage collector could relocate
      // Lingo's transfer areas if they are not pinned.

      // Each of the memory locations below are accessed by Lingo's @POINTER( n) function
      // in the Lingo model, where n is the index of the memory location of interest.


      fixed (double* pdObjective = new double[1] { -1 })
      fixed (double* pdStatus = new double[1] { -1 })
      {

         // Pass Lingo a pointer to where to store the objective value 
         nError = lingo.LSsetPointerLng(pLingoEnv, pdObjective, ref nPointersNow);
         if (nError != lingo.LSERR_NO_ERROR_LNG) goto ErrorExit;

         // Pass Lingo a pointer to where to store the solution status value
         nError = lingo.LSsetPointerLng(pLingoEnv, pdStatus, ref nPointersNow);
         if (nError != lingo.LSERR_NO_ERROR_LNG) goto ErrorExit;

         // Here is the script we want LINGO to run. The "take" command loads the
         // model from an external file. Alternatively, cScript could have been loaded
         // programmatically with the model text to avoid accessing a file.
         string cScript = "set echoin 1 \n";        // echo input
         cScript += "take " + strModelFile + "\n";  // load the model
         cScript += "go \n";                        // solve model
         cScript += "quit \n";                      // exit script processor

         // Clear out the status value;
         pdStatus[0] = -1;

         // Run the script. The error code here only pertains to whether the script
         // was successfuly loaded for processing. We check the actual status of the
         // solution below by checking the status value returned by Lingo in pdStatus.
         nError = lingo.LSexecuteScriptLng(pLingoEnv, cScript);
         if (nError != lingo.LSERR_NO_ERROR_LNG) goto ErrorExit;

         // Close the log file
         //lingo.LScloseLogFileLng(pLingoEnv);

         // Marshal callback data back to the structure
         cbData = (CallbackData)Marshal.PtrToStructure(myData, typeof(CallbackData));

         // Check for optimal solution
         if (pdStatus[0] != lingo.LS_STATUS_GLOBAL_LNG)
         {
            // Had a problem   
            Console.WriteLine("Unable to solve!");
         } else {


            Console.WriteLine("Optimal solution found!");
            Console.WriteLine("Total callbacks: {0}", cbData.nCallbacks);
            Console.WriteLine("Objective value: {0}", pdObjective[0]);
         }
      }

      Console.WriteLine();

      // free user data in global heap
      Marshal.FreeHGlobal(myData);

      goto NormalExit;

   ErrorExit:
      Console.WriteLine("LINGO Error Code: {0}\n", nError);

   NormalExit:
      // Free Lingo's environment to avoid a memory leak
      lingo.LSdeleteEnvLng(pLingoEnv);

   FinalExit:
      Console.Write("\nPress enter...");
      String sTemp = Console.ReadLine();
   }

   public static int MyCallback(IntPtr pLingoEnv, int nLoc, IntPtr myData)
   {
      // copy the user data in the unmanaged code into a local structure
      CallbackData cb = (CallbackData)Marshal.PtrToStructure(myData, typeof(CallbackData));

      // increment the number of calls to the callback function
      cb.nCallbacks++;
      /*
              // get iteration count
              int nIterations = -1, nErr;
              nErr = lingo.LSgetCallbackInfoLng(pLingoEnv,
               lingo.LS_IINFO_ITERATIONS_LNG, ref nIterations);
              if (nErr == lingo.LSERR_NO_ERROR_LNG && nIterations != cb.nIterations)
              {
                  cb.nIterations = nIterations;
                  Console.WriteLine("Current iteration count in callback={0}", nIterations);
              }

              // get current objective
              double dObjective = 0.0;
              nErr = lingo.LSgetCallbackDblInfoLng(pLingoEnv,
               lingo.LS_DINFO_OBJECTIVE_LNG, ref dObjective);
              if (nErr == lingo.LSERR_NO_ERROR_LNG && dObjective != cb.dObjective && dObjective > 0.0)
              {
                  cb.dObjective = dObjective;
                  Console.WriteLine("Current objective in callback={0}", dObjective);
              }
      */

      // copy the user data in the local structure back to the unmanaged code
      Marshal.StructureToPtr(cb, myData, false);

      // can return -1 here to interrupt the solver
      return 0;
   }

   public static int MyErrorCallback(IntPtr pLingoEnv, IntPtr myData, int nErrorCode, string strErrorMessage)
   {
      // copy the user data in the unmanaged code into a local structure
      CallbackData cb = (CallbackData)Marshal.PtrToStructure(myData, typeof(CallbackData));
      Console.WriteLine("*** Lingo Error Message: ");
      Console.WriteLine(strErrorMessage + "\n");
      return 0;
   }

}