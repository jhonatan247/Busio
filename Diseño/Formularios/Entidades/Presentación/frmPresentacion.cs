﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmPresentacion : MetroForm
    {
        public frmPresentacion()
        {
            InitializeComponent();
            crtlCategoria1.Restablecer();
        }
    }
}
