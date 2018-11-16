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
    public class Detalle_Documento_Sucursal
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Sucursal { get; set; }
        public long Id_Tipo_Documento { get; set; }
        public string Ultima_Serie { get; set; }
        public string Ultimo_Numero { get; set; }
        
        #endregion

        #region Constructores
        public Detalle_Documento_Sucursal()
        {
        }
        public Detalle_Documento_Sucursal(long pId, long pId_Sucursal, long pId_Tipo_Documento,
        string pUltima_Serie, string pUlticmo_Numero)
        {
            Id = pId;
            Id_Sucursal = pId_Sucursal;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Ultima_Serie = pUltima_Serie;
            Ultimo_Numero = pUlticmo_Numero;

        }
        public Detalle_Documento_Sucursal(long pId, long pId_Tipo_Documento,
        string pUltima_Serie, string pUlticmo_Numero)
        {
            Id = Id_Sucursal = pId;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Ultima_Serie = pUltima_Serie;
            Ultimo_Numero = pUlticmo_Numero;

        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Detalle_Documento_Sucursal";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id_Tipo_Documento = new SqlParameter();
            Id_Tipo_Documento.ParameterName = "@Id_Tipo_Documento";
            Id_Tipo_Documento.Value = this.Id_Tipo_Documento;
            Id_Tipo_Documento.Direction = ParameterDirection.Input;
            Id_Tipo_Documento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Tipo_Documento);

            SqlParameter Ultima_Serie = new SqlParameter();
            Ultima_Serie.ParameterName = "@Ultima_Serie";
            Ultima_Serie.Value = this.Ultima_Serie;
            Ultima_Serie.Direction = ParameterDirection.Input;
            Ultima_Serie.SqlDbType = SqlDbType.VarChar;
            Ultima_Serie.Size = 7;
            Comando.Parameters.Add(Ultima_Serie);

            SqlParameter Ultimo_Numero = new SqlParameter();
            Ultimo_Numero.ParameterName = "@Ultimo_Numero";
            Ultimo_Numero.Value = this.Ultimo_Numero;
            Ultimo_Numero.Direction = ParameterDirection.Input;
            Ultimo_Numero.SqlDbType = SqlDbType.VarChar;
            Ultimo_Numero.Size = 10;
            Comando.Parameters.Add(Ultimo_Numero);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Detalle_Documento_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Tipo_Documento = new SqlParameter();
            Id_Tipo_Documento.ParameterName = "@Id_Tipo_Documento";
            Id_Tipo_Documento.Value = this.Id_Tipo_Documento;
            Id_Tipo_Documento.Direction = ParameterDirection.Input;
            Id_Tipo_Documento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Tipo_Documento);

            SqlParameter Ultima_Serie = new SqlParameter();
            Ultima_Serie.ParameterName = "@Ultima_Serie";
            Ultima_Serie.Value = this.Ultima_Serie;
            Ultima_Serie.Direction = ParameterDirection.Input;
            Ultima_Serie.SqlDbType = SqlDbType.VarChar;
            Ultima_Serie.Size = 7;
            Comando.Parameters.Add(Ultima_Serie);

            SqlParameter Ultimo_Numero = new SqlParameter();
            Ultimo_Numero.ParameterName = "@Ultimo_Numero";
            Ultimo_Numero.Value = this.Ultimo_Numero;
            Ultimo_Numero.Direction = ParameterDirection.Input;
            Ultimo_Numero.SqlDbType = SqlDbType.VarChar;
            Ultimo_Numero.Size = 10;
            Comando.Parameters.Add(Ultimo_Numero);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Detalle_Documento_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        #endregion
    }
    #endregion
}
#endregion
