using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRolUsuario : Form
    {
        public FormRolUsuario()
        {
            InitializeComponent();
            LimpiarCampos();
        }
        string rolUsuario;
       
        bool rol;
        public void LimpiarCampos() 
        {
            this.rbnAdoptante.Checked = false;
            this.rbnLider.Checked = false;
            this.rbnVolHogar.Checked = false;
        }
        private void rbnVoluntario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVoluntario.Checked == true)
            {
                rbnAdoptante.Checked = false;
                rbnLider.Checked = false;                
                rbnVolHogar.Visible = true;
                rbnVolPaseador.Visible = true;
                rbnVolPadrino.Visible = true;
                lblTipoVol.Visible = true;                
            }
        }

        private void rbnLider_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnLider.Checked == true)
            {
                rolUsuario = "Lider de Agrupacion";
                rbnAdoptante.Checked = false;
                rbnVoluntario.Checked = false;
                rbnVolHogar.Visible = false;
                rbnVolPaseador.Visible = false;
                rbnVolPadrino.Visible = false;
                lblTipoVol.Visible = false;
                RolesModel rolModel = new RolesModel();
                rol = rolModel.SearchRol(rolUsuario);
                //descrip = rolModel.SearchRolDesc(descripcion);
            }
        }

        private void rbnAdoptante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnAdoptante.Checked == true)
            {
                rolUsuario = "Adoptante";              
                rbnLider.Checked = false;
                rbnVoluntario.Checked = false;
                rbnVolHogar.Visible = false;
                rbnVolPaseador.Visible = false;
                rbnVolPadrino.Visible = false;
                lblTipoVol.Visible = false;
                RolesModel rolModel = new RolesModel();
                rol = rolModel.SearchRol(rolUsuario);
                
            }
        }
        private void rbnVolHogar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVolHogar.Checked == true)
            {
                rbnVolPaseador.Checked = false;
                rbnVolPadrino.Checked = false;
                rolUsuario = "Voluntario: Hogar de Acogida";                
                RolesModel rolModel = new RolesModel();
                rol = rolModel.SearchRol(rolUsuario);
            }
        }

        private void rbnVolPaseador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVolPaseador.Checked == true)
            {
                rbnVolHogar.Checked = false;
                rbnVolPadrino.Checked = false;
                rolUsuario = "Voluntario: Paseador";
                RolesModel rolModel = new RolesModel();
                rol = rolModel.SearchRol(rolUsuario);
            }
        }

        private void rbnVolPadrino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVolPadrino.Checked == true)
            {
                rbnVolHogar.Checked = false;
                rbnVolPaseador.Checked = false;
                rolUsuario = "Voluntario: Padrino";
                RolesModel rolModel = new RolesModel();
                rol = rolModel.SearchRol(rolUsuario);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            RolesModel rolModel = new RolesModel();
            MessageBox.Show("Rol: " + RolesCache.nombreRol+ " "+ RolesCache.idRol);
            if (RolesCache.nombreRol == "Lider de Agrupacion")
            {
                FormRegistrarUsuLider regUserLider = new FormRegistrarUsuLider();
                regUserLider.Show();           
            }
            else
            {
                FormRegistroUsuario regUser = new FormRegistroUsuario();
                regUser.Show();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin login = FormLogin.ObtenerInstanciaLogin();
            login.Show();
            this.Close();
        }       
    }
}
