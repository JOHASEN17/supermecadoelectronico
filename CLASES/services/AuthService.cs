﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using supermecadoelectronico.CLASES.utils;


namespace supermecadoelectronico.CLASES.services
{
    public class AuthService
    {
        public Usuario Login(string usuario, string clave)
        {
            var conn = dbConexionsingleton.Instancia;
            var cmd = new SqlCommand("sp_Login", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", clave);

            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var user = new Usuario
                {
                    IdUsuario = (int)reader["USUARIOID"],
                    NombreUsuario = reader["USERNAME"].ToString(),  
                    Rol = reader["ROL"].ToString()
                };
                conn.Close();
                return user;
            }
            conn.Close();
            return null;
        }
    }
}
