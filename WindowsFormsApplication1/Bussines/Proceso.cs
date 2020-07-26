using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;



namespace Bussines
{
    public class Proceso
    {
        public DataSet Logueo(Entidades.Datos BE)
        {
            String sproc = "sp_Login";
            Object[] oParamsql = new Object[2];
            oParamsql[0] = BE.Usuario;
            oParamsql[1] = BE.Password;

            DataSet dsresult = (DataAcces.GetDataBase("IOP").ExecuteDataSet(sproc, oParamsql));
            return dsresult;
        }
        public DataSet Listado(Entidades.Datos BE)
        {
            String sproc = "sp_Listados_Tablas";
            Object[] oParamsql = new Object[1];
            oParamsql[0] = BE.IdTabla;

            DataSet dsresult = (DataAcces.GetDataBase("IOP").ExecuteDataSet(sproc, oParamsql));
            return dsresult;
        }
        public void GuardarNuevoDatos(Entidades.Datos BE)
        {
            try
            {
                String sproc = "sp_GuardarNuevoDatos";
                Object[] oParamsql = new Object[5];
                oParamsql[0] = BE.IdMes;
                oParamsql[1] = BE.IdTipoTela;
                oParamsql[2] = BE.ValorCadena;
                oParamsql[3] = BE.ValorNumerico;
                oParamsql[4] = BE.IdTabla;

                DataAcces.GetDataBase("IOP").ExecuteNonQuery(sproc, oParamsql);
            }
            catch (Exception excp)
            {
                throw excp;
            }
        }
        public void GuardarDatosModificados(Entidades.Datos BE)
        {
            try
            {
                String sproc = "sp_GuardarDatosModificados";
                Object[] oParamsql = new Object[5];
                oParamsql[0] = BE.IdMes;
                oParamsql[1] = BE.IdTipoTela;
                oParamsql[2] = BE.ValorCadena;
                oParamsql[3] = BE.ValorNumerico;
                oParamsql[4] = BE.IdTabla;

                DataAcces.GetDataBase("IOP").ExecuteNonQuery(sproc, oParamsql);
            }
            catch (Exception excp)
            {
                throw excp;
            }
        }
        public void EliminarDatos(Entidades.Datos BE)
        {
            try
            {
                String sproc = "sp_EliminarDatos";
                Object[] oParamsql = new Object[3];
                oParamsql[0] = BE.IdMes;
                oParamsql[1] = BE.IdTipoTela;
                oParamsql[2] = BE.IdTabla;

                DataAcces.GetDataBase("IOP").ExecuteNonQuery(sproc, oParamsql);
            }
            catch (Exception excp)
            {
                throw excp;
            }
        }
        public DataSet CargarCombo(Entidades.Datos BE)
        {
            String sproc = "sp_Cargar_Combo";
            Object[] oParamsql = new Object[1];
            oParamsql[0] = BE.IdTabla;

            DataSet dsresult = (DataAcces.GetDataBase("IOP").ExecuteDataSet(sproc, oParamsql));
            return dsresult;
        }

        public DataSet ConsultaMesesActual(Entidades.Datos BE)
        {
            String sproc = "sp_Cargar_MesesActual";
            Object[] oParamsql = new Object[1];
            oParamsql[0] = BE.IdTabla;

            DataSet dsresult = (DataAcces.GetDataBase("IOP").ExecuteDataSet(sproc, oParamsql));
            return dsresult;
        }
    }
}
