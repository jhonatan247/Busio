using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace Presentacion.Controles
{
    public partial class ComboEXValide : ComboBoxEx
    {
        public bool primero = true;
        int index = 0;
        int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value >= 0)
                {
                    index = value;
                    try
                    {
                        if (!primero)
                        {
                            UserGo(this, new EventArgs());
                        }
                        else
                            primero = false;
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        SelectedIndex = index;
                    }
                    catch { }
                }
            }
        }


        #region Delegados
        public delegate void UserGoDelegate(object sender, EventArgs e);
        #endregion
        #region Eventos
        public event UserGoDelegate UserGo;
        #endregion
        public ComboEXValide()
        {
            InitializeComponent();
        }

        private void ComboEXValide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {
                    UserGo(this, new EventArgs());
                }
                catch { }
            e.Handled = true;
        }

        private void ComboEXValide_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboEXValide_TextChanged(object sender, EventArgs e)
        {
            Index = SelectedIndex;
        }

        private void ComboEXValide_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = SelectedIndex;
        }
    }
}
