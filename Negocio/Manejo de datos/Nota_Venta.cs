#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Negocio.Lógica;
#endregion

#region Manejo de datos
namespace Negocio.Manejo_de_datos
{
    #region Class
    public class Nota_Venta
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Venta { get; set; }
        public string Nota { get; set; }
      
        #endregion

        #region Constructores
        public Nota_Venta()
        {
        }
        public Nota_Venta(long pid, long pid_usuario, string pprimer_nombre, string psegundo_nombre, string pprimer_apellido, string psegundo_apellido,
            string ptipo_documento, string pnumero_documento, string ptelefono, string pmovil,
             DateTime pfecha_nacimiento)
        {/*
            id = pid;
            id_usuario = pid_usuario;
            primer_nombre = pprimer_nombre;
            segundo_nombre = psegundo_nombre;
            primer_apellido = pprimer_apellido;
            segundo_apellido = psegundo_apellido;
            tipo_documento = ptipo_documento;
            numero_documento = pnumero_documento;
            telefono = ptelefono;
            movil = pmovil;
            fecha_nacimiento = pfecha_nacimiento;*/
        }
        #endregion

        #region Métodos
        #endregion
    }
    #endregion
}
#endregion
