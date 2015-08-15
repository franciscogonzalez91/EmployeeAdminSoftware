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
    public partial class MainForm : Form
    {
        Empleados EmpObj;
        public MainForm()
        {
            InitializeComponent();            
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            EmpObj = new Empleados();
            EmpObj.ShowDialog();
        }

        

    }
}
