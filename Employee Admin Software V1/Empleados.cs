using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Admin_Software_V1
{
    public partial class Empleados : Form
    {

        //Objetos
        BuscarEmpleado Buscar;

        public Empleados()
        {
            InitializeComponent();
            StartProperties();
        }

        public void CancelClear()
        {

        }

        public void StartProperties()
        {
            //Window Properties
            this.StartPosition = FormStartPosition.CenterScreen;

            //Textboxs Properties            
            txtNoEmp.MaxLength = 4;
            txtNoEmp.ReadOnly = true;
            txtNombre.MaxLength = 24;
            txtApellido.MaxLength = 24;           
            txtDireccion.MaxLength = 50;
            txtCiudad.MaxLength = 24;
            txtEstado.MaxLength = 24;
         
            //Null Start Values
            DTPFechaIngreso.Value = DateTime.Now.Date;
            DTPFechaEgreso.Value = DateTime.Now.Date;
            DTPFechaIngreso.MinDate = DateTime.Today;
            DTPFechaIngreso.MaxDate = DateTime.Today.AddMonths(2);
            //DTPFechaEgreso.MaxDate = DateTime.Parse("12/12/2099");
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtApellido.SelectAll();
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            txtDireccion.SelectAll();
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            txtCiudad.SelectAll();
        }

        private void txtCiudad_Leave(object sender, EventArgs e)
        {
            txtEstado.SelectAll();
        }

        private void DTPFechaEgreso_Leave(object sender, EventArgs e)
        {
            txtNombre.SelectAll();
        }

        private void cboxPuesto_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void cboxPuesto_Leave(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Enabled Controls
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cboxPuesto.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEstado.Enabled = true;
            DTPFechaIngreso.Enabled = true;
            DTPFechaIngreso.Enabled = true;            
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;

            //Disambled Controls
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Clear Controls
            txtNombre.Clear();
            txtApellido.Clear();
            cboxPuesto.Text = "";
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtEstado.Clear();
            DTPFechaEgreso.Value = DateTime.Today;
            DTPFechaIngreso.Value = DateTime.Today;

            //Disabled Controls
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cboxPuesto.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtEstado.Enabled = false;
            DTPFechaIngreso.Enabled = false;
            DTPFechaIngreso.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;

            //Enabled Controls
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar = new BuscarEmpleado();
            Buscar.ShowDialog();
        }

        

        
    }

}
