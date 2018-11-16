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
    public class Empresa_Distribuidora  
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Tipo_Documento { get; set; }
        public string Nombre { get; set; }
        public string Numero_Documento { get; set; }
        public Image Logo { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Empresa_Distribuidora()
        {

        }
        public Empresa_Distribuidora(long pId, long pId_Tipo_Documento, string pNombre,
        string pNumero_Documento, Image pLogo, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombre = pNombre;
            Numero_Documento = pNumero_Documento;
            Logo = pLogo;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Empresa_Distribuidora(long pId, long pId_Tipo_Documento, string pNombre,
        string pNumero_Documento, Image pLogo, bool pEstado)
        {
            Id = pId;
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombre = pNombre;
            Numero_Documento = pNumero_Documento;
            Logo = pLogo;
            Estado = pEstado;
        }
        public Empresa_Distribuidora(long pId_Tipo_Documento, string pNombre,
        string pNumero_Documento, Image pLogo)
        {
            Id_Tipo_Documento = pId_Tipo_Documento;
            Nombre = pNombre;
            Numero_Documento = pNumero_Documento;
            Logo = pLogo;

        }
        public Empresa_Distribuidora(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Empresa_Distribuidora";

            SqlParameter Id_Tipo_Documento = new SqlParameter();
            Id_Tipo_Documento.ParameterName = "@Id_Tipo_Documento";
            Id_Tipo_Documento.Value = this.Id_Tipo_Documento;
            Id_Tipo_Documento.Direction = ParameterDirection.Input;
            Id_Tipo_Documento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Tipo_Documento);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 40;
            Comando.Parameters.Add(Nombre);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

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
            Comando.CommandText = "Update_Empresa_Distribuidora";

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

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 40;
            Comando.Parameters.Add(Nombre);

            SqlParameter Numero_Documento = new SqlParameter();
            Numero_Documento.ParameterName = "@Numero_Documento";
            Numero_Documento.Value = this.Numero_Documento;
            Numero_Documento.Direction = ParameterDirection.Input;
            Numero_Documento.SqlDbType = SqlDbType.VarChar;
            Numero_Documento.Size = 20;
            Comando.Parameters.Add(Numero_Documento);

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
            Comando.CommandText = "Update_Estado_Empresa_Distribuidora";

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
        public long UpdateAll_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UpdateAll_Estado_Empresa_Distribuidora";

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
            Comando.CommandText = "Select_Empresa_Distribuidora";

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
            List<string> retorno = new List<string>();
            retorno.Add(Select(1)[2].ToString());

            Comando = new SqlCommand();
            Comando.CommandText = "SelectAll_Nombre_Empresa_Distribuidora";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);
            
            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Nombre_Empresa_Distribuidora";

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = txt;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 40;
            Comando.Parameters.Add(Nombre);

            try
            {
                return Convert.ToInt64(ED.ProcedureExecuteReader(Comando).Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }
        public DataTable Like(string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Empresa_Distribuidora";

            SqlParameter txt = new SqlParameter();
            txt.ParameterName = "@txt";
            txt.Value = pTxt;
            txt.Direction = ParameterDirection.Input;
            txt.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(txt);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LikeOf(string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Empresa_Distribuidora_Of";

            SqlParameter txt = new SqlParameter();
            txt.ParameterName = "@txt";
            txt.Value = pTxt;
            txt.Direction = ParameterDirection.Input;
            txt.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(txt);

            return ED.ProcedureExecuteReader(Comando);
        }
        public long Delete(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Delete_Empresa_Distribuidora";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long DeleteAll()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "DeleteAll_Of_Empresa_Distribuidora";

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
