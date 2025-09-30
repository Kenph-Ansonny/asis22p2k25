using CapaModelo_Menu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Menu
{
    public class Cls_DepartamentoControlador
    {
        Cls_DepartamentoDAO dao = new Cls_DepartamentoDAO();

        public void AgregarUsuario(int id_departamento, string departamento, string estado)
        {
            if (id_departamento <= 0) throw new Exception("El ID debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(departamento)) throw new Exception("El departamento no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(estado)) throw new Exception("el estado no puede estar vacía.");

            var nuevoUsuario = new Cls_Departamento
            {
                Id_Departamento = id_departamento,
                Departamento = departamento,
                Estado = estado
            };

            dao.Insert(nuevoUsuario);
        }

        //método para actualizar un usuario existente (desde la vista de usuarios)
        public void ActualizarUsuario(int idDep, string departamento, string estado)
        {
            if (idDep <= 0) throw new Exception("El ID de usuario debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(departamento)) throw new Exception("El nombre de usuario no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(estado)) throw new Exception("La contraseña no puede estar vacía.");

            var usuarioActualizado = new Cls_Departamento
            {
                Id_Departamento = idDep,
                Departamento = departamento,
                Estado = estado
            };

            dao.Update(usuarioActualizado);
        }

        //método para eliminar un usuario (desde la vista de usuarios)
        public void EliminarUsuario(int id_dep)
        {
            if (id_dep <= 0) throw new Exception("El ID de usuario no es válido.");

            var usuarioEliminar = new Cls_Departamento { Id_Departamento = id_dep };
            dao.Delete(usuarioEliminar);
        }

        public DataTable CargarUsuarios()
        {
            List<Cls_Departamento> lista = dao.Select();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo Departamento", typeof(int));
            dt.Columns.Add("Departamento", typeof(string));
            dt.Columns.Add("Estado", typeof(string));

            foreach (var u in lista)
            {
                dt.Rows.Add(u.Id_Departamento, u.Departamento, u.Estado);
            }

            return dt;
        }

    }
}
