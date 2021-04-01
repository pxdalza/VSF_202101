using CRUD_PRODUCTO_ADO.BL.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PRODUCTO_ADO.UI.WF.login
{
    
    public partial class frmLogin : Form
    {
        private static String path = @"files";
        private static String file_path = path + @"\readme.xwe";

        private UserBC userBC = new UserBC();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Length >0 && txtPassword.Text.Length > 0)
                {
                    var user = userBC.Login(txtUsername.Text, txtPassword.Text);

                    if (user != null) {
                        Form1 frm = new Form1();
                        frm.userBE = user;
                        frm.Show();
                        this.Hide();

                        if (cbxRecuerdame.Checked)
                        {
                            CreateFile();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un usuario y contraseña correcto.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa el usuario y contraseña.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Cuando levanta la aplicacion
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //Verificamos si el directorio existe
            if (directoryInfo.Exists)
            {
                //Si existe
                //implementamos el leer archivo

                //Verificamos de que el archivo exista
                if (File.Exists(file_path))
                {
                    //Si es asi creamos nuestro Reader para leer el archivo.
                    StreamReader sr = new StreamReader(file_path);
                    //leemos la primera linea
                    var line = sr.ReadLine();
                    //Concatenamos los strings en una sola variable
                    int i = 0;
                    String username = "", pas = "";
                    while (line != null)
                    {
                        if (i==0)
                        {
                            username = line;
                        }
                        else
                        {
                            pas = line;
                        }
                        //Leemos la siguiente linea.
                        line = sr.ReadLine();
                        i++;
                    }
                    //cerramos la sesion del streamReader.
                    sr.Close();

                    txtUsername.Text = username;
                    txtPassword.Text = pas;
                    cbxRecuerdame.Checked = true;
                    //var user = userBC.Login(username, pas);

                    //if (user != null)
                    //{
                    //    this.Hide();
                    //    this.Visible = false;
                    //    Form1 frm = new Form1();
                    //    frm.Show();

                    //}

                }
            }
            else
            {
                //Si no existe se crea la carpeta.
                directoryInfo.Create();
            }
        }

        private void CreateFile()
        {
            StreamWriter sw = new StreamWriter(file_path);
            sw.WriteLine(txtUsername.Text);
            sw.WriteLine(txtPassword.Text);
            sw.Close();
            

        }
    }
}
