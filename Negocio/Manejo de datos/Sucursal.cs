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
    public class Sucursal
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public string Razon_Social { get; set; }
        public string Numero_Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono_Movil { get; set; }
        public string Correo { get; set; }
        public string Direccion_Web { get; set; }
        public string Representante { get; set; }
        public Image Logo { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Sucursal()
        {
        }
        public Sucursal(long pId,  string pRazon_Social, string pNumero_Documento, string pDireccion, string pTelefono_Movil,
            string pCorreo, string pDireccion_Web, string pRepresentante, Image pLogo, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Razon_Social = pRazon_Social;
            Numero_Documento = pNumero_Documento;
            Direccion = pDireccion;
            Telefono_Movil = pTelefono_Movil;
            Correo = pCorreo;
            Direccion_Web = pDireccion_Web;
            Representante = pRepresentante;
            Logo = pLogo;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Sucursal(long pId, string pRazon_Social, string pNumero_Documento, string pDireccion, string pTelefono_Movil,
            string pCorreo, string pDireccion_Web, string pRepresentante, Image pLogo, bool pEstado)
        {
            Id = pId;
            Razon_Social = pRazon_Social;
            Numero_Documento = pNumero_Documento;
            Direccion = pDireccion;
            Telefono_Movil = pTelefono_Movil;
            Correo = pCorreo;
            Direccion_Web = pDireccion_Web;
            Representante = pRepresentante;
            Logo = pLogo;
            Estado = pEstado;
        }
        public Sucursal(string pRazon_Social, string pNumero_Documento, string pDireccion, string pTelefono_Movil,
            string pCorreo, string pDireccion_Web, string pRepresentante, Image pLogo)
        {
            Razon_Social = pRazon_Social;
            Numero_Documento = pNumero_Documento;
            Direccion = pDireccion;
            Telefono_Movil = pTelefono_Movil;
            Correo = pCorreo;
            Direccion_Web = pDireccion_Web;
            Representante = pRepresentante;
            Logo = pLogo;
        }
        public Sucursal(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Sucursal";

            SqlParameter Razon_Social = new SqlParameter();
            Razon_Social.ParameterName = "@Razon_Social";
            Razon_Social.Value = this.Razon_Social;
            Razon_Social.Direction = ParameterDirection.Input;
            Razon_Social.SqlDbType = SqlDbType.VarChar;
            Razon_Social.Size = 40;
            Comando.Parameters.Add(Razon_Social);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

            SqlParameter Direccion = new SqlParameter();
            Direccion.ParameterName = "@Direccion";
            Direccion.Value = this.Direccion;
            Direccion.Direction = ParameterDirection.Input;
            Direccion.SqlDbType = SqlDbType.VarChar;
            Direccion.Size = 50;
            Comando.Parameters.Add(Direccion);

            SqlParameter Telefono_Movil = new SqlParameter();
            Telefono_Movil.ParameterName = "@Telefono_Movil";
            Telefono_Movil.Value = this.Telefono_Movil;
            Telefono_Movil.Direction = ParameterDirection.Input;
            Telefono_Movil.SqlDbType = SqlDbType.VarChar;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

            SqlParameter Correo = new SqlParameter();
            Correo.ParameterName = "@Correo";
            Correo.Value = this.Correo;
            Correo.Direction = ParameterDirection.Input;
            Correo.SqlDbType = SqlDbType.VarChar;
            Correo.Size = 50;
            Comando.Parameters.Add(Correo);

            SqlParameter Direccion_Web = new SqlParameter();
            Direccion_Web.ParameterName = "@Direccion_Web";
            Direccion_Web.Value = this.Direccion_Web;
            Direccion_Web.Direction = ParameterDirection.Input;
            Direccion_Web.SqlDbType = SqlDbType.VarChar;
            Direccion_Web.Size = 100;
            Comando.Parameters.Add(Direccion_Web);

            SqlParameter Representante = new SqlParameter();
            Representante.ParameterName = "@Representante";
            Representante.Value = this.Representante;
            Representante.Direction = ParameterDirection.Input;
            Representante.SqlDbType = SqlDbType.VarChar;
            Representante.Size = 120;
            Comando.Parameters.Add(Representante);

            SqlParameter Logo = new SqlParameter();
            Logo.ParameterName = "@Logo";
            if (this.Logo == null)
            {
                Logo.Value = DBNull.Value;
            }
            else
                Logo.Value = AccionesSistema.ConvertirImagen(this.Logo);
            Logo.Direction = ParameterDirection.Input;
            Logo.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Logo);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Razon_Social = new SqlParameter();
            Razon_Social.ParameterName = "@Razon_Social";
            Razon_Social.Value = this.Razon_Social;
            Razon_Social.Direction = ParameterDirection.Input;
            Razon_Social.SqlDbType = SqlDbType.VarChar;
            Razon_Social.Size = 40;
            Comando.Parameters.Add(Razon_Social);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

            SqlParameter Direccion = new SqlParameter();
            Direccion.ParameterName = "@Direccion";
            Direccion.Value = this.Direccion;
            Direccion.Direction = ParameterDirection.Input;
            Direccion.SqlDbType = SqlDbType.VarChar;
            Direccion.Size = 50;
            Comando.Parameters.Add(Direccion);

            SqlParameter Telefono_Movil = new SqlParameter();
            Telefono_Movil.ParameterName = "@Telefono_Movil";
            Telefono_Movil.Value = this.Telefono_Movil;
            Telefono_Movil.Direction = ParameterDirection.Input;
            Telefono_Movil.SqlDbType = SqlDbType.VarChar;
            Telefono_Movil.Size = 10;
            Comando.Parameters.Add(Telefono_Movil);

            SqlParameter Correo = new SqlParameter();
            Correo.ParameterName = "@Correo";
            Correo.Value = this.Correo;
            Correo.Direction = ParameterDirection.Input;
            Correo.SqlDbType = SqlDbType.VarChar;
            Correo.Size = 50;
            Comando.Parameters.Add(Correo);

            SqlParameter Direccion_Web = new SqlParameter();
            Direccion_Web.ParameterName = "@Direccion_Web";
            Direccion_Web.Value = this.Direccion_Web;
            Direccion_Web.Direction = ParameterDirection.Input;
            Direccion_Web.SqlDbType = SqlDbType.VarChar;
            Direccion_Web.Size = 100;
            Comando.Parameters.Add(Direccion_Web);

            SqlParameter Representante = new SqlParameter();
            Representante.ParameterName = "@Representante";
            Representante.Value = this.Representante;
            Representante.Direction = ParameterDirection.Input;
            Representante.SqlDbType = SqlDbType.VarChar;
            Representante.Size = 120;
            Comando.Parameters.Add(Representante);

            SqlParameter Logo = new SqlParameter();
            Logo.ParameterName = "@Logo";
            if (this.Logo == null)
            {
                Logo.Value = DBNull.Value;
            }
            else
                Logo.Value = AccionesSistema.ConvertirImagen(this.Logo);
            Logo.Direction = ParameterDirection.Input;
            Logo.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Logo);

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
            Comando.CommandText = "Update_Estado_Sucursal";

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
            Comando.CommandText = "Select_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public List<string> SelectAll()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectAll_Razon_Social_Sucursal";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);

            List<string> retorno = new List<string>();
            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Razon_Social_Sucursal";

            SqlParameter Campo = new SqlParameter();
            Campo.ParameterName = "@Razon_Social";
            Campo.Value = txt;
            Campo.Direction = ParameterDirection.Input;
            Campo.SqlDbType = SqlDbType.VarChar;
            Campo.Size = 40;
            Comando.Parameters.Add(Campo);

            try
            {
                return Convert.ToInt64(ED.ProcedureExecuteReader(Comando).Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }
        public long Delete(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Delete_Sucursal";

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
