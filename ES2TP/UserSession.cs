﻿using Microsoft.AspNetCore.Http;

namespace ES2TP
{

public static class UserSession
{
    private static readonly HttpContextAccessor Accessor = new();
        
    private const string IdUserKey = "IdUser";
    private const string UserNameKey = "Username";
    public static string username;
    public static int idutilizador;
    public static int idAtivoFinanceiro;
    public static int idadmin;

    public static string Username
    {
        get => Accessor.HttpContext?.Session.GetString(UserNameKey);
        set
        {
            if (value != null)
            {
                Accessor.HttpContext?.Session.SetString(UserNameKey, value);
            }
            else
            {
                Accessor.HttpContext?.Session.Remove(UserNameKey);
            }
        }
    }
        
    public static int? UserId
    {
        get => Accessor.HttpContext?.Session.GetInt32(IdUserKey);
        set
        {
            if (value != null)
            {
                Accessor.HttpContext?.Session.SetInt32(IdUserKey, (int)value);
            }
            else
            {
                Accessor.HttpContext?.Session.Remove(IdUserKey);
            }
        }
    }
}
}