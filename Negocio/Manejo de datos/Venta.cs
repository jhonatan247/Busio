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
    public class Venta
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Cliente { get; set; }
        public long Id_Historial_Caja { get; set; }
        public string Tipo_Pago { get; set; }
        public bool Pedido { get; set; }
        public bool Entregado { get; set; }
        public bool Devuelto { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
       
        #endregion

        #region Constructores
        public Venta()
        {
        }
        public Venta(long pId, long pId_Cliente, long pId_Historial_Caja, string pTipo_Pago, bool pPedido,
            bool pEntregado, bool pDevuelto, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Cliente = pId_Cliente;
            Id_Historial_Caja = pId_Historial_Caja;
            Tipo_Pago = pTipo_Pago;
            Pedido = pPedido;
            Entregado = pEntregado;
            Devuelto = pDevuelto;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Venta(long pId, long pId_Cliente, long pId_Historial_Caja, string pTipo_Pago, bool pPedido,
            bool pEntregado, bool pDevuelto, bool pEstado)
        {
            Id = pId;
            Id_Cliente = pId_Cliente;
            Id_Historial_Caja = pId_Historial_Caja;
            Tipo_Pago = pTipo_Pago;
            Pedido = pPedido;
            Entregado = pEntregado;
            Devuelto = pDevuelto;
            Estado = pEstado;
        }
        public Venta(long pId_Cliente, long pId_Historial_Caja, string pTipo_Pago, bool pPedido,
            bool pEntregado, bool pDevuelto)
        {
            Id_Cliente = pId_Cliente;
            Id_Historial_Caja = pId_Historial_Caja;
            Tipo_Pago = pTipo_Pago;
            Pedido = pPedido;
            Entregado = pEntregado;
            Devuelto = pDevuelto;
        }
        public Venta(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Venta";

            SqlParameter Id_Cliente = new SqlParameter();
            Id_Cliente.ParameterName = "@Id_Cliente";
            Id_Cliente.Value = this.Id_Cliente;
            Id_Cliente.Direction = ParameterDirection.Input;
            Id_Cliente.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Cliente);

            SqlParameter Id_Historial_Caja = new SqlParameter();
            Id_Historial_Caja.ParameterName = "@Id_Historial_Caja";
            Id_Historial_Caja.Value = this.Id_Historial_Caja;
            Id_Historial_Caja.Direction = ParameterDirection.Input;
            Id_Historial_Caja.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Historial_Caja);

            SqlParameter Tipo_Pago = new SqlParameter();
            Tipo_Pago.ParameterName = "@Tipo_Pago";
            Tipo_Pago.Value = this.Tipo_Pago;
            Tipo_Pago.Direction = ParameterDirection.Input;
            Tipo_Pago.SqlDbType = SqlDbType.VarChar;
            Tipo_Pago.Size = 50;
            Comando.Parameters.Add(Tipo_Pago);

            SqlParameter Pedido = new SqlParameter();
            Pedido.ParameterName = "@Pedido";
            Pedido.Value = this.Pedido;
            Pedido.Direction = ParameterDirection.Input;
            Pedido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Pedido);

            SqlParameter Entregado = new SqlParameter();
            Entregado.ParameterName = "@Entregado";
            Entregado.Value = this.Entregado;
            Entregado.Direction = ParameterDirection.Input;
            Entregado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Entregado);

            SqlParameter Devuelto = new SqlParameter();
            Devuelto.ParameterName = "@Devuelto";
            Devuelto.Value = this.Devuelto;
            Devuelto.Direction = ParameterDirection.Input;
            Devuelto.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Devuelto);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Venta";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Cliente = new SqlParameter();
            Id_Cliente.ParameterName = "@Id_Cliente";
            Id_Cliente.Value = this.Id_Cliente;
            Id_Cliente.Direction = ParameterDirection.Input;
            Id_Cliente.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Cliente);

            SqlParameter Id_Historial_Caja = new SqlParameter();
            Id_Historial_Caja.ParameterName = "@Id_Historial_Caja";
            Id_Historial_Caja.Value = this.Id_Historial_Caja;
            Id_Historial_Caja.Direction = ParameterDirection.Input;
            Id_Historial_Caja.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Historial_Caja);

            SqlParameter Tipo_Pago = new SqlParameter();
            Tipo_Pago.ParameterName = "@Tipo_Pago";
            Tipo_Pago.Value = this.Tipo_Pago;
            Tipo_Pago.Direction = ParameterDirection.Input;
            Tipo_Pago.SqlDbType = SqlDbType.VarChar;
            Tipo_Pago.Size = 50;
            Comando.Parameters.Add(Tipo_Pago);

            SqlParameter Pedido = new SqlParameter();
            Pedido.ParameterName = "@Pedido";
            Pedido.Value = this.Pedido;
            Pedido.Direction = ParameterDirection.Input;
            Pedido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Pedido);

            SqlParameter Entregado = new SqlParameter();
            Entregado.ParameterName = "@Entregado";
            Entregado.Value = this.Entregado;
            Entregado.Direction = ParameterDirection.Input;
            Entregado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Entregado);

            SqlParameter Devuelto = new SqlParameter();
            Devuelto.ParameterName = "@Devuelto";
            Devuelto.Value = this.Devuelto;
            Devuelto.Direction = ParameterDirection.Input;
            Devuelto.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Devuelto);

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
            Comando.CommandText = "Update_Estado_Venta";

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
            Comando.CommandText = "Select_Venta";

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
            Comando.CommandText = "Delete_Venta";

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
