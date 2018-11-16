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
    public class Proveedor
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Empresa_Distribuidora { get; set; }
        public long Id_Tipo_Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Numero_Documento { get; set; }
        public string Correo_Electronico { get; set; }
        public string Telefono_Movil { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Proveedor()
        {
        }
        public Proveedor(long pId, long pId_Empresa_Distribuidora, long pId_Tipo_Documento, string pNombres, string pApellidos,
            string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil,
            DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Proveedor(long pId, long pId_Empresa_Distribuidora, long pId_Tipo_Documento, string pNombres, string pApellidos,
            string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil,
            bool pEstado)
        {
            Id = pId;
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
            Estado = pEstado;
        }
        public Proveedor(long pId_Empresa_Distribuidora, long pId_Tipo_Documento, string pNombres, string pApellidos,
            string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil)
        {
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
        }
        public Proveedor(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Proveedor";

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Tipo_Documento = new SqlParameter();
            Id_Tipo_Documento.ParameterName = "@Id_Tipo_Documento";
            Id_Tipo_Documento.Value = this.Id_Tipo_Documento;
            Id_Tipo_Documento.Direction = ParameterDirection.Input;
            Id_Tipo_Documento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Tipo_Documento);

            SqlParameter Nombres = new SqlParameter();
            Nombres.ParameterName = "@Nombres";
            Nombres.Value = this.Nombres;
            Nombres.Direction = ParameterDirection.Input;
            Nombres.SqlDbType = SqlDbType.BigInt;
            Nombres.Size = 40;
            Comando.Parameters.Add(Nombres);

            SqlParameter Apellidos = new SqlParameter();
            Apellidos.ParameterName = "@Apellidos";
            Apellidos.Value = this.Apellidos;
            Apellidos.Direction = ParameterDirection.Input;
            Apellidos.SqlDbType = SqlDbType.VarChar;
            Apellidos.Size = 40;
            Comando.Parameters.Add(Apellidos);

            SqlParameter Sexo = new SqlParameter();
            Sexo.ParameterName = "@Sexo";
            Sexo.Value = this.Sexo;
            Sexo.Direction = ParameterDirection.Input;
            Sexo.SqlDbType = SqlDbType.VarChar;
            Sexo.Size = 20;
            Comando.Parameters.Add(Sexo);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

            SqlParameter Correo_Electronico = new SqlParameter();
            Correo_Electronico.ParameterName = "@Correo_Electronico";
            Correo_Electronico.Value = this.Correo_Electronico;
            Correo_Electronico.Direction = ParameterDirection.Input;
            Correo_Electronico.SqlDbType = SqlDbType.VarChar;
            Correo_Electronico.Size = 50;
            Comando.Parameters.Add(Correo_Electronico);

            SqlParameter Telefono_Movil = new SqlParameter();
            Telefono_Movil.ParameterName = "@Telefono_Movil";
            Telefono_Movil.Value = this.Telefono_Movil;
            Telefono_Movil.Direction = ParameterDirection.Input;
            Telefono_Movil.SqlDbType = SqlDbType.VarChar;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Proveedor";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Tipo_Documento = new SqlParameter();
            Id_Tipo_Documento.ParameterName = "@Id_Tipo_Documento";
            Id_Tipo_Documento.Value = this.Id_Tipo_Documento;
            Id_Tipo_Documento.Direction = ParameterDirection.Input;
            Id_Tipo_Documento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Tipo_Documento);

            SqlParameter Nombres = new SqlParameter();
            Nombres.ParameterName = "@Nombres";
            Nombres.Value = this.Nombres;
            Nombres.Direction = ParameterDirection.Input;
            Nombres.SqlDbType = SqlDbType.BigInt;
            Nombres.Size = 40;
            Comando.Parameters.Add(Nombres);

            SqlParameter Apellidos = new SqlParameter();
            Apellidos.ParameterName = "@Apellidos";
            Apellidos.Value = this.Apellidos;
            Apellidos.Direction = ParameterDirection.Input;
            Apellidos.SqlDbType = SqlDbType.VarChar;
            Apellidos.Size = 40;
            Comando.Parameters.Add(Apellidos);

            SqlParameter Sexo = new SqlParameter();
            Sexo.ParameterName = "@Sexo";
            Sexo.Value = this.Sexo;
            Sexo.Direction = ParameterDirection.Input;
            Sexo.SqlDbType = SqlDbType.VarChar;
            Sexo.Size = 20;
            Comando.Parameters.Add(Sexo);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

            SqlParameter Correo_Electronico = new SqlParameter();
            Correo_Electronico.ParameterName = "@Correo_Electronico";
            Correo_Electronico.Value = this.Correo_Electronico;
            Correo_Electronico.Direction = ParameterDirection.Input;
            Correo_Electronico.SqlDbType = SqlDbType.VarChar;
            Correo_Electronico.Size = 50;
            Comando.Parameters.Add(Correo_Electronico);

            SqlParameter Telefono_Movil = new SqlParameter();
            Telefono_Movil.ParameterName = "@Telefono_Movil";
            Telefono_Movil.Value = this.Telefono_Movil;
            Telefono_Movil.Direction = ParameterDirection.Input;
            Telefono_Movil.SqlDbType = SqlDbType.VarChar;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

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
            Comando.CommandText = "Update_Estado_Proveedor";

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
            Comando.CommandText = "Select_Proveedor";

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
            Comando.CommandText = "Delete_Proveedor";

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
