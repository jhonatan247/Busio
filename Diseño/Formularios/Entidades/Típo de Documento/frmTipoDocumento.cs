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
    public partial class frmTipoDocumento : MetroForm
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
            crtlTipoDocumento1.Restablecer();
        }
    }
}
