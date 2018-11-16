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
    public class Detalle_Venta
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Venta { get; set; }
        public long Id_Producto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Porcentaje_Impuesto { get; set; }
        public bool Impuesto_Incluido { get; set; }
        public bool Estado { get; set; }

        #endregion

        #region Constructores
        public Detalle_Venta()
        {
        }
        public Detalle_Venta(long pId, long pId_Venta, long pId_Producto, double pCantidad, double pPrecio, double pPorcentaje_Impuesto,
            bool pImpuesto_Incluido, bool pEstado)
        {
            Id = pId;
            Id_Venta = pId_Venta;
            Id_Producto = pId_Producto;
            Cantidad = pCantidad;
            Precio = pPrecio;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Impuesto_Incluido = pImpuesto_Incluido;
            Estado = pEstado;
        }
        public Detalle_Venta(long pId_Venta, long pId_Producto, double pCantidad, double pPrecio, double pPorcentaje_Impuesto,
            bool pImpuesto_Incluido)
        {
            Id_Venta = pId_Venta;
            Id_Producto = pId_Producto;
            Cantidad = pCantidad;
            Precio = pPrecio;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Impuesto_Incluido = pImpuesto_Incluido;
        }
        public Detalle_Venta(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Detalle_Venta";

            SqlParameter Id_Venta = new SqlParameter();
            Id_Venta.ParameterName = "@Id_Venta";
            Id_Venta.Value = this.Id_Venta;
            Id_Venta.Direction = ParameterDirection.Input;
            Id_Venta.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Venta);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = this.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(Cantidad);

            SqlParameter Precio = new SqlParameter();
            Precio.ParameterName = "@Precio";
            Precio.Value = this.Precio;
            Precio.Direction = ParameterDirection.Input;
            Precio.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Detalle_Venta";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Venta = new SqlParameter();
            Id_Venta.ParameterName = "@Id_Venta";
            Id_Venta.Value = this.Id_Venta;
            Id_Venta.Direction = ParameterDirection.Input;
            Id_Venta.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Venta);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = this.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(Cantidad);

            SqlParameter Precio = new SqlParameter();
            Precio.ParameterName = "@Precio";
            Precio.Value = this.Precio;
            Precio.Direction = ParameterDirection.Input;
            Precio.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Estado_Detalle_Venta";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Detalle_Venta";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public long Delete(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Delete_Detalle_Venta";

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
