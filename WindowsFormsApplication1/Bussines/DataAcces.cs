using System;
using System.Data;
using System.Configuration;
using System.Threading;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;




     class DataAcces
    {
        public DataAcces()
        {
     
        }



        #region Database

        private static Mutex _dbmu = new Mutex();
        private static Hashtable _db = new Hashtable();

        public static Database GetDataBase(string alias)
        {
            try
            {
                if (_db.Contains(alias) && _db[alias] != null)
                    return (Database)_db[alias];
                else
                {
                    Database db;
                    _dbmu.WaitOne();
                    try
                    {
                        db = DatabaseFactory.CreateDatabase(alias);
                       
                        _db.Add(alias, db);
                    }
                    finally
                    {
                        _dbmu.ReleaseMutex();
                    }
                    return db;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metadata

        private static Mutex _metadatamu = new Mutex();
        private static DataSet _metadata = new DataSet();
        private static Hashtable _commandsmetadata = new Hashtable();

        //public static DbDataAdapter GetTableCommands(Database db, string tablename)
        //{
        //    if (!_commandsmetadata.Contains(tablename) || _commandsmetadata[tablename] == null)
        //        GetTableMetadata(db, tablename);
        //    return (DbDataAdapter)_commandsmetadata[tablename];
        //}

        //public static DataTable GetTableMetadata(Database db, string tablename)
        //{
        //    try
        //    {
        //        if (_metadata.Tables.Contains(tablename) && _metadata.Tables[tablename] != null)
        //            return (DataTable)_metadata.Tables[tablename];
        //        else
        //        {
        //            DataTable dt = null;
        //            DataSet ds = new DataSet();
        //            DbDataAdapter da = db.GetDataAdapter();

        //            _metadatamu.WaitOne();
        //            try
        //            {
        //                using (DbConnection  connection = db.CreateConnection())
        //                {
        //                    try
        //                    {

        //                        connection.Open();
        //                        if (connection  is OracleConnection)
        //                        {
        //                            da.SelectCommand = db.GetSqlStringCommand(String.Format("SELECT * FROM {0} WHERE ROWNUM < 1", tablename));
        //                        }
        //                        else if (connection  is SqlConnection)
        //                        {
        //                            da.SelectCommand = db.GetSqlStringCommand(String.Format("SET FMTONLY ON SELECT TOP 0 * FROM {0} SET FMTONLY OFF", tablename));
        //                        }
        //                        da.SelectCommand.Connection = connection;

        //                        da.FillSchema(ds, SchemaType.Source, tablename);

        //                        if (connection  is OracleConnection)
        //                        {
        //                            OracleCommandBuilder cmdb = new OracleCommandBuilder((OracleDataAdapter)da);
        //                            ((OracleDataAdapter)da).InsertCommand = cmdb.GetInsertCommand();
        //                            ((OracleDataAdapter)da).UpdateCommand = cmdb.GetUpdateCommand();
        //                            ((OracleDataAdapter)da).DeleteCommand = cmdb.GetDeleteCommand();
        //                        }
        //                        else if (connection is SqlConnection)
        //                        {
        //                            SqlCommandBuilder cmdb = new SqlCommandBuilder((SqlDataAdapter)da);
        //                            if (ds.Tables[0].PrimaryKey.Length > 0)
        //                                ((SqlDataAdapter)da).InsertCommand = getInsertCommand(cmdb, ds.Tables[0].PrimaryKey[0].ColumnName);
        //                            else
        //                                ((SqlDataAdapter)da).InsertCommand = cmdb.GetInsertCommand(); 
        //                          //  ((SqlDataAdapter)da).InsertCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                            ((SqlDataAdapter)da).UpdateCommand = cmdb.GetUpdateCommand();
        //                           // ((SqlDataAdapter)da).UpdateCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                            ((SqlDataAdapter)da).DeleteCommand = cmdb.GetDeleteCommand();
        //                           // ((SqlDataAdapter)da).DeleteCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                        }
        //                    }
        //                    finally
        //                    {
        //                        if (connection.State == ConnectionState.Open) connection.Close();
        //                    }
        //                }

        //                if (ds != null && ds.Tables.Count > 0)
        //                {
        //                    _commandsmetadata.Add(tablename, da);
        //                    dt = ds.Tables[0];
        //                    _metadata.Merge(dt);
        //                }
        //            }
        //            finally
        //            {
        //                _metadatamu.ReleaseMutex();
        //            }
        //            return dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public static DataTable GetTableMetadata(Database db,DbConnection connection, string tablename)
        //{
        //    try
        //    {
        //        if (_metadata.Tables.Contains(tablename) && _metadata.Tables[tablename] != null)
        //            return (DataTable)_metadata.Tables[tablename];
        //        else
        //        {
        //            DataTable dt = null;
        //            DataSet ds = new DataSet();
        //            DbDataAdapter da = db.GetDataAdapter();

        //            _metadatamu.WaitOne();
        //            try
        //            {
                       
                        
        //                        if (connection is OracleConnection)
        //                        {
        //                            da.SelectCommand = db.GetSqlStringCommand(String.Format("SELECT * FROM {0} WHERE ROWNUM < 1", tablename));
        //                        }
        //                        else if (connection is SqlConnection)
        //                        {
        //                            da.SelectCommand = db.GetSqlStringCommand(String.Format("SET FMTONLY ON SELECT TOP 0 * FROM {0} SET FMTONLY OFF", tablename));
        //                        }
        //                        da.SelectCommand.Connection = connection;

        //                        da.FillSchema(ds, SchemaType.Source, tablename);

        //                        if (connection is OracleConnection)
        //                        {
        //                            OracleCommandBuilder cmdb = new OracleCommandBuilder((OracleDataAdapter)da);
        //                            ((OracleDataAdapter)da).InsertCommand = cmdb.GetInsertCommand();
        //                            ((OracleDataAdapter)da).UpdateCommand = cmdb.GetUpdateCommand();
        //                            ((OracleDataAdapter)da).DeleteCommand = cmdb.GetDeleteCommand();
        //                        }
        //                        else if (connection is SqlConnection)
        //                        {
        //                            SqlCommandBuilder cmdb = new SqlCommandBuilder((SqlDataAdapter)da);
        //                          //  ((SqlDataAdapter)da).InsertCommand = cmdb.GetInsertCommand();
        //                            if (ds.Tables[0].PrimaryKey.Length>0)
        //                               ((SqlDataAdapter)da).InsertCommand = getInsertCommand(cmdb,ds.Tables[0].PrimaryKey[0].ColumnName);
        //                            else
        //                               ((SqlDataAdapter)da).InsertCommand = cmdb.GetInsertCommand(); 
        //                            //  ((SqlDataAdapter)da).InsertCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                            ((SqlDataAdapter)da).UpdateCommand = cmdb.GetUpdateCommand();
        //                            // ((SqlDataAdapter)da).UpdateCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                            ((SqlDataAdapter)da).DeleteCommand = cmdb.GetDeleteCommand();
        //                            // ((SqlDataAdapter)da).DeleteCommand.CommandTimeout = db.DefaultCommandTimeout;
        //                        }
                            
        //                if (ds != null && ds.Tables.Count > 0)
        //                {
        //                    _commandsmetadata.Add(tablename, da);
        //                    dt = ds.Tables[0];
        //                    _metadata.Merge(dt);
        //                }
        //            }
        //            finally
        //            {
        //                _metadatamu.ReleaseMutex();
        //            }
        //            return dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static DataSet GetTableMetadata(Database db, string[] tablenames)
        //{
        //    DataSet output = new DataSet();
        //    DbConnection connection = db.CreateConnection();
        //    try
        //    {
        //        connection.Open(); 
        //        foreach (string tablename in tablenames)
        //        {
        //            DataTable table = GetTableMetadata(db, connection, tablename);
        //            if (table != null)
        //                output.Merge(table);
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open) connection.Close();
        //    }
        //    return output;
        //}

        #endregion

        #region Maintenance

        //static public void ApplyUpdates(Database db, DataSet input)
        //{
        //    try
        //    {
        //        if (!input.HasChanges()) return;
        //        using (DbConnection  connection = db.CreateConnection())
        //        {
        //            connection.Open();
        //            DbTransaction transaction = connection.BeginTransaction();
        //            try
        //            {
        //                input.EnforceConstraints = false;
        //                DataSet datadelete = input.GetChanges(DataRowState.Deleted);
        //                DataSet datainsert = input.GetChanges(DataRowState.Added);
        //                DataSet dataupdate = input.GetChanges(DataRowState.Modified);

        //                if (datadelete != null)
        //                {
        //                    for (int i = datadelete.Tables.Count - 1; i >= 0; i--)
        //                    {
        //                        DbDataAdapter da = GetTableCommands(db, datadelete.Tables[i].TableName);
        //                        da.InsertCommand.Connection = connection;
        //                        da.InsertCommand.Transaction = transaction;
        //                        da.UpdateCommand.Connection = connection;
        //                        da.UpdateCommand.Transaction = transaction;
        //                        da.DeleteCommand.Connection = connection;
        //                        da.DeleteCommand.Transaction = transaction;
        //                        ((DbDataAdapter)da).Update(datadelete, datadelete.Tables[i].TableName);
        //                    }
        //                }

        //                if (dataupdate != null)
        //                {
        //                    foreach (DataTable table in dataupdate.Tables)
        //                    {
        //                        DbDataAdapter da = GetTableCommands(db, table.TableName);
        //                        da.InsertCommand.Connection = connection;
        //                        da.InsertCommand.Transaction = transaction;
        //                        da.UpdateCommand.Connection = connection;
        //                        da.UpdateCommand.Transaction = transaction;
        //                        da.DeleteCommand.Connection = connection;
        //                        da.DeleteCommand.Transaction = transaction;
        //                        ((DbDataAdapter)da).Update(dataupdate, table.TableName);
        //                    }
        //                }

        //                if (datainsert != null)
        //                {
        //                    foreach (DataTable table in datainsert.Tables)
        //                    {
        //                        DbDataAdapter da = GetTableCommands(db, table.TableName);
        //                        da.InsertCommand.UpdatedRowSource  = UpdateRowSource.Both ;
        //                        da.InsertCommand.Connection = connection;
        //                        da.InsertCommand.Transaction = transaction;
        //                        da.UpdateCommand.Connection = connection;
        //                        da.UpdateCommand.Transaction = transaction;
        //                        da.DeleteCommand.Connection = connection;
        //                        da.DeleteCommand.Transaction = transaction;
        //                        ((DbDataAdapter)da).Update(datainsert, table.TableName);
        //                    }
        //                }

        //                transaction.Commit();
        //                //input.EnforceConstraints = true;
        //                input.AcceptChanges();
        //            }
        //            catch (Exception ex)
        //            {
        //                transaction.Rollback();
        //                throw;
        //            }
        //            finally
        //            {
        //                if (connection.State == ConnectionState.Open) connection.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        static public SqlCommand getInsertCommand(SqlCommandBuilder cmdBuilder, string pkName)
        {

            SqlCommand  cmdInsert = new SqlCommand(cmdBuilder.GetInsertCommand().CommandText + "; Select SCOPE_IDENTITY() as " + pkName);
            SqlParameter[] sqlParam = new SqlParameter[cmdBuilder.GetInsertCommand().Parameters.Count];
            cmdBuilder.GetInsertCommand().Parameters.CopyTo(sqlParam, 0);
            cmdBuilder.GetInsertCommand().Parameters.Clear();
            for (int i = 0; i < sqlParam.Length; i++)
                cmdInsert.Parameters.Add(sqlParam[i]);
            cmdInsert.UpdatedRowSource = UpdateRowSource.Both;  
            return cmdInsert;


        }

        #endregion

        #region Query

        public static DataSet SelectAll(Database db, string tablename)
        {
            if (db == null || tablename.Equals(String.Empty))
                throw new ArgumentException();

            return db.ExecuteDataSet(CommandType.Text, String.Format("SELECT * FROM {0}", tablename));
        }

        //public static DataSet SelectByPK(Database db, string tablename, object[] keys)
        //{
        //    if (db == null || tablename.Equals(String.Empty) || keys.Length == 0)
        //        throw new ArgumentException();

        //    StringBuilder sb = new StringBuilder();
        //    DataTable dt = GetTableMetadata(db, tablename);
        //    bool needToken = false;
        //    int pos = 0;

        //    if (dt != null && dt.PrimaryKey.Length > 0)
        //    {
        //        foreach (DataColumn column in dt.PrimaryKey)
        //        {
        //            if (needToken) sb.Append(" AND ");
        //            sb.AppendFormat("{0} = '{1}'", column.ColumnName, keys[pos]);
        //            pos++;
        //            needToken = true;
        //        }
        //        if (!sb.ToString().Equals(String.Empty))
        //        {
        //            DataSet ds = db.ExecuteDataSet(CommandType.Text, String.Format("SELECT * FROM {0} WHERE {1}", tablename, sb.ToString()));
        //            ds.Tables[0].TableName = tablename;
        //            return ds;
        //        }
        //        else
        //            return null;
        //    }
        //    return null;
        //}

        #endregion
		    
    }
    

