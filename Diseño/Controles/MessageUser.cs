
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
using DevComponents.DotNetBar;
#endregion

#region Presentacion
namespace Presentacion.Controles
{
    #region TrayBar
    public partial class MessageUser : DevComponents.DotNetBar.Balloon
    {
        #region Atributos
        MessageLocation trayLocation = MessageLocation.Center;
        #endregion

        #region Propiedades
        public MessageLocation TrayLocation {
            get
            {
                return trayLocation;
            }
            set
            {
                trayLocation = value;
                switch (trayLocation)
                {
                    case MessageLocation.Center:
                        CenterToScreen();
                        break;
                    case MessageLocation.BottomRight:
                        Rectangle r = Screen.GetWorkingArea(this);
                        Location = new Point(r.Right - Width, r.Bottom - Height);
                        break;
                }
            }
        }
        public Image TrayImage
        {
            get
            {
                return pbImagen.Image;
            }
            set
            {
                pbImagen.Image = value;
            }
        }
        public string TrayImageDescription
        {
            get
            {
                return lbImageDescription.Text;
            }
            set
            {
                lbImageDescription.Text = value;
            }
        }
        public string TrayMesage
        {
            get
            {
                return lbMensaje.Text;
            }
            set
            {
                lbMensaje.Text = value;
                int x = (lbMensaje.Width < lbMensaje.SizeTag.Width ? (lbMensaje.SizeTag.Width - lbMensaje.Width) / 2 : 0);
                int y = (lbMensaje.Height < lbMensaje.SizeTag.Height ? (lbMensaje.SizeTag.Height - lbMensaje.Height) / 2 : 0);
                lbMensaje.Location = new Point(x,y);
            }
        }
        public string TrayTitle
        {
            get
            {
                return lbTitulo.Text;
            }
            set
            {
                lbTitulo.Text = value;
            }
        }
        #endregion

        #region Constructores
        public MessageUser(string title, string mesage, string description)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            ShowDialog();
        }
        public MessageUser(string title, string mesage, string description, MessageLocation trayLocation)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Show(true);
        }
        public MessageUser(string title, string mesage, string description, MessageBtns buttons)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            ShowDialog();
        }
        public MessageUser(string title, string mesage, string description, MessageLocation trayLocation, MessageBtns buttons)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            Show(true);
        }
        public MessageUser(string title, string mesage, string description, MessageBtns buttons, int timeToClose)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
            ShowDialog();
        }
        public MessageUser(string title, string mesage, string description, MessageLocation trayLocation, MessageBtns buttons, int timeToClose)
        {
            InitializeComponent();

            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
            Show(true);
        }
        public MessageUser(string title, string mesage, string description, 
            MessageBtns buttons, int timeToClose, eAlertAnimation alertAnimation)
        {
            InitializeComponent();

            AlertAnimation = alertAnimation;
            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
                ShowDialog();
        }
        public MessageUser(string title, string mesage, string description, MessageLocation trayLocation, 
            MessageBtns buttons, int timeToClose, eAlertAnimation alertAnimation)
        {
            InitializeComponent();

            AlertAnimation = alertAnimation;
            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
                Show(true);
        }
        public MessageUser(string title, string mesage, string description, MessageBtns buttons, 
            int timeToClose, eAlertAnimation alertAnimation, Image trayImage)
        {
            InitializeComponent();

            AlertAnimation = alertAnimation;
            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            TrayImage = trayImage;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
            ShowDialog();
        }
        public MessageUser(string title, string mesage, string description, MessageLocation trayLocation, 
            MessageBtns buttons, int timeToClose, eAlertAnimation alertAnimation, Image trayImage)
        {
            InitializeComponent();

            AlertAnimation = alertAnimation;
            TrayLocation = trayLocation;
            TrayTitle = title;
            TrayMesage = mesage;
            TrayImageDescription = description;
            TrayImage = trayImage;
            Choosebtns(buttons);
            AutoCloseTimeOut = timeToClose;
        }
        #endregion

        #region Métodos
        void Choosebtns(MessageBtns buttons)
        {
            switch (buttons)
            {
                case MessageBtns.Cancel:
                    pnlButtons.Show();
                    bnCancel.Show();
                    break;
                case MessageBtns.Ok:
                    pnlButtons.Show();
                    bnOk.Show();
                    break;
                case MessageBtns.OKCancel:
                    pnlButtons.Show();
                    bnCancel.Show();
                    bnOk.Show();
                    break;
            }
        }
        void OcultarBtns()
        {
            bnOk.Hide();
            bnCancel.Hide();
            pnlButtons.Hide();
        }
        #endregion

        #region Eventos

        #endregion

        private void bnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
    #endregion
    public enum MessageLocation
    {
        Center,
        BottomRight
    }
    public enum MessageBtns
    {
        None,
        Ok,
        Cancel,
        OKCancel
    }
}
#endregion
