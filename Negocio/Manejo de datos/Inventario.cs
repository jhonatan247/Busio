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
    public class Inventario
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Sucursal { get; set; }
        public long Id_Producto { get; set; }
        public double Cantidad_Minima { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }

        #endregion

        #region Constructores
        public Inventario()
        {
        }
        public Inventario(long pId, long pId_Sucursal, long pId_Producto, double pCantidad_Minima, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Sucursal = pId_Sucursal;
            Id_Producto = pId_Producto;
            Cantidad_Minima = pCantidad_Minima;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Inventario(long pId_Sucursal, long pId_Producto, double pCantidad_Minima)
        {
            Id_Sucursal = pId_Sucursal;
            Id_Producto = pId_Producto;
            Cantidad_Minima = pCantidad_Minima;
        }
        public Inventario(long pId_Sucursal, long pId_Producto, bool pEstado)
        {
            Id_Sucursal = pId_Sucursal;
            Id_Producto = pId_Producto;
            Estado = pEstado;
        }
        public Inventario(long pId, double pCantidad_Minima)
        {
            Id= Id_Sucursal= pId;
            Cantidad_Minima = pCantidad_Minima;
        }
        public Inventario(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        public Inventario(long pId_Sucursal, long pId_Producto)
        {
            Id_Sucursal = pId_Sucursal;
            Id_Producto = pId_Producto;
        }
        public Inventario(double pCantidad_Minima)
        {
            Cantidad_Minima = pCantidad_Minima;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Inventario";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = this.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long InsertCompleto(Movimiento_Inventario pMov)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Inventario_Completo";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = this.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = pMov.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Inventario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = this.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long UpdateCompleto(Movimiento_Inventario pMov)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Inventario_Completo";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = this.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = pMov.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Estado_Producto";

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
        public long UpdateEASY_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UpdateEASY_Estado_Inventario";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long SelectId()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Inventario";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id_Producto = new SqlParameter();
            Id_Producto.ParameterName = "@Id_Producto";
            Id_Producto.Value = this.Id_Producto;
            Id_Producto.Direction = ParameterDirection.Input;
            Id_Producto.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Producto);

            try
            {
                return Convert.ToInt64(ED.ProcedureExecuteReader(Comando).Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion
    }
    #endregion
}
#endregion
