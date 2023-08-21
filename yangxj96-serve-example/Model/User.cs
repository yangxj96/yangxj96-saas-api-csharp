using SqlSugar;
using yangxj96_serve_example.Common;

namespace yangxj96_serve_example.Model;

[SugarTable("db_user.t_user")]
public class User : BaseEntity
{
    /// <summary>
    /// 用户名
    /// </summary>
    [SugarColumn(ColumnName = "username")]
    public string? Username { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    [SugarColumn(ColumnName = "password")]
    public string? Password { get; set; }

    /// <summary>
    /// 账号是否过期
    /// </summary>
    [SugarColumn(ColumnName = "access_expired")]
    public bool AccessExpired { get; set; } = false;

    /// <summary>
    /// 账号是否锁定
    /// </summary>
    [SugarColumn(ColumnName = "access_locked")]
    public bool AccessLocked { get; set; } = false;

    /// <summary>
    /// 账号是否启用
    /// </summary>
    [SugarColumn(ColumnName = "access_enable")]
    public bool AccessEnable { get; set; } = true;

    /// <summary>
    /// 密码是否过期
    /// </summary>
    [SugarColumn(ColumnName = "credentials_expired")]
    public bool CredentialsExpired { get; set; } = false;

    public override string ToString()
    {
        return
            $"{nameof(Username)}: {Username}, {nameof(Password)}: {Password}, {nameof(AccessExpired)}: {AccessExpired}, {nameof(AccessLocked)}: {AccessLocked}, {nameof(AccessEnable)}: {AccessEnable}, {nameof(CredentialsExpired)}: {CredentialsExpired}";
    }
}