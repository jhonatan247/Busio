﻿#region Librerías
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
    public class Cargo_Trabajador
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Departamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } 
        #endregion

        #region Constructores
        public Cargo_Trabajador()
        {
        }
        public Cargo_Trabajador(long pId, long pId_Departamento, string pNombre, string pDescripcion)
        {
            Id = pId;
            Id_Departamento = pId_Departamento;
            Nombre = pNombre;
            Descripcion = pDescripcion;

        }
        public Cargo_Trabajador(long pId_Departamento, string pNombre, string pDescripcion)
        {
            Id_Departamento = pId_Departamento;
            Nombre = pNombre;
            Descripcion = pDescripcion;

        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Cargo_Trabajador";

            SqlParameter Id_Departamento = new SqlParameter();
            Id_Departamento.ParameterName = "@Id_Departamento";
            Id_Departamento.Value = this.Id_Departamento;
            Id_Departamento.Direction = ParameterDirection.Input;
            Id_Departamento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Departamento);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 40;
            Comando.Parameters.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Campo";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 500;
            Comando.Parameters.Add(Descripcion);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Cargo_Trabajador";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Departamento = new SqlParameter();
            Id_Departamento.ParameterName = "@Id_Departamento";
            Id_Departamento.Value = this.Id_Departamento;
            Id_Departamento.Direction = ParameterDirection.Input;
            Id_Departamento.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Departamento);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = this.Nombre;
            Nombre.Direction = ParameterDirection.Input;
            Nombre.SqlDbType = SqlDbType.VarChar;
            Nombre.Size = 40;
            Comando.Parameters.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Campo";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 500;
            Comando.Parameters.Add(Descripcion);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Cargo_Trabajador";

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
            Comando.CommandText = "SelectAll_Nombre_Cargo_Trabajador";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);
            
            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_Nombre_Cargo_Trabajador";

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
        public long Delete(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Delete_Cargo_Trabajador";

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
