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
    public partial class frmMainCategoria : Form
    {

        CategoriaBC CategoriaBC = new CategoriaBC();

        public frmMainCategoria()
        {
            InitializeComponent();
        }

        private void frmMainCategoria_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.frmMain = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    var categoria = (CategoriaProductoBE)dgvCategorias.SelectedRows[0].DataBoundItem;
                    frmCategoria frm = new frmCategoria();
                    frm.categoria = categoria;
                    frm.frmMain = this;
                    frm.MdiParent = this;

                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    var categoria = (CategoriaProductoBE)dgvCategorias.SelectedRows[0].DataBoundItem;

                    if (CategoriaBC.Eliminar(categoria.CategoriaId))
                    {
                        MessageBox.Show("Se elimino correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarGrilla() 
        {
            dgvCategorias.DataSource = CategoriaBC.Listar();
            dgvCategorias.Refresh();
        }
    }
}
