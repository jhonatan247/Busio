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
    public class Info_General
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public string Empresa { get; set; }
        public string Nombre_Impuesto { get; set; }
        public string Nombre_Moneda { get; set; }
        public string Simbolo_Moneda { get; set; }
        public decimal Conversion_Dolar { get; set; }
        public Image Logo { get; set; }
        #endregion

        #region Constructores
        public Info_General()
        {
        }
        public Info_General(long pId, string pEmpresa, string pNombre_Impuesto,
            string pNombre_Moneda, string pSimbolo_Moneda, decimal pConversion_Dolar, Image pLogo)
        {
            Id = pId;
            Empresa = pEmpresa;
            Nombre_Impuesto = pNombre_Impuesto;
            Nombre_Moneda = pNombre_Moneda;
            Simbolo_Moneda = pSimbolo_Moneda;
            Conversion_Dolar = pConversion_Dolar;
            Logo = pLogo;
        }
        public Info_General( string pEmpresa, string pNombre_Impuesto,
            string pNombre_Moneda, string pSimbolo_Moneda, decimal pConversion_Dolar, Image pLogo)
        {
            Empresa = pEmpresa;
            Nombre_Impuesto = pNombre_Impuesto;
            Nombre_Moneda = pNombre_Moneda;
            Simbolo_Moneda = pSimbolo_Moneda;
            Conversion_Dolar = pConversion_Dolar;
            Logo = pLogo;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Info_General";

            SqlParameter Empresa = new SqlParameter();
            Empresa.ParameterName = "@Empresa";
            Empresa.Value = this.Empresa;
            Empresa.Direction = ParameterDirection.Input;
            Empresa.SqlDbType = SqlDbType.VarChar;
            Empresa.Size = 100;
            Comando.Parameters.Add(Empresa);

            SqlParameter Nombre_Impuesto = new SqlParameter();
            Nombre_Impuesto.ParameterName = "@Nombre_Impuesto";
            Nombre_Impuesto.Value = this.Nombre_Impuesto;
            Nombre_Impuesto.Direction = ParameterDirection.Input;
            Nombre_Impuesto.SqlDbType = SqlDbType.VarChar;
            Nombre_Impuesto.Size = 20;
            Comando.Parameters.Add(Nombre_Impuesto);

            SqlParameter Nombre_Moneda = new SqlParameter();
            Nombre_Moneda.ParameterName = "@Nombre_Moneda";
            Nombre_Moneda.Value = this.Nombre_Moneda;
            Nombre_Moneda.Direction = ParameterDirection.Input;
            Nombre_Moneda.SqlDbType = SqlDbType.VarChar;
            Nombre_Moneda.Size = 50;
            Comando.Parameters.Add(Nombre_Moneda);

            SqlParameter Simbolo_Moneda = new SqlParameter();
            Simbolo_Moneda.ParameterName = "@Simbolo_Moneda";
            Simbolo_Moneda.Value = this.Simbolo_Moneda;
            Simbolo_Moneda.Direction = ParameterDirection.Input;
            Simbolo_Moneda.SqlDbType = SqlDbType.VarChar;
            Simbolo_Moneda.Size = 5;
            Comando.Parameters.Add(Simbolo_Moneda);

            SqlParameter Conversion_Dolar = new SqlParameter();
            Conversion_Dolar.ParameterName = "@Conversion_Dolar";
            Conversion_Dolar.Value = this.Conversion_Dolar;
            Conversion_Dolar.Direction = ParameterDirection.Input;
            Conversion_Dolar.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Conversion_Dolar);

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
            Comando.CommandText = "Update_Info_General";

            SqlParameter Empresa = new SqlParameter();
            Empresa.ParameterName = "@Empresa";
            Empresa.Value = this.Empresa;
            Empresa.Direction = ParameterDirection.Input;
            Empresa.SqlDbType = SqlDbType.VarChar;
            Empresa.Size = 100;
            Comando.Parameters.Add(Empresa);

            SqlParameter Nombre_Impuesto = new SqlParameter();
            Nombre_Impuesto.ParameterName = "@Nombre_Impuesto";
            Nombre_Impuesto.Value = this.Nombre_Impuesto;
            Nombre_Impuesto.Direction = ParameterDirection.Input;
            Nombre_Impuesto.SqlDbType = SqlDbType.VarChar;
            Nombre_Impuesto.Size = 20;
            Comando.Parameters.Add(Nombre_Impuesto);

            SqlParameter Nombre_Moneda = new SqlParameter();
            Nombre_Moneda.ParameterName = "@Nombre_Moneda";
            Nombre_Moneda.Value = this.Nombre_Moneda;
            Nombre_Moneda.Direction = ParameterDirection.Input;
            Nombre_Moneda.SqlDbType = SqlDbType.VarChar;
            Nombre_Moneda.Size = 50;
            Comando.Parameters.Add(Nombre_Moneda);

            SqlParameter Simbolo_Moneda = new SqlParameter();
            Simbolo_Moneda.ParameterName = "@Simbolo_Moneda";
            Simbolo_Moneda.Value = this.Simbolo_Moneda;
            Simbolo_Moneda.Direction = ParameterDirection.Input;
            Simbolo_Moneda.SqlDbType = SqlDbType.VarChar;
            Simbolo_Moneda.Size = 5;
            Comando.Parameters.Add(Simbolo_Moneda);

            SqlParameter Conversion_Dolar = new SqlParameter();
            Conversion_Dolar.ParameterName = "@Conversion_Dolar";
            Conversion_Dolar.Value = this.Conversion_Dolar;
            Conversion_Dolar.Direction = ParameterDirection.Input;
            Conversion_Dolar.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Conversion_Dolar);

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
        public DataRow Select()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Info_General";

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        #endregion
    }
    #endregion
}
#endregion
