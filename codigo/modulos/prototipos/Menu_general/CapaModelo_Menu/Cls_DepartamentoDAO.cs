using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad;

namespace CapaModelo_Menu
{
    public class Cls_DepartamentoDAO
    {
        //instancia de la clase conexion
        private CapaModelo_Seguridad.Conexion conexion = new CapaModelo_Seguridad.Conexion();

        //sentencias sql para manejar la tabla de usuario
        private static readonly string SQL_SELECT = "SELECT codigo_departamento, departamento, estado FROM departamentos";
        private static readonly string SQL_INSERT = "INSERT INTO departamentos(codigo_departamento, departamento, estado) VALUES(?, ?, ?)";
        private static readonly string SQL_UPDATE = "UPDATE departamentos SET departamento = ?, estado = ? WHERE codigo_departamento= ?";
        private static readonly string SQL_DELETE = "DELETE FROM departamentos WHERE codigo_departamento= ?";
        private static readonly string SQL_QUERY = "SELECT codigo_departamento, departamento, estado  FROM departamentos WHERE departamento = ?";

        public List<Cls_Departamento> Select()
        {
            List<Cls_Departamento> usuarios = new List<Cls_Departamento>();
            using (var conn = conexion.conexion())
                {
                    //conn.Open();
                    OdbcCommand cmd = new OdbcCommand(SQL_SELECT, conn);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cls_Departamento usuario = new Cls_Departamento
                            {
                                Id_Departamento = reader.GetInt32(0),
                                Departamento = reader.GetString(1),
                                Estado = reader.GetString(2)
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            return usuarios;
        }

        public int Insert(Cls_Departamento usuario)
        {
            int filasAfectadas = 0;
            using (var conn = conexion.conexion())
            {
                //conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("codigo_departamento", usuario.Id_Departamento);
                cmd.Parameters.AddWithValue("departamento", usuario.Departamento);
                cmd.Parameters.AddWithValue("estado", usuario.Estado);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public int Update(Cls_Departamento usuario)
        {
            int filasAfectadas = 0;
            using (var conn = conexion.conexion())
            {
                //conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("departamento", usuario.Departamento);
                cmd.Parameters.AddWithValue("estado", usuario.Estado);
                cmd.Parameters.AddWithValue("codigo_departamento", usuario.Id_Departamento);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public int Delete(Cls_Departamento usuario)
        {
            int filasAfectadas = 0;
            using (var conn = conexion.conexion())
            {
                //conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("codigo_departamento", usuario.Id_Departamento);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public Cls_Departamento Query(string usuarioNombre)
        {
            Cls_Departamento usuario = null;
            using (var conn = conexion.conexion())
                {
                    //conn.Open();
                    OdbcCommand cmd = new OdbcCommand(SQL_QUERY, conn);
                    cmd.Parameters.AddWithValue("departamento", usuarioNombre);
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Cls_Departamento
                            {
                                Id_Departamento = reader.GetInt32(0),
                                Departamento = reader.GetString(1),
                                Estado = reader.GetString(2)
                            };
                        }
                    }
                }
            return usuario;
        }

    }
}
