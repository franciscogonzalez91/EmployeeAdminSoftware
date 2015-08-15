using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Admin_DB_Connection;

namespace Employee_Admin_Software_V1
{
    public partial class BuscarEmpleado : Form
    {
        //Objetos
        /// <summary>
        /// 
        /// </summary>
        DataBaseSqlConnection Conn = new DataBaseSqlConnection();

        //Variables
        /// <summary>
        /// 
        /// </summary>
        DataTable TablaEmpleado;

        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        private void txtNoEmpleado_TextChanged(object sender, EventArgs e)
        {
            if(txtNoEmpleado.TextLength < 3)
            {
                
            }
            else
            {
               TablaEmpleado = Conn.SearchEmployee(txtNoEmpleado.Text);
            }
        }
    }
}
