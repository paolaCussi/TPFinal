using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistroUsuario : Form
    {
        public FormRegistroUsuario()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);
        byte[] foto = null;
        private void FormRegistroUsuario_Load(object sender, EventArgs e)
        {
            lblTipoUsuario.Text += RolesCache.nombreRol;
            UserModel userModel = new UserModel();
            cmbSexo.DataSource = userModel.cargarSexo();
        }
        public void LimpiarCampos()
        {
            this.txtIdUsuario.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtDireccion.Text = "";
            this.txtDni.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
            this.dtpFechaNac.Text = "";
            this.cmbSexo.Text = "";            
            this.txtUsuario.Text = "";
            this.txtClave.Text = "";
            this.pcbFoto = null;
            foto = null;
        }
        
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "files jpg (*.jpg)|*.jpg|files png (*.png)|*.png|files jpeg (*.jpeg)|*.jpeg";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();
                        pcbFoto.Load(filePath);

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        Stream myStream = openFileDialog.OpenFile();
                        //convirtiendo imagen a byte
                        using (MemoryStream ms = new MemoryStream())
                        {
                            myStream.CopyTo(ms);
                            foto = ms.ToArray();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargo Correctamente la imagen", ex.ToString());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel userModel = new UserModel();
               
                userModel.insertUser(
                    this.txtNombre.Text,
                    this.txtApellido.Text, 
                    this.txtDireccion.Text,
                    this.txtDni.Text, 
                    this.txtTelefono.Text,
                    this.txtEmail.Text,
                    this.dtpFechaNac.Value.Date,
                    this.cmbSexo.SelectedValue.ToString(),
                    RolesCache.idRol,
                    this.txtUsuario.Text, this.txtClave.Text, foto);
                LimpiarCampos();
                MessageBox.Show("El registro fue exitoso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ingreso Correctamente los Datos", ex.ToString());
            }
        }       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormLogin login =FormLogin.ObtenerInstanciaLogin();
            login.Show();            
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormRolUsuario rolUser = new FormRolUsuario();
            rolUser.Show();
            this.Close();
        }
    }
}
