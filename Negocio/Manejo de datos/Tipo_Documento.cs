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
    public class Tipo_Documento
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Prefijo { get; set; }
        public string Aplicacion { get; set; }
        
        #endregion

        #region Constructores
        public Tipo_Documento()
        {
            
        }
        public Tipo_Documento(long pId, string pNombre, string pPrefijo, string pAplicacion)
        {
            Id = pId;
            Nombre = pNombre;
            Prefijo = pPrefijo;
            Aplicacion = pAplicacion;
        }
        public Tipo_Documento(string pNombre, string pPrefijo, string pAplicacion)
        {
            Nombre = pNombre;
            Prefijo = pPrefijo;
            Aplicacion = pAplicacion;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Tipo_Documento";

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 30;
            Comando.Parameters.Add(Nombre);

            SqlParameter Prefijo = new SqlParameter();
            Prefijo.ParameterName = "@Prefijo";
            Prefijo.Value = this.Prefijo;
            Prefijo.Direction = ParameterDirection.Input;
            Prefijo.SqlDbType = SqlDbType.VarChar;
            Prefijo.Size = 5;
            Comando.Parameters.Add(Prefijo);

            SqlParameter Aplicacion = new SqlParameter();
            Aplicacion.ParameterName = "@Aplicacion";
            Aplicacion.Value = this.Aplicacion;
            Aplicacion.Direction = ParameterDirection.Input;
            Aplicacion.SqlDbType = SqlDbType.VarChar;
            Aplicacion.Size = 50;
            Comando.Parameters.Add(Aplicacion);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Tipo_Documento";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 30;
            Comando.Parameters.Add(Nombre);

            SqlParameter Prefijo = new SqlParameter();
            Prefijo.ParameterName = "@Prefijo";
            Prefijo.Value = this.Prefijo;
            Prefijo.Direction = ParameterDirection.Input;
            Prefijo.SqlDbType = SqlDbType.VarChar;
            Prefijo.Size = 5;
            Comando.Parameters.Add(Prefijo);

            SqlParameter Aplicacion = new SqlParameter();
            Aplicacion.ParameterName = "@Aplicacion";
            Aplicacion.Value = this.Aplicacion;
            Aplicacion.Direction = ParameterDirection.Input;
            Aplicacion.SqlDbType = SqlDbType.VarChar;
            Aplicacion.Size = 50;
            Comando.Parameters.Add(Aplicacion);
            
            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Tipo_Documento";

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
            retorno.Add(Select(1)[1].ToString());

            Comando = new SqlCommand();
            Comando.CommandText = "SelectAll_Nombre_Tipo_Documento";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);
            
            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public List<string> SelectAllEmpresa()
        {
            List<string> retorno = new List<string>();
            retorno.Add(Select(1)[1].ToString());

            Comando = new SqlCommand();
            Comando.CommandText = "SelectAll_Nombre_Tipo_Documento_Empresa";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);

            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public List<string> SelectAllPersona()
        {
            List<string> retorno = new List<string>();
            retorno.Add(Select(1)[1].ToString());

            Comando = new SqlCommand();
            Comando.CommandText = "SelectAll_Nombre_Tipo_Documento_Persona";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);

            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Nombre_Tipo_Documento";

            SqlParameter Campo = new SqlParameter();
            Campo.ParameterName = "@Nombre";
            Campo.Value = txt;
            Campo.Direction = ParameterDirection.Input;
            Campo.SqlDbType = SqlDbType.VarChar;
            Campo.Size = 30;
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
        public DataTable Like(string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Tipo_Documento";

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
            Comando.CommandText = "Delete_Tipo_Documento";

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
