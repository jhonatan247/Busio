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
    public class Caja
    {
        
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        
        #endregion

        #region Constructores
        public Caja()
        {
        }
        public Caja(long pId, long pId_Sucursal, string pNombre,
            string pDescripcion, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Sucursal = pId_Sucursal;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Caja(long pId, long pId_Sucursal, string pNombre,
            string pDescripcion, bool pEstado)
        {
            Id = pId;
            Id_Sucursal = pId_Sucursal;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Estado = pEstado;
        }
        public Caja(long pId_Sucursal, string pNombre,
            string pDescripcion)
        {
            Id_Sucursal = pId_Sucursal;
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }
        public Caja(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Caja";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 30;
            Comando.Parameters.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Caja";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 30;
            Comando.Parameters.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

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
            Comando.CommandText = "Update_Estado_Caja";

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
            Comando.CommandText = "Select_Caja";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataRow SelectVista(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Vista_Caja";

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
            Comando.CommandText = "Delete_Caja";

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
