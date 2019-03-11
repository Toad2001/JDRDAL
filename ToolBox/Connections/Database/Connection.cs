using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Connections.Database
{
    public class Connection : IConnection
    {
        private string _ConnectionString;

        public Connection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException();
            }
            _ConnectionString = connectionString;

            using (SqlConnection c = CreateConnection())
            {
                c.Open();
            }
        }

        private SqlConnection CreateConnection()
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = _ConnectionString;
            return sqlconnection;
        }

        private SqlCommand CreateCommand(Command command, SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command.Query;
            cmd.CommandType = (command.IsStoredProcedure) ? CommandType.StoredProcedure : CommandType.Text;
            foreach (KeyValuePair<string, ToolBox.Connections.Database.Parameter> kvPair in command.Parameters)
            {
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = kvPair.Key;
                sqlParameter.Value = kvPair.Value.Value; //? null : DBNull.Value;
                cmd.Parameters.Add(sqlParameter);
            }
            return cmd;
        }

        public int ExecuteNonQuery(Command command)
        {
            using (SqlConnection c = CreateConnection())
            {
                using (SqlCommand cmd = CreateCommand(command, c))
                {
                    c.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(Command command)
        {
            using (SqlConnection c = CreateConnection())
            {
                using (SqlCommand cmd = CreateCommand(command, c))
                {
                    c.Open();
                    object o = cmd.ExecuteScalar();
                    return (o is DBNull) ? null : o;
                }

            }
        }

        public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector)
        {
            using (SqlConnection c = CreateConnection())
            {
                using (SqlCommand cmd = CreateCommand(command, c))
                {
                    c.Open();
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                            yield return selector(sqlDataReader);
                    }
                }
            }
        }

        public DataTable GetDataTable(Command command)
        {
            using (SqlConnection c = CreateConnection())
            {
                using (SqlCommand cmd = CreateCommand(command, c))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }
    }
    //    private DbProviderFactory Factory { get; set; }
    //    private string ConnectionString { get; set; }

    //    public Connection(string invariantName, string connectionString)
    //    {
    //        ConnectionString = connectionString;
    //        Factory = DbProviderFactories.GetFactory(invariantName);

    //        using (DbConnection connection = CreateConnection())
    //        {
    //            connection.Open();
    //        }
    //    }

    //    public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector)
    //    {
    //        using (DbConnection connection = CreateConnection())
    //        {
    //            using (DbCommand dbCommand = CreateCommand(command, connection))
    //            {
    //                connection.Open();
    //                using (DbDataReader reader = dbCommand.ExecuteReader())
    //                {
    //                    while(reader.Read())
    //                    {
    //                        yield return selector(reader);
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    public dynamic ExecuteScalar(Command command)
    //    {
    //        using (DbConnection connection = CreateConnection())
    //        {
    //            using (DbCommand dbCommand = CreateCommand(command, connection))
    //            {
    //                connection.Open();
    //                object o = dbCommand.ExecuteScalar();
    //                return (o is DBNull) ? null : o;
    //            }
    //        }
    //    }

    //    public int ExecuteNonQuery(Command command)
    //    {
    //        using (DbConnection connection = CreateConnection())
    //        {
    //            using (DbCommand dbCommand = CreateCommand(command, connection))
    //            {
    //                connection.Open();
    //                return dbCommand.ExecuteNonQuery();                    
    //            }
    //        }
    //    }

    //    private DbCommand CreateCommand(Command command, DbConnection connection)
    //    {
    //        DbCommand dbCommand = connection.CreateCommand();
    //        dbCommand.CommandText = command.Query;
    //        dbCommand.CommandType = (command.IsStoredProcedure) ? CommandType.StoredProcedure : CommandType.Text;

    //        foreach (Parameter p in command.Parameters.Values)
    //        {
    //            DbParameter parameter = Factory.CreateParameter();
    //            parameter.ParameterName = p.ParameterName;
    //            parameter.Value = p.Value ?? DBNull.Value;

    //            if (p.Type != null)
    //                parameter.DbType = p.Type.Value;

    //            dbCommand.Parameters.Add(parameter);
    //        }

    //        return dbCommand;
    //    }

    //    private DbConnection CreateConnection()
    //    {
    //        DbConnection connection = Factory.CreateConnection();
    //        connection.ConnectionString = ConnectionString;

    //        return connection;
    //    }
    //}
}
