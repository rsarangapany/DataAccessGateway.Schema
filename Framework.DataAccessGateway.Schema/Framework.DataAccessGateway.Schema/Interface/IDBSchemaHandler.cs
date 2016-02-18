﻿using System;
using System.Collections.Generic;
using Framework.DataAccessGateway.Schema.Collection;
using Framework.DataAccessGateway.Schema.DataStructure;
using Framework.DataAccessGateway.Schema.Enum;

namespace Framework.DataAccessGateway.Schema.Interface
{
    /// <summary>
    ///     Summary description for IDBSchemaHandler
    /// </summary>
    internal interface IDBSchemaHandler : IDisposable
    {
        #region Public Properties

        /// <summary>
        ///     Read Only: ConnectionString for the database.
        /// </summary>
        string ConnectionString { get; }

        #endregion Public Properties

        #region IDisposable Members

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        new void Dispose();

        #endregion IDisposable Members

        #region Public Methods

        /// <summary>
        ///     Gets the database server listing.
        /// </summary>
        /// <returns>List{DBSchemaServerDefinition}.</returns>
        List<DBSchemaServerDefinition> GetDBServerListing();

        /// <summary>
        ///     Gets the database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>DBSchemaDBDefinition.</returns>
        DBSchemaDBDefinition GetDB(string connectionString);

        /// <summary>
        ///     Gets the database.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <returns>DBSchemaDBDefinition.</returns>
        DBSchemaDBDefinition GetDB(string dbServerName, string dbUserID, string dbPassword, string dbName);

        /// <summary>
        ///     Gets the database listing.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>List{DBSchemaDBDefinition}.</returns>
        List<DBSchemaDBDefinition> GetDBListing(string dbServerName, string dbUserID, string dbPassword);

        /// <summary>
        ///     Gets the table definition.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaTableDefinition.</returns>
        DBSchemaTableDefinition GetTableDefinition(string dbServerName, string dbName, string tableName, string dbUserID,
            string dbPassword);

        /// <summary>
        ///     Gets the table definition listing.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaTableDefinitionCollection.</returns>
        DBSchemaTableDefinitionCollection GetTableDefinitionListing(string dbServerName, string dbName, string dbUserID,
            string dbPassword);

        /// <summary>
        ///     Gets the proc definition.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="procName">Name of the proc.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaStoredProcedureDefinition.</returns>
        DBSchemaStoredProcedureDefinition GetProcDefinition(string dbServerName, string dbName, string procName,
            string dbUserID, string dbPassword);

        /// <summary>
        ///     Gets the proc definition listing.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaStoredProcedureDefinitionCollection.</returns>
        DBSchemaStoredProcedureDefinitionCollection GetProcDefinitionListing(string dbServerName, string dbName,
            string dbUserID, string dbPassword);

        /// <summary>
        ///     Gets the trigger definition.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="triggerName">Name of the trigger.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaTriggerDefinition.</returns>
        DBSchemaTriggerDefinition GetTriggerDefinition(string dbServerName, string dbName, string triggerName,
            string dbUserID, string dbPassword);

        /// <summary>
        ///     Gets the trigger definition listing.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>DBSchemaTriggerDefinitionCollection.</returns>
        DBSchemaTriggerDefinitionCollection GetTriggerDefinitionListing(string dbServerName, string dbName,
            string dbUserID, string dbPassword);

        /// <summary>
        ///     Creates the database.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbSchemaDBInstance">The database schema database instance.</param>
        void CreateDatabase(string dbServerName, string dbUserID, string dbPassword,
            DBSchemaDBDefinition dbSchemaDBInstance);

        /// <summary>
        ///     Creates the database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbSchemaDBInstance">The database schema database instance.</param>
        void CreateDatabase(string connectionString, DBSchemaDBDefinition dbSchemaDBInstance);

        /// <summary>
        ///     Alters the database.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbSchemaDBInstance">The database schema database instance.</param>
        void AlterDatabase(string dbServerName, string dbUserID, string dbPassword,
            DBSchemaDBDefinition dbSchemaDBInstance);

        /// <summary>
        ///     Alters the database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbSchemaDBInstance">The database schema database instance.</param>
        void AlterDatabase(string connectionString, DBSchemaDBDefinition dbSchemaDBInstance);

        /// <summary>
        ///     Drops the database.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbName">Name of the database.</param>
        void DropDatabase(string dbServerName, string dbUserID, string dbPassword, string dbName);

        /// <summary>
        ///     Drops the database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbName">Name of the database.</param>
        void DropDatabase(string connectionString, string dbName);

        /// <summary>
        ///     Creates the table.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbSchemaTableDefinition">The database schema table definition.</param>
        void CreateTable(string dbServerName, string dbName, string dbUserID, string dbPassword,
            DBSchemaTableDefinition dbSchemaTableDefinition);

        /// <summary>
        ///     Creates the table.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbSchemaTableDefinition">The database schema table definition.</param>
        void CreateTable(string connectionString, DBSchemaTableDefinition dbSchemaTableDefinition);

        /// <summary>
        ///     Alters the table.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="dbOldSchemaTableDefinition">The database old schema table definition.</param>
        /// <param name="dbNewSchemaTableDefinition">The database new schema table definition.</param>
        /// <param name="dbSchemaAlterTableOperation">The database schema alter table operation.</param>
        void AlterTable(string dbServerName, string dbName, string dbUserID, string dbPassword,
            DBSchemaTableDefinition dbOldSchemaTableDefinition, DBSchemaTableDefinition dbNewSchemaTableDefinition,
            DBSchemaAlterTableOperation dbSchemaAlterTableOperation);

        /// <summary>
        ///     Alters the table.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbOldSchemaTableDefinition">The database old schema table definition.</param>
        /// <param name="dbNewSchemaTableDefinition">The database new schema table definition.</param>
        /// <param name="dbSchemaAlterTableOperation">The database schema alter table operation.</param>
        void AlterTable(string connectionString, DBSchemaTableDefinition dbOldSchemaTableDefinition,
            DBSchemaTableDefinition dbNewSchemaTableDefinition, DBSchemaAlterTableOperation dbSchemaAlterTableOperation);

        /// <summary>
        ///     Drops the table.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <param name="tableName">Name of the table.</param>
        void DropTable(string dbServerName, string dbName, string dbUserID, string dbPassword, string tableName);

        /// <summary>
        ///     Drops the table.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="tableName">Name of the table.</param>
        void DropTable(string connectionString, string tableName);

        /// <summary>
        ///     Builds the connection string.
        /// </summary>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        /// <returns>System.String.</returns>
        string BuildConnectionString(string dbServerName, string dbName, string dbUserID, string dbPassword);

        /// <summary>
        ///     Breaks the connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbServerName">Name of the database server.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUserID">The database user identifier.</param>
        /// <param name="dbPassword">The database password.</param>
        void BreakConnectionString(string connectionString, out string dbServerName, out string dbName,
            out string dbUserID, out string dbPassword);

        #endregion Public Methods
    }
}