﻿using SqlSugar;
using Yangxj96.Serve.Common.Base;

namespace Yangxj96.Serve.Example.Model;

[SugarTable("db_user.t_account")]
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
}