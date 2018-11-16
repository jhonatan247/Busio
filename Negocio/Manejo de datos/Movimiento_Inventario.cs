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
    public class Movimiento_Inventario
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Inventario { get; set; }
        public double Cantidad { get; set; }
        public DateTime Fecha_Registro { get; set; }
        
        #endregion

        #region Constructores
        public Movimiento_Inventario()
        {
        }
        public Movimiento_Inventario(long pId, long pId_Inventario, double pCantidad, DateTime pFecha_Registro)
        {
            Id = pId;
            Id_Inventario = pId_Inventario;
            Cantidad = pCantidad;
            Fecha_Registro = pFecha_Registro;
        }
        public Movimiento_Inventario(long pId, long pId_Inventario, double pCantidad)
        {
            Id = pId;
            Id_Inventario = pId_Inventario;
            Cantidad = pCantidad;
        }
        public Movimiento_Inventario(long pId_Inventario, double pCantidad)
        {
            Id_Inventario = pId_Inventario;
            Cantidad = pCantidad;
        }
        public Movimiento_Inventario( double pCantidad)
        {
            Cantidad = pCantidad;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Movimiento_Inventario";

            SqlParameter Id_Inventario = new SqlParameter();
            Id_Inventario.ParameterName = "@Id_Inventario";
            Id_Inventario.Value = this.Id_Inventario;
            Id_Inventario.Direction = ParameterDirection.Input;
            Id_Inventario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Inventario);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = this.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Movimiento_Inventario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Inventario = new SqlParameter();
            Id_Inventario.ParameterName = "@Id_Inventario";
            Id_Inventario.Value = this.Id_Inventario;
            Id_Inventario.Direction = ParameterDirection.Input;
            Id_Inventario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Inventario);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = this.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Delete(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Delete_Movimiento_Inventario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
