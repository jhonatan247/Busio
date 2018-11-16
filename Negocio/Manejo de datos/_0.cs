using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Manejo_de_datos
{
    class _0
    {/*
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_";

            SqlParameter Campo = new SqlParameter();
            Campo.ParameterName = "@Campo";
            Campo.Value = this.Campo;
            Campo.Direction = ParameterDirection.Input;
            Campo.SqlDbType = SqlDbType.VarChar;
            Campo.Size = 10;
            Comando.Parameters.Add(Campo);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_";

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
        public long Update_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Estado_";

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
            Comando.CommandText = "Select_";

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
            Comando.CommandText = "SelectAll_";

            DataTable dTable = ED.ProcedureExecuteReader(Comando);

            List<string> retorno = new List<string>();
            for (int i = 0; i < dTable.Rows.Count; i++)
                retorno.Add(dTable.Rows[i][0].ToString());

            return retorno;
        }
        public long SelectId(string txt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectId_";

            SqlParameter Campo = new SqlParameter();
            Campo.ParameterName = "@Campo";
            Campo.Value = txt;
            Campo.Direction = ParameterDirection.Input;
            Campo.SqlDbType = SqlDbType.VarChar;
            Campo.Size = 10;
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
            Comando.CommandText = "Delete_";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        /*SqlParameter foto_perfil = new SqlParameter();
        foto_perfil.ParameterName = "@foto_perfil";
            if (this.foto_perfil is null)
            {
            foto_perfil.Value = DBNull.Value;
        }
            else
                foto_perfil.Value = AccionesSistema.ConvertirImagen(this.foto_perfil);
        foto_perfil.Direction = ParameterDirection.Input;
        foto_perfil.SqlDbType = SqlDbType.Image;
        Comando.Parameters.Add(foto_perfil);*/
    }
}
