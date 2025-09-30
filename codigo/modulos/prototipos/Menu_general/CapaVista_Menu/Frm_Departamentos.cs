using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Menu;
using CapaControlador_Seguridad;

namespace CapaVista_Menu
{
    public partial class Frm_Departamentos : Form
    {
        Cls_DepartamentoControlador usuarioController = new Cls_DepartamentoControlador();
        CapaControlador_Seguridad.Controlador auditoriaBitacora = new CapaControlador_Seguridad.Controlador();
        int idUsuarioConectado = 1;
        int codigoAplicacion = 1; // código de aplicación "Usuario"
        bool bEstado = true;

        public Frm_Departamentos()
        {
            InitializeComponent();
        }

        private void CargarDep()
        {
            Dgv_Departamentos.DataSource = null;
            Dgv_Departamentos.DataSource = usuarioController.CargarUsuarios();
        }

        private void LimpiarCampos()
        {
            Txt_IdDepartamento.Clear();
            Txt_Departamento.Clear();
            Txt_Estado.Clear();
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Txt_IdDepartamento.Text.Trim());
                string departamento = Txt_Departamento.Text.Trim();
                string estado = Txt_Estado.Text.Trim();

                usuarioController.AgregarUsuario(id, departamento, estado);
                auditoriaBitacora.RegistrarAccion(idUsuarioConectado, codigoAplicacion, "INS", bEstado);

                CargarDep();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(Txt_IdDepartamento.Text.Trim());
                string nombre = Txt_Departamento.Text.Trim();
                string contraseña = Txt_Estado.Text.Trim();

                usuarioController.ActualizarUsuario(id, nombre, contraseña);

                // registrar en bitácora
                auditoriaBitacora.RegistrarAccion(idUsuarioConectado, codigoAplicacion, "UPD", bEstado);

                CargarDep();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Txt_IdDepartamento.Text.Trim());
                var confirm = MessageBox.Show("¿Eliminar este Departamento?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    usuarioController.EliminarUsuario(id);

                    // registrar en bitácora
                    auditoriaBitacora.RegistrarAccion(idUsuarioConectado, codigoAplicacion, "DEL", bEstado);

                    CargarDep();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
