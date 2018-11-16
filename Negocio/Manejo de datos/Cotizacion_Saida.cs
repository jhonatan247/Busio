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
    public class Cotizacion_Saida
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Cotizacion_Saida { get; set; }
        public long Id_Cliente { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        
        #endregion

        #region Constructores
        public Cotizacion_Saida()
        {
        }
        public Cotizacion_Saida(long pId_Cotizacion_Saida, long pId_Cliente, DateTime pFecha_Registro, bool pEstado)
        {
            Id_Cotizacion_Saida = pId_Cotizacion_Saida;
            Id_Cliente = pId_Cliente;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
            
        }
        #endregion

        #region Métodos
        
        #endregion
    }
    #endregion
}
#endregion
