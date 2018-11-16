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
    public class Historial_Caja
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Caja { get; set; }
        public long Id_Usuario { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public double Dinero_Inicial { get; set; }
        public DateTime Hora_Cierre { get; set; }
        public double Dinero_Cierre { get; set; }
        
        #endregion

        #region Constructores
        public Historial_Caja()
        {
        }
        public Historial_Caja(long pId, long pId_Caja, long pId_Usuario, DateTime pHora_Inicio,
        double pDinero_Inicial, DateTime pHora_Cierre, double pDinero_Cierre)
        {
            Id = pId;
            Id_Caja = pId_Caja;
            Id_Usuario = pId_Usuario;
            Hora_Inicio = pHora_Inicio;
            Dinero_Inicial = pDinero_Inicial;
            Hora_Cierre = pHora_Cierre;
            Dinero_Cierre = pDinero_Cierre;

        }
        public Historial_Caja(long pId_Caja, long pId_Usuario, DateTime pHora_Inicio,
        double pDinero_Inicial, DateTime pHora_Cierre, double pDinero_Cierre)
        {
            Id_Caja = pId_Caja;
            Id_Usuario = pId_Usuario;
            Hora_Inicio = pHora_Inicio;
            Dinero_Inicial = pDinero_Inicial;
            Hora_Cierre = pHora_Cierre;
            Dinero_Cierre = pDinero_Cierre;

        }
        public Historial_Caja(long pId_Caja, long pId_Usuario, DateTime pHora_Inicio,
        double pDinero_Inicial)
        {
            Id_Caja = pId_Caja;
            Id_Usuario = pId_Usuario;
            Hora_Inicio = pHora_Inicio;
            Dinero_Inicial = pDinero_Inicial;

        }
        public Historial_Caja(long pId_Caja, DateTime pHora_Cierre, double pDinero_Cierre)
        {
            Id_Caja = pId_Caja;
            Hora_Cierre = pHora_Cierre;
            Dinero_Cierre = pDinero_Cierre;

        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Historial_Caja";

            SqlParameter Id_Caja = new SqlParameter();
            Id_Caja.ParameterName = "@Id_Caja";
            Id_Caja.Value = this.Id_Caja;
            Id_Caja.Direction = ParameterDirection.Input;
            Id_Caja.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Caja);

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Hora_Inicio = new SqlParameter();
            Hora_Inicio.ParameterName = "@Hora_Inicio";
            Hora_Inicio.Value = this.Hora_Inicio;
            Hora_Inicio.Direction = ParameterDirection.Input;
            Hora_Inicio.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Hora_Inicio);

            SqlParameter Dinero_Inicial = new SqlParameter();
            Dinero_Inicial.ParameterName = "@Dinero_Inicial";
            Dinero_Inicial.Value = this.Dinero_Inicial;
            Dinero_Inicial.Direction = ParameterDirection.Input;
            Dinero_Inicial.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Dinero_Inicial);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Historial_Caja";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Caja = new SqlParameter();
            Id_Caja.ParameterName = "@Id_Caja";
            Id_Caja.Value = this.Id_Caja;
            Id_Caja.Direction = ParameterDirection.Input;
            Id_Caja.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Caja);

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Hora_Inicio = new SqlParameter();
            Hora_Inicio.ParameterName = "@Hora_Inicio";
            Hora_Inicio.Value = this.Hora_Inicio;
            Hora_Inicio.Direction = ParameterDirection.Input;
            Hora_Inicio.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Hora_Inicio);

            SqlParameter Dinero_Inicial = new SqlParameter();
            Dinero_Inicial.ParameterName = "@Dinero_Inicial";
            Dinero_Inicial.Value = this.Dinero_Inicial;
            Dinero_Inicial.Direction = ParameterDirection.Input;
            Dinero_Inicial.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Dinero_Inicial);

            SqlParameter Hora_Cierre = new SqlParameter();
            Hora_Cierre.ParameterName = "@Hora_Cierre";
            Hora_Cierre.Value = this.Hora_Cierre;
            Hora_Cierre.Direction = ParameterDirection.Input;
            Hora_Cierre.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Hora_Cierre);

            SqlParameter Dinero_Cierre = new SqlParameter();
            Dinero_Cierre.ParameterName = "@Dinero_Cierre";
            Dinero_Cierre.Value = this.Dinero_Cierre;
            Dinero_Cierre.Direction = ParameterDirection.Input;
            Dinero_Cierre.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Dinero_Cierre);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long UpdateCierre()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Cierre_Historial_Caja";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Hora_Cierre = new SqlParameter();
            Hora_Cierre.ParameterName = "@Hora_Cierre";
            Hora_Cierre.Value = this.Hora_Cierre;
            Hora_Cierre.Direction = ParameterDirection.Input;
            Hora_Cierre.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Hora_Cierre);

            SqlParameter Dinero_Cierre = new SqlParameter();
            Dinero_Cierre.ParameterName = "@Dinero_Cierre";
            Dinero_Cierre.Value = this.Dinero_Cierre;
            Dinero_Cierre.Direction = ParameterDirection.Input;
            Dinero_Cierre.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Dinero_Cierre);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Historial_Caja";

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
            Comando.CommandText = "Delete_Historial_Caja";

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
