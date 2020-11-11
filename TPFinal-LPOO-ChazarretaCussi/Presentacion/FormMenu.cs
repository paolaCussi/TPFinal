using Dominio;
using Entidades;
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

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        private FormMenu()
        {
            InitializeComponent();            
            
            ValidarUsuario();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private static FormMenu Instancia = null;
        public static FormMenu ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FormMenu();
                return Instancia;
            }
            else
            {

                Instancia.ValidarUsuario();
                return Instancia;
            }
        }
        public void BuscarUser()
        {
            
        }
       
        public void ValidarUsuario()
        {
            if (UserCache.idUsuario > 0)
            {
                lblUsuario.Text = UserCache.nombre;
                lblNombreUsu.Text = UserCache.nombre;
                RolesModel rolModel = new RolesModel();
                rolModel.SearchIdRol(UserCache.idRol);
                lblRol.Text = RolesCache.nombreRol;
                var foto = (byte[])UserCache.foto;
                var ms = new MemoryStream(foto);
                this.pcbImagen.Image = Image.FromStream(ms);

                if (RolesCache.nombreRol != null)
                {
                    if (RolesCache.nombreRol == "Lider de Agrupacion")
                    {
                        btnUno.Text = "EVENTOS";
                        btnDos.Text = "INFORMACION";
                        btnTres.Text = "NOTIFICACION";
                        btnCuatro.Visible = false;
                    }
                    else
                    {

                        btnUno.Text = "REGISTRAR MASCOTA";
                        btnDos.Text = "EVENTOS";
                        btnTres.Text = "INFORMACION";
                        btnCuatro.Text = "NOTIFICACION";
                    }
                }
            }
            else
            {
                //usuario sin registrarse
                lblUsuario.Text = "";
                lblNombreUsu.Text = "";
                lblRol.Text = "";
                this.pcbImagen.Visible = false;
                btnUno.Text = "EVENTOS";
                btnDos.Text = "INFORMACION";
                btnTres.Visible = false;
                btnCuatro.Visible = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            UserCache.idUsuario = 0;
            UserCache.nombre = null;
            UserCache.apellido = null;
            UserCache.direccion = null;
            UserCache.dni = null;
            UserCache.telefono = null;
            UserCache.correo = null;
            UserCache.sexo = null;
            UserCache.idRol = 0;
            UserCache.usuario = null;
            UserCache.password = null;
            UserCache.foto = null;
            FormLogin login = FormLogin.ObtenerInstanciaLogin();
            login.Show();
            this.Close();
            Instancia = null;
        }
    }
}
