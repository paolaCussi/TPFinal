using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        private FormLogin()
        {
            InitializeComponent();
            this.txtClave.UseSystemPasswordChar = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        private static FormLogin InstanciaLogin = null;
        public static FormLogin ObtenerInstanciaLogin()
        {
            if (InstanciaLogin == null)
            {
                InstanciaLogin = new FormLogin();
            }
            return InstanciaLogin;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "";
            this.txtClave.Text = "";
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            if (this.txtUsuario.Text != "" && this.txtUsuario.TextLength > 2)
            {
                if (this.txtClave.Text != "" && this.txtClave.TextLength > 2)
                {
                    var validate = userModel.validateUser(this.txtUsuario.Text, this.txtClave.Text);
                    if (validate)
                    {                        
                        FormMenu menu = FormMenu.ObtenerInstancia();
                        menu.Show();                   
                    }
                    else
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = "Usuario o Contraseña Incorrectos";
                    }
                }
            }
            else
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Usuario o Contraseña Incorrectos";
            }
        }
        private void btnInvitado_Click(object sender, EventArgs e)
        {
            FormMenu menu = FormMenu.ObtenerInstancia();
            menu.Show();
        }
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FormRolUsuario rolUser = new FormRolUsuario();
            rolUser.Show();
        }
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (this.txtClave.Text != "")
            {

                this.txtClave.ForeColor = Color.Black;
                this.txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.txtClave.ForeColor = Color.DimGray;
                this.txtClave.UseSystemPasswordChar = false;
            }
        }
        private void ckbMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarClave.Checked == true)
            {
                //this.txtClave.PasswordChar = '';
                this.txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                //this.txtClave.PasswordChar = '*';
                this.txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender,e);
            }
        }

    }
}
