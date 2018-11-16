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
    public class Cliente
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Tipo_Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Numero_Documento { get; set; }
        public string Correo_Electronico { get; set; }
        public string Telefono_Movil { get; set; }
        public string Direccion { get; set; }
        public double Limite_Credito { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }

        #endregion

        #region Constructores
        public Cliente()
        {
        }
        public Cliente(long pId, long pId_Tipo_Documento, string pNombres,
        string pApellidos, string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil,
        string pDireccion, double pLimite_Credito, DateTime pFecha_Nacimiento, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
            Direccion = pDireccion;
            Limite_Credito = pLimite_Credito;
            Fecha_Nacimiento = pFecha_Nacimiento;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;

        }
        public Cliente(long pId, long pId_Tipo_Documento, string pNombres,
        string pApellidos, string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil,
        string pDireccion, double pLimite_Credito, DateTime pFecha_Nacimiento, bool pEstado)
        {
            Id = pId;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
            Direccion = pDireccion;
            Limite_Credito = pLimite_Credito;
            Fecha_Nacimiento = pFecha_Nacimiento;
            Estado = pEstado;

        }
        public Cliente(long pId_Tipo_Documento, string pNombres,
        string pApellidos, string pSexo, string pNumero_Documento, string pCorreo_Electronico, string pTelefono_Movil,
        string pDireccion, double pLimite_Credito, DateTime pFecha_Nacimiento)
        {
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Sexo = pSexo;
            Numero_Documento = pNumero_Documento;
            Correo_Electronico = pCorreo_Electronico;
            Telefono_Movil = pTelefono_Movil;
            Direccion = pDireccion;
            Limite_Credito = pLimite_Credito;
            Fecha_Nacimiento = pFecha_Nacimiento;

        }
        public Cliente(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;

        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Cliente";

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
            Nombres.SqlDbType = SqlDbType.VarChar;
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
            Telefono_Movil.SqlDbType = SqlDbType.Char;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

            SqlParameter Direccion = new SqlParameter();
            Direccion.ParameterName = "@Direccion";
            Direccion.Value = this.Direccion;
            Direccion.Direction = ParameterDirection.Input;
            Direccion.SqlDbType = SqlDbType.VarChar;
            Direccion.Size = 100;
            Comando.Parameters.Add(Direccion);

            SqlParameter Limite_Credito = new SqlParameter();
            Limite_Credito.ParameterName = "@Limite_Credito";
            Limite_Credito.Value = this.Limite_Credito;
            Limite_Credito.Direction = ParameterDirection.Input;
            Limite_Credito.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Limite_Credito);

            SqlParameter Fecha_Nacimiento = new SqlParameter();
            Fecha_Nacimiento.ParameterName = "@Fecha_Nacimiento";
            Fecha_Nacimiento.Value = this.Fecha_Nacimiento;
            Fecha_Nacimiento.Direction = ParameterDirection.Input;
            Fecha_Nacimiento.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(Fecha_Nacimiento);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Cliente";

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

            SqlParameter Nombres = new SqlParameter();
            Nombres.ParameterName = "@Nombres";
            Nombres.Value = this.Nombres;
            Nombres.Direction = ParameterDirection.Input;
            Nombres.SqlDbType = SqlDbType.VarChar;
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
            Telefono_Movil.SqlDbType = SqlDbType.Char;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

            SqlParameter Direccion = new SqlParameter();
            Direccion.ParameterName = "@Direccion";
            Direccion.Value = this.Direccion;
            Direccion.Direction = ParameterDirection.Input;
            Direccion.SqlDbType = SqlDbType.VarChar;
            Direccion.Size = 100;
            Comando.Parameters.Add(Direccion);

            SqlParameter Limite_Credito = new SqlParameter();
            Limite_Credito.ParameterName = "@Limite_Credito";
            Limite_Credito.Value = this.Limite_Credito;
            Limite_Credito.Direction = ParameterDirection.Input;
            Limite_Credito.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Limite_Credito);

            SqlParameter Fecha_Nacimiento = new SqlParameter();
            Fecha_Nacimiento.ParameterName = "@Fecha_Nacimiento";
            Fecha_Nacimiento.Value = this.Fecha_Nacimiento;
            Fecha_Nacimiento.Direction = ParameterDirection.Input;
            Fecha_Nacimiento.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(Fecha_Nacimiento);

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
            Comando.CommandText = "Update_Estado_Cliente";

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
            Comando.CommandText = "Select_Cliente";

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
            Comando.CommandText = "Delete_Cliente";

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
