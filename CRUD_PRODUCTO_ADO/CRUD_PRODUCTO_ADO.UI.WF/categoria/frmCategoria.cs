using CRUD_PRODUCTO_ADO.BL.BC;
using CRUD_PRODUCTO_ADO.BL.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PRODUCTO_ADO.UI.WF.categoria
{
    public partial class frmCategoria : Form
    {
        public CategoriaProductoBE categoria = null;
        public frmMainCategoria frmMain = new frmMainCategoria();

        private CategoriaBC categoriaBC = new CategoriaBC();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    categoria.Nombre = txtNombre.Text;
                    if (categoriaBC.Actualizar(categoria))
                    {
                        MessageBox.Show("Se actualizo satisfactoriamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema.");
                    }
                }
                else
                {
                    if (categoriaBC.Insertar(new CategoriaProductoBE { Nombre = txtNombre.Text }))
                    {
                        MessageBox.Show("Se inserto satisfactoriamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema.");

                    }
                }

                frmMain.ActualizarGrilla();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtNombre.Text = categoria.Nombre;
            }
        }
    }
}
