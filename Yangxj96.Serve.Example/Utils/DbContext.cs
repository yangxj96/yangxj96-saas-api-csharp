using SqlSugar;

namespace Yangxj96.Serve.Example.Utils;

public class DbContext<T> where T : class, new()
{
    protected SqlSugarClient Db { get; }

    protected SimpleClient<T> SimpleDb => new(Db);

    protected DbContext(IConfiguration configuration)
    {
        var database = configuration.GetSection("Database");

        var connectionString = $"Server={database.GetSection("Host").Value};Port={database.GetSection("Port").Value};User Id={database.GetSection("Username").Value};Password={database.GetSection("Password").Value};Database={database.GetSection("DefaultDB").Value};";

        Db = new SqlSugarClient(new ConnectionConfig()
        {
            // ConnectionString = "Server=192.168.31.6;Port=5432;User Id=postgres;Password=QuVsKppcWvwwX2Vv;Database=yangxj96_saas_db;",
            ConnectionString = connectionString,
            DbType = DbType.PostgreSQL,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });
    }
}