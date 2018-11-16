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
    public class Historial_Contraseña_Usuario
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_Registro { get; set; }
        
        #endregion

        #region Constructores
        public Historial_Contraseña_Usuario()
        {
        }
        public Historial_Contraseña_Usuario(long pId, long pId_Usuario, string pContraseña, DateTime pFecha_Registro)
        {
            Id = pId;
            Id_Usuario = pId_Usuario;
            Contraseña = pContraseña;
            Fecha_Registro = pFecha_Registro;
        }
        public Historial_Contraseña_Usuario(long pId_Usuario, string pContraseña)
        {
            Id_Usuario = pId_Usuario;
            Contraseña = pContraseña;
        }
        public Historial_Contraseña_Usuario(string pContraseña)
        {
            Contraseña = pContraseña;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Historial_Contraseña_Usuario";

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Contraseña = new SqlParameter();
            Contraseña.ParameterName = "@Contraseña";
            Contraseña.Value = this.Contraseña;
            Contraseña.Direction = ParameterDirection.Input;
            Contraseña.SqlDbType = SqlDbType.NVarChar;
            Contraseña.Size = 20;
            Comando.Parameters.Add(Contraseña);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long AutentificarContraseñaPasada()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Autentificar_Contraseña_Pasada";

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Contraseña = new SqlParameter();
            Contraseña.ParameterName = "@Contraseña";
            Contraseña.Value = this.Contraseña;
            Contraseña.Direction = ParameterDirection.Input;
            Contraseña.SqlDbType = SqlDbType.NVarChar;
            Contraseña.Size = 20;
            Comando.Parameters.Add(Contraseña);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Historial_Contraseña_Usuario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataRow SelectContraseña(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Contraseña_Historial_Contraseña_Usuario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id_Usuario";
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
