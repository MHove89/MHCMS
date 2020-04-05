namespace MHCMS.Infrastructure.Configuration
{
    public static class InfrastructureConfigurationKeys
    {
        public static string PersistenceSection => "persistenceSettings";
        public static string DbProvider => "DbProvider";
        public static string Mssql => "MSSQL_EF";
        public static string DatabaseName => "MHCMS";
    }
}