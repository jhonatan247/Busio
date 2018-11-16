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
    public class Entrada
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Entrada { get; set; }
        public long Id_Proveedor { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Recibido { get; set; }
        public bool Estado { get; set; }
        
        #endregion

        #region Constructores
        public Entrada()
        {
        }
        public Entrada(long pId_Entrada, long pId_Proveedor, DateTime pFecha_Llegada, DateTime pFecha_Registro,
        bool pRecibido, bool pEstado)
        {
            Id_Entrada = pId_Entrada;
            Id_Proveedor = pId_Proveedor;
            Fecha_Llegada = pFecha_Llegada;
            Fecha_Registro = pFecha_Registro;
            Recibido = pRecibido;
            Estado = pEstado;
            
        }
        #endregion

        #region Métodos
        
        #endregion
    }
    #endregion
}
#endregion
