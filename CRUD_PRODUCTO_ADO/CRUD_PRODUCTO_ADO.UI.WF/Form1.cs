using CRUD_PRODUCTO_ADO.BL.BE;
using CRUD_PRODUCTO_ADO.UI.WF.categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PRODUCTO_ADO.UI.WF
{
    public partial class Form1 : Form
    {
        public UserBE userBE = new UserBE();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMainCategoria frm = new frmMainCategoria();
            frm.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Bienvenido " + userBE.Nombre + " " + userBE.Apellido;

            //if (userBE.Nombre.Equals("Diego"))
            //{
            //    btnProducto.Visible = false;
            //}

        }
    }
}
