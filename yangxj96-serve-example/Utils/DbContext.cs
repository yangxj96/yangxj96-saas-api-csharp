using SqlSugar;

namespace yangxj96_serve_example.Utils;

public class DbContext<T> where T : class, new()
{
    protected SqlSugarClient Db { get; }

    protected SimpleClient<T> SimpleDb => new(Db);

    protected DbContext()
    {
        Db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString =
                "Server=127.0.0.1;Port:5432;Database=yangxj96_saas_db;User=postgres;Password=QuVsKppcWvwwX2Vv;",
            DbType = DbType.PostgreSQL,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });
    }
}