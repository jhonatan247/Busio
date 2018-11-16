
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Presentacion.Properties;
using BunifuAnimatorNS;
using Bunifu.Framework.UI;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using Presentacion.Controles;
using Presentacion.Formularios;
#endregion

#region DiseñoControles
namespace Presentacion.Usuario
{
    #region Login
    public partial class Login : UserControl
    {
        #region Atributos
        long id = 0;
        DataRow Drow;
        #endregion

        #region Delegados
        #endregion

        #region Eventos
        #endregion

        #region Propiedades
        #endregion

        #region Constructores
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        void ValidarUsuario()
        {
            if (txUsuario.IsCorrect())
            {
                try
                {
                    Drow = new Negocio.Manejo_de_datos.Usuario(txUsuario.Text).AutentificarUsuario();
                    if (Drow[1].ToString() == txUsuario.Text || Drow[2].ToString() == txUsuario.Text)
                    {
                        if (Drow[3].ToString() != "")
                            AccionesSistema.CropImage(AccionesSistema.ObtenerImagen(Drow[3]), pbPicture);
                        lbNombre.Text = Drow[4].ToString();
                        id = Convert.ToInt64(Drow[0]);
                        Animator.HideSync(pnlUser);
                        Animator.ShowSync(pnlPassword);
                        txContraseña.Focus();
                        return;
                    }
                }
                catch (Exception ex) {  }
                txUsuario.mostrarMensaje("El usuario es incorrecto");
            }
        }
        void Descativar(bool anim)
        {
            txUsuario.Hide();
            if (anim)
            {
                Animator.HideSync(pbLock);
            }
            else
                pbLock.Hide();
            txUsuario.Enabled = true;
            txUsuario.Location = new Point(29, 150);
            if (anim)
            {
                Animator.ShowSync(txUsuario);
            }
            else
                txUsuario.Show();
            txUsuario.Focus();
            lbMoreOpt.Show();
            bnContinue.Visible = true;
            txUsuario.Text = Settings.Default.usuario;
            if (txUsuario.Text.Length > 0)
                ValidarUsuario();
        }
        #endregion

        #region ControlEventos
        private void UserControl1_Load(object sender, EventArgs e)
        {
            Drow = new Caja().SelectVista(Settings.Default.Caja);
            Parent.Text = Drow[1].ToString()+" - Nuevo turno";
            lbLogin.Text = Drow[2].ToString().Substring(0,1).ToUpper()+ Drow[2].ToString().Substring(1, Drow[2].ToString().Length-1).ToLower();
            if (!Settings.Default.Bloquear)
                Descativar(false);
        }

        private void bnContinue_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }
        #endregion

        private void bnBack_Click(object sender, EventArgs e)
        {
            Animator.HideSync(pnlPassword);
            txContraseña.Limpiar();
            Animator.ShowSync(pnlUser);
        }

        private void bnSignIn_Click(object sender, EventArgs e)
        {
            if (txContraseña.IsCorrect())
            {
                try
                {
                    Drow = new Historial_Contraseña_Usuario().SelectContraseña(id);
                    if (Drow[0].ToString() == txContraseña.Text)
                    {
                        if (chRecordar.Checked)
                        {
                            Settings.Default.usuario = txUsuario.Text;
                            Settings.Default.Save();
                        }
                        AccionesSistema.GetFormParent(this).Hide();
                        new frmElegirSucursal(id).ShowDialog();
                        AccionesSistema.GetFormParent(this).Close();
                        return;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                txContraseña.mostrarMensaje("La contraseña es incorrecta");
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                pnlPassword.Hide();
                txContraseña.Limpiar();
                txUsuario.Limpiar();
                pnlUser.Show();
            }
        }

        private void toolStripMenuItemPro1_Click(object sender, EventArgs e)
        {
            if (new InputPro("Número de documento", ValidatingType.uInt, 5, 20).ShowInput() != "")
            {

            }
        }
        private void toolStripMenuItemPro1_Click_1(object sender, EventArgs e)
        {
            Settings.Default.usuario = "";
            Settings.Default.Save();
            AccionesSistema.ShowToast("El sistema no volverá a recordarte", this);
        }

        private void pbLock_Click(object sender, EventArgs e)
        {
                Descativar(true);
        }
    }
    #endregion
}
#endregion
