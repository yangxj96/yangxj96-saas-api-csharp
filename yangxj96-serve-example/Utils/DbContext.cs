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
            ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=QuVsKppcWvwwX2Vv;Database=yangxj96_saas_db;",
            DbType = DbType.PostgreSQL,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });
    }
}