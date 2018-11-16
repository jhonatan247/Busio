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
    public class Categoria
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        
        #endregion

        #region Constructores
        public Categoria()
        {
        }
        public Categoria(long pId, string pNombre, string pDescripcion, bool pEstado)
        {
            Id = pId;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Estado = pEstado;
            
        }
        public Categoria(string pNombre, string pDescripcion)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;

        }
        public Categoria(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;

        }
        public Categoria(bool pEstado)
        {
            Estado = pEstado;

        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Categoria";

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
            Descripcion.Size =200;
            Comando.Parameters.Add(Descripcion);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Categoria";

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
            Comando.CommandText = "Update_Estado_Categoria";

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
            Comando.CommandText = "UpdateAll_Estado_Categoria";

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
            Comando.CommandText = "Select_Categoria";

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
            Comando.CommandText = "SelectAll_Nombre_Categoria";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);

            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Nombre_Categoria";

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = txt;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 30;
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
            Comando.CommandText = "Like_Categoria";

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
            Comando.CommandText = "Like_Categoria_Of";

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
            Comando.CommandText = "Delete_Categoria";

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
            Comando.CommandText = "DeleteAll_Of_Categoria";

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
