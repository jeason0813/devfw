﻿//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : OPS.Data
//  @ File Name : IDataBase.cs
//  @ Date : 8/18/2011
//  @ Author : ����
//
//

namespace Ops.Data
{
    using System.Data;
    using System.Data.Common;


    public interface IDataBase
    {
        string ConnectionString { get; }
        DbConnection GetConnection();
        DbParameter CreateParameter(string name, object value);
        DbCommand CreateCommand(string sql);
        DbDataAdapter CreateDataAdapter(DbConnection connection, string sql);

        /// <summary>
        /// ִ�нű�
        /// </summary>
        /// <param name="sql">Sql�ű�</param>
        /// <param name="delimiter">�ָ����Ĭ��Ϊ";"</param>
        /// <returns></returns>
        int ExecuteScript(DbConnection conn, string sql, string delimiter);
    }

    public abstract class DataBaseFactory : IDataBase
    {
        protected string connectionString;

        public DataBaseFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return this.connectionString; }
        }

        public abstract DbConnection GetConnection();

        public abstract DbParameter CreateParameter(string name, object value);

        public abstract DbCommand CreateCommand(string commandText);

        public abstract DbDataAdapter CreateDataAdapter(DbConnection connection, string commandText);

        public abstract int ExecuteScript(DbConnection connection, string sql, string delimiter);
    }
}