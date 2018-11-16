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
    public class Usuario
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Trabajador { get; set; }
        public string Nickname { get; set; }
        public bool Super_Usuario { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        
        #endregion

        #region Constructores
        public Usuario()
        {
        }
        public Usuario(long pId, long pId_Trabajador, string pNickname, bool pSuper_Usuario , DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Trabajador = pId_Trabajador;
            Nickname = pNickname;
            Super_Usuario = pSuper_Usuario;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Usuario(long pId, long pId_Trabajador, string pNickname, bool pSuper_Usuario, bool pEstado)
        {
            Id = pId;
            Id_Trabajador = pId_Trabajador;
            Nickname = pNickname;
            Super_Usuario = pSuper_Usuario;
            Estado = pEstado;
        }
        public Usuario(long pId_Trabajador, string pNickname, bool pSuper_Usuario)
        {
            Id_Trabajador = pId_Trabajador;
            Nickname = pNickname;
            Super_Usuario = pSuper_Usuario;
        }
        public Usuario(string pNickname)
        {
            Nickname = pNickname;
        }
        public Usuario(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Usuario";

            SqlParameter Id_Trabajador = new SqlParameter();
            Id_Trabajador.ParameterName = "@Id_Trabajador";
            Id_Trabajador.Value = this.Id_Trabajador;
            Id_Trabajador.Direction = ParameterDirection.Input;
            Id_Trabajador.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Trabajador);

            SqlParameter Nickname = new SqlParameter();
            Nickname.ParameterName = "@Nickname";
            Nickname.Value = this.Nickname;
            Nickname.Direction = ParameterDirection.Input;
            Nickname.SqlDbType = SqlDbType.VarChar;
            Nickname.Size = 20;
            Comando.Parameters.Add(Nickname);

            SqlParameter Super_Usuario = new SqlParameter();
            Super_Usuario.ParameterName = "@Super_Usuario";
            Super_Usuario.Value = this.Super_Usuario;
            Super_Usuario.Direction = ParameterDirection.Input;
            Super_Usuario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Super_Usuario);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long InsertCompleto(Historial_Contraseña_Usuario hcu)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Usuario_Completo";

            SqlParameter Id_Trabajador = new SqlParameter();
            Id_Trabajador.ParameterName = "@Id_Trabajador";
            Id_Trabajador.Value = this.Id_Trabajador;
            Id_Trabajador.Direction = ParameterDirection.Input;
            Id_Trabajador.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Trabajador);

            SqlParameter Nickname = new SqlParameter();
            Nickname.ParameterName = "@Nickname";
            Nickname.Value = this.Nickname;
            Nickname.Direction = ParameterDirection.Input;
            Nickname.SqlDbType = SqlDbType.VarChar;
            Nickname.Size = 20;
            Comando.Parameters.Add(Nickname);

            SqlParameter Super_Usuario = new SqlParameter();
            Super_Usuario.ParameterName = "@Super_Usuario";
            Super_Usuario.Value = this.Super_Usuario;
            Super_Usuario.Direction = ParameterDirection.Input;
            Super_Usuario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Super_Usuario);

            SqlParameter Contraseña = new SqlParameter();
            Contraseña.ParameterName = "@Contraseña";
            Contraseña.Value = hcu.Contraseña;
            Contraseña.Direction = ParameterDirection.Input;
            Contraseña.SqlDbType = SqlDbType.NVarChar;
            Contraseña.Size = 20;
            Comando.Parameters.Add(Contraseña);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Usuario";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Trabajador = new SqlParameter();
            Id_Trabajador.ParameterName = "@Id_Trabajador";
            Id_Trabajador.Value = this.Id_Trabajador;
            Id_Trabajador.Direction = ParameterDirection.Input;
            Id_Trabajador.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Trabajador);

            SqlParameter Nickname = new SqlParameter();
            Nickname.ParameterName = "@Nickname";
            Nickname.Value = this.Nickname;
            Nickname.Direction = ParameterDirection.Input;
            Nickname.SqlDbType = SqlDbType.VarChar;
            Nickname.Size = 20;
            Comando.Parameters.Add(Nickname);

            SqlParameter Super_Usuario = new SqlParameter();
            Super_Usuario.ParameterName = "@Super_Usuario";
            Super_Usuario.Value = this.Super_Usuario;
            Super_Usuario.Direction = ParameterDirection.Input;
            Super_Usuario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Super_Usuario);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long UpdateCompleto(Historial_Contraseña_Usuario hcu)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Usuario_Completo";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Trabajador = new SqlParameter();
            Id_Trabajador.ParameterName = "@Id_Trabajador";
            Id_Trabajador.Value = this.Id_Trabajador;
            Id_Trabajador.Direction = ParameterDirection.Input;
            Id_Trabajador.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Trabajador);

            SqlParameter Nickname = new SqlParameter();
            Nickname.ParameterName = "@Nickname";
            Nickname.Value = this.Nickname;
            Nickname.Direction = ParameterDirection.Input;
            Nickname.SqlDbType = SqlDbType.VarChar;
            Nickname.Size = 20;
            Comando.Parameters.Add(Nickname);

            SqlParameter Super_Usuario = new SqlParameter();
            Super_Usuario.ParameterName = "@Super_Usuario";
            Super_Usuario.Value = this.Super_Usuario;
            Super_Usuario.Direction = ParameterDirection.Input;
            Super_Usuario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Super_Usuario);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            SqlParameter Contraseña = new SqlParameter();
            Contraseña.ParameterName = "@Contraseña";
            Contraseña.Value = hcu.Contraseña;
            Contraseña.Direction = ParameterDirection.Input;
            Contraseña.SqlDbType = SqlDbType.NVarChar;
            Contraseña.Size = 20;
            Comando.Parameters.Add(Contraseña);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Estado_Usuario";

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
        public DataRow AutentificarUsuario()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Autentificar_Usuario";

            SqlParameter Nickname = new SqlParameter();
            Nickname.ParameterName = "@Nickname";
            Nickname.Value = this.Nickname;
            Nickname.Direction = ParameterDirection.Input;
            Nickname.SqlDbType = SqlDbType.VarChar;
            Nickname.Size = 50;
            Comando.Parameters.Add(Nickname);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Usuario";

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
            Comando.CommandText = "Delete_Usuario";

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
