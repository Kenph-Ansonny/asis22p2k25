using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad;

namespace CapaVista_Menu
{
    public partial class MenuGeneral : Form
    {

        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void consultaBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.frmBitacora bitacora = new CapaVista_Seguridad.frmBitacora();
            bitacora.ShowDialog();
        }

        private void mantenimientoDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Departamentos frnDepartamentos = new Frm_Departamentos();
            frnDepartamentos.MdiParent = this;
            frnDepartamentos.Show();
        }

        private void reporteDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cambiar la ruta segun la ubicacion del proyecto
            string ruta = @"C:\Users\kenph\Documents\Proyectos Analisis de Sistema II\asis22p2k25\ayudas\AyudaSistema.chm";
            Help.ShowHelp(this, ruta, "MDI.html");
        }

        private void identificacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();   
            estudiante.MdiParent = this;
            estudiante.Show();  
        }
    }
}
