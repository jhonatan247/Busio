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
    public class Producto
    {
        public static int 
            ID = 0,
            SUCURSAL = 1,
            EMPRESA_DISTRIBUIDORA = 2,
            MARCA = 3,
            PRESENTACION = 4,
            CATEGORÍA = 5,
            UNIDAD_DE_MEDIDA = 6,
            IMPUESTO = 7,
            CÓDIGO = 8,
            NOMBRE = 9,
            DESCRIPCION = 10,
            IMAGEN = 11,
            PRECIO_COMPRA = 12,
            GANANCIA_NORMAL = 13,
            GANANCIA_MAYOREO = 14,
            GANANCIA_MINIMA = 15,
            IMPUESTO_INCLUIDO = 16,
            UTILIZA_INVENTARIO = 17,
            CANTIDAD_MINIMA = 18,
            CANTIDAD_EN_INVENTARIO = 19;


        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Empresa_Distribuidora { get; set; }
        public long Id_Marca { get; set; }
        public long Id_Presentacion { get; set; }
        public long Id_Categoria { get; set; }
        public long Id_Unidad_Medida { get; set; }
        public string Codigo_Barras { get; set; }
        public string Nombre_Acortado { get; set; }
        public string Descripcion { get; set; }
        public Image Imagen { get; set; }
        public double Precio_Compra { get; set; }
        public double Porcentaje_Impuesto { get; set; }
        public double Porcentaje_Detal { get; set; }
        public double Porcentaje_Mayoreo { get; set; }
        public double Porcentaje_Minimo { get; set; }
        public bool Impuesto_Incluido { get; set; }
        public bool Inventariado { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Producto()
        {
        }
        public Producto(long pId, long pId_Empresa_Distribuidora, long pId_Marca, long pId_Presentacion,
            long pId_Categoria, long pId_Unidad_Medida, string pCodigo_Barras,
            string pNombre_Acortado, string pDescripcion, Image pImagen, double pPrecio_Compra, double pPorcentaje_Impuesto,
            double pPorcentaje_Detal, double pPorcentaje_Mayoreo, double pPorcentaje_Minimo,
            bool pImpuesto_Incluido, bool pInventariado, DateTime pFecha_Registro, bool pEstado)
        {
            Id = pId;
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Marca = pId_Marca;
            Id_Presentacion = pId_Presentacion;
            Id_Categoria = pId_Categoria;
            Id_Unidad_Medida = pId_Unidad_Medida;
            Codigo_Barras = pCodigo_Barras;
            Nombre_Acortado = pNombre_Acortado;
            Descripcion = pDescripcion;
            Imagen = pImagen;
            Precio_Compra = pPrecio_Compra;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Porcentaje_Detal = pPorcentaje_Detal;
            Porcentaje_Mayoreo = pPorcentaje_Mayoreo;
            Porcentaje_Minimo = pPorcentaje_Minimo;
            Impuesto_Incluido = pImpuesto_Incluido;
            Inventariado = pInventariado;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
        }
        public Producto(long pId, long pId_Empresa_Distribuidora, long pId_Marca, long pId_Presentacion,
            long pId_Categoria, long pId_Unidad_Medida, string pCodigo_Barras,
            string pNombre_Acortado, string pDescripcion, Image pImagen, double pPrecio_Compra, double pPorcentaje_Impuesto,
            double pPorcentaje_Detal, double pPorcentaje_Mayoreo, double pPorcentaje_Minimo,
            bool pImpuesto_Incluido, bool pInventariado, bool pEstado)
        {
            Id = pId;
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Marca = pId_Marca;
            Id_Presentacion = pId_Presentacion;
            Id_Categoria = pId_Categoria;
            Id_Unidad_Medida = pId_Unidad_Medida;
            Codigo_Barras = pCodigo_Barras;
            Nombre_Acortado = pNombre_Acortado;
            Descripcion = pDescripcion;
            Imagen = pImagen;
            Precio_Compra = pPrecio_Compra;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Porcentaje_Detal = pPorcentaje_Detal;
            Porcentaje_Mayoreo = pPorcentaje_Mayoreo;
            Porcentaje_Minimo = pPorcentaje_Minimo;
            Impuesto_Incluido = pImpuesto_Incluido;
            Inventariado = pInventariado;
            Estado = pEstado;
        }
        public Producto(long pId, long pId_Empresa_Distribuidora, long pId_Marca, long pId_Presentacion,
            long pId_Categoria, long pId_Unidad_Medida, string pCodigo_Barras,
            string pNombre_Acortado, string pDescripcion, Image pImagen, double pPrecio_Compra, double pPorcentaje_Impuesto,
            double pPorcentaje_Detal, double pPorcentaje_Mayoreo, double pPorcentaje_Minimo,
            bool pImpuesto_Incluido, bool pInventariado)
        {
            Id = pId;
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Marca = pId_Marca;
            Id_Presentacion = pId_Presentacion;
            Id_Categoria = pId_Categoria;
            Id_Unidad_Medida = pId_Unidad_Medida;
            Codigo_Barras = pCodigo_Barras;
            Nombre_Acortado = pNombre_Acortado;
            Descripcion = pDescripcion;
            Imagen = pImagen;
            Precio_Compra = pPrecio_Compra;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Porcentaje_Detal = pPorcentaje_Detal;
            Porcentaje_Mayoreo = pPorcentaje_Mayoreo;
            Porcentaje_Minimo = pPorcentaje_Minimo;
            Impuesto_Incluido = pImpuesto_Incluido;
            Inventariado = pInventariado;
        }
        public Producto(long pId_Empresa_Distribuidora, long pId_Marca, long pId_Presentacion,
            long pId_Categoria, long pId_Unidad_Medida, string pCodigo_Barras,
            string pNombre_Acortado, string pDescripcion, Image pImagen, double pPrecio_Compra, double pPorcentaje_Impuesto,
            double pPorcentaje_Detal, double pPorcentaje_Mayoreo, double pPorcentaje_Minimo,
            bool pImpuesto_Incluido, bool pInventariado)
        {
            Id_Empresa_Distribuidora = pId_Empresa_Distribuidora;
            Id_Marca = pId_Marca;
            Id_Presentacion = pId_Presentacion;
            Id_Categoria = pId_Categoria;
            Id_Unidad_Medida = pId_Unidad_Medida;
            Codigo_Barras = pCodigo_Barras;
            Nombre_Acortado = pNombre_Acortado;
            Descripcion = pDescripcion;
            Imagen = pImagen;
            Precio_Compra = pPrecio_Compra;
            Porcentaje_Impuesto = pPorcentaje_Impuesto;
            Porcentaje_Detal = pPorcentaje_Detal;
            Porcentaje_Mayoreo = pPorcentaje_Mayoreo;
            Porcentaje_Minimo = pPorcentaje_Minimo;
            Impuesto_Incluido = pImpuesto_Incluido;
            Inventariado = pInventariado;
        }
        public Producto(long pId, bool pEstado)
        {
            Id = pId;
            Estado = pEstado;
        }
        public Producto(bool pEstado)
        {
            Estado = pEstado;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Producto";

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Marca = new SqlParameter();
            Id_Marca.ParameterName = "@Id_Marca";
            Id_Marca.Value = this.Id_Marca;
            Id_Marca.Direction = ParameterDirection.Input;
            Id_Marca.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Marca);

            SqlParameter Id_Presentacion = new SqlParameter();
            Id_Presentacion.ParameterName = "@Id_Presentacion";
            Id_Presentacion.Value = this.Id_Presentacion;
            Id_Presentacion.Direction = ParameterDirection.Input;
            Id_Presentacion.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Presentacion);

            SqlParameter Id_Categoria = new SqlParameter();
            Id_Categoria.ParameterName = "@Id_Categoria";
            Id_Categoria.Value = this.Id_Categoria;
            Id_Categoria.Direction = ParameterDirection.Input;
            Id_Categoria.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Categoria);

            SqlParameter Id_Unidad_Medida = new SqlParameter();
            Id_Unidad_Medida.ParameterName = "@Id_Unidad_Medida";
            Id_Unidad_Medida.Value = this.Id_Unidad_Medida;
            Id_Unidad_Medida.Direction = ParameterDirection.Input;
            Id_Unidad_Medida.SqlDbType = SqlDbType.BigInt;
            Id_Unidad_Medida
            Comando.Parameters.Add(Id_Unidad_Medida);

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = this.Codigo_Barras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = this.Nombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Imagen = new SqlParameter();
            Imagen.ParameterName = "@Imagen";
            if (this.Imagen == null)
            {
                Imagen.Value = DBNull.Value;
            }
            else
                Imagen.Value = AccionesSistema.ConvertirImagen(this.Imagen);
            Imagen.Direction = ParameterDirection.Input;
            Imagen.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Imagen);

            SqlParameter Precio_Compra = new SqlParameter();
            Precio_Compra.ParameterName = "@Precio_Compra";
            Precio_Compra.Value = this.Precio_Compra;
            Precio_Compra.Direction = ParameterDirection.Input;
            Precio_Compra.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio_Compra);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Porcentaje_Detal = new SqlParameter();
            Porcentaje_Detal.ParameterName = "@Porcentaje_Detal";
            Porcentaje_Detal.Value = this.Porcentaje_Detal;
            Porcentaje_Detal.Direction = ParameterDirection.Input;
            Porcentaje_Detal.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Detal);

            SqlParameter Porcentaje_Mayoreo = new SqlParameter();
            Porcentaje_Mayoreo.ParameterName = "@Porcentaje_Mayoreo";
            Porcentaje_Mayoreo.Value = this.Porcentaje_Mayoreo;
            Porcentaje_Mayoreo.Direction = ParameterDirection.Input;
            Porcentaje_Mayoreo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Mayoreo);

            SqlParameter Porcentaje_Minimo = new SqlParameter();
            Porcentaje_Minimo.ParameterName = "@Porcentaje_Minimo";
            Porcentaje_Minimo.Value = this.Porcentaje_Minimo;
            Porcentaje_Minimo.Direction = ParameterDirection.Input;
            Porcentaje_Minimo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Minimo);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            SqlParameter Inventariado = new SqlParameter();
            Inventariado.ParameterName = "@Inventariado";
            Inventariado.Value = this.Inventariado;
            Inventariado.Direction = ParameterDirection.Input;
            Inventariado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventariado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long InsertCompleto(Inventario Inv, Movimiento_Inventario MInv)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Producto_Completo";

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Marca = new SqlParameter();
            Id_Marca.ParameterName = "@Id_Marca";
            Id_Marca.Value = this.Id_Marca;
            Id_Marca.Direction = ParameterDirection.Input;
            Id_Marca.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Marca);

            SqlParameter Id_Presentacion = new SqlParameter();
            Id_Presentacion.ParameterName = "@Id_Presentacion";
            Id_Presentacion.Value = this.Id_Presentacion;
            Id_Presentacion.Direction = ParameterDirection.Input;
            Id_Presentacion.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Presentacion);

            SqlParameter Id_Categoria = new SqlParameter();
            Id_Categoria.ParameterName = "@Id_Categoria";
            Id_Categoria.Value = this.Id_Categoria;
            Id_Categoria.Direction = ParameterDirection.Input;
            Id_Categoria.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Categoria);

            SqlParameter Id_Unidad_Medida = new SqlParameter();
            Id_Unidad_Medida.ParameterName = "@Id_Unidad_Medida";
            Id_Unidad_Medida.Value = this.Id_Unidad_Medida;
            Id_Unidad_Medida.Direction = ParameterDirection.Input;
            Id_Unidad_Medida.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Unidad_Medida);

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = this.Codigo_Barras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = this.Nombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Imagen = new SqlParameter();
            Imagen.ParameterName = "@Imagen";
            if (this.Imagen == null)
            {
                Imagen.Value = DBNull.Value;
            }
            else
                Imagen.Value = AccionesSistema.ConvertirImagen(this.Imagen);
            Imagen.Direction = ParameterDirection.Input;
            Imagen.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Imagen);

            SqlParameter Precio_Compra = new SqlParameter();
            Precio_Compra.ParameterName = "@Precio_Compra";
            Precio_Compra.Value = this.Precio_Compra;
            Precio_Compra.Direction = ParameterDirection.Input;
            Precio_Compra.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio_Compra);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Porcentaje_Detal = new SqlParameter();
            Porcentaje_Detal.ParameterName = "@Porcentaje_Detal";
            Porcentaje_Detal.Value = this.Porcentaje_Detal;
            Porcentaje_Detal.Direction = ParameterDirection.Input;
            Porcentaje_Detal.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Detal);

            SqlParameter Porcentaje_Mayoreo = new SqlParameter();
            Porcentaje_Mayoreo.ParameterName = "@Porcentaje_Mayoreo";
            Porcentaje_Mayoreo.Value = this.Porcentaje_Mayoreo;
            Porcentaje_Mayoreo.Direction = ParameterDirection.Input;
            Porcentaje_Mayoreo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Mayoreo);

            SqlParameter Porcentaje_Minimo = new SqlParameter();
            Porcentaje_Minimo.ParameterName = "@Porcentaje_Minimo";
            Porcentaje_Minimo.Value = this.Porcentaje_Minimo;
            Porcentaje_Minimo.Direction = ParameterDirection.Input;
            Porcentaje_Minimo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Minimo);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            SqlParameter Inventariado = new SqlParameter();
            Inventariado.ParameterName = "@Inventariado";
            Inventariado.Value = this.Inventariado;
            Inventariado.Direction = ParameterDirection.Input;
            Inventariado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventariado);

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = Inv.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = Inv.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = MInv.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Producto";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Marca = new SqlParameter();
            Id_Marca.ParameterName = "@Id_Marca";
            Id_Marca.Value = this.Id_Marca;
            Id_Marca.Direction = ParameterDirection.Input;
            Id_Marca.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Marca);

            SqlParameter Id_Presentacion = new SqlParameter();
            Id_Presentacion.ParameterName = "@Id_Presentacion";
            Id_Presentacion.Value = this.Id_Presentacion;
            Id_Presentacion.Direction = ParameterDirection.Input;
            Id_Presentacion.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Presentacion);

            SqlParameter Id_Categoria = new SqlParameter();
            Id_Categoria.ParameterName = "@Id_Categoria";
            Id_Categoria.Value = this.Id_Categoria;
            Id_Categoria.Direction = ParameterDirection.Input;
            Id_Categoria.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Categoria);

            SqlParameter Id_Unidad_Medida = new SqlParameter();
            Id_Unidad_Medida.ParameterName = "@Id_Unidad_Medida";
            Id_Unidad_Medida.Value = this.Id_Unidad_Medida;
            Id_Unidad_Medida.Direction = ParameterDirection.Input;
            Id_Unidad_Medida.SqlDbType = SqlDbType.BigInt;

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = this.Codigo_Barras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = this.Nombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Imagen = new SqlParameter();
            Imagen.ParameterName = "@Imagen";
            if (this.Imagen == null)
            {
                Imagen.Value = DBNull.Value;
            }
            else
                Imagen.Value = AccionesSistema.ConvertirImagen(this.Imagen);
            Imagen.Direction = ParameterDirection.Input;
            Imagen.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Imagen);

            SqlParameter Precio_Compra = new SqlParameter();
            Precio_Compra.ParameterName = "@Precio_Compra";
            Precio_Compra.Value = this.Precio_Compra;
            Precio_Compra.Direction = ParameterDirection.Input;
            Precio_Compra.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio_Compra);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Porcentaje_Detal = new SqlParameter();
            Porcentaje_Detal.ParameterName = "@Porcentaje_Detal";
            Porcentaje_Detal.Value = this.Porcentaje_Detal;
            Porcentaje_Detal.Direction = ParameterDirection.Input;
            Porcentaje_Detal.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Detal);

            SqlParameter Porcentaje_Mayoreo = new SqlParameter();
            Porcentaje_Mayoreo.ParameterName = "@Porcentaje_Mayoreo";
            Porcentaje_Mayoreo.Value = this.Porcentaje_Mayoreo;
            Porcentaje_Mayoreo.Direction = ParameterDirection.Input;
            Porcentaje_Mayoreo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Mayoreo);

            SqlParameter Porcentaje_Minimo = new SqlParameter();
            Porcentaje_Minimo.ParameterName = "@Porcentaje_Minimo";
            Porcentaje_Minimo.Value = this.Porcentaje_Minimo;
            Porcentaje_Minimo.Direction = ParameterDirection.Input;
            Porcentaje_Minimo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Minimo);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            SqlParameter Inventariado = new SqlParameter();
            Inventariado.ParameterName = "@Inventariado";
            Inventariado.Value = this.Inventariado;
            Inventariado.Direction = ParameterDirection.Input;
            Inventariado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventariado);

            SqlParameter Estado = new SqlParameter();
            Estado.ParameterName = "@Estado";
            Estado.Value = this.Estado;
            Estado.Direction = ParameterDirection.Input;
            Estado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estado);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update_Completo(Inventario Inv, Movimiento_Inventario MInv)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Producto_Completo";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Empresa_Distribuidora = new SqlParameter();
            Id_Empresa_Distribuidora.ParameterName = "@Id_Empresa_Distribuidora";
            Id_Empresa_Distribuidora.Value = this.Id_Empresa_Distribuidora;
            Id_Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Id_Empresa_Distribuidora.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Empresa_Distribuidora);

            SqlParameter Id_Marca = new SqlParameter();
            Id_Marca.ParameterName = "@Id_Marca";
            Id_Marca.Value = this.Id_Marca;
            Id_Marca.Direction = ParameterDirection.Input;
            Id_Marca.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Marca);

            SqlParameter Id_Presentacion = new SqlParameter();
            Id_Presentacion.ParameterName = "@Id_Presentacion";
            Id_Presentacion.Value = this.Id_Presentacion;
            Id_Presentacion.Direction = ParameterDirection.Input;
            Id_Presentacion.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Presentacion);

            SqlParameter Id_Categoria = new SqlParameter();
            Id_Categoria.ParameterName = "@Id_Categoria";
            Id_Categoria.Value = this.Id_Categoria;
            Id_Categoria.Direction = ParameterDirection.Input;
            Id_Categoria.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Categoria);

            SqlParameter Id_Unidad_Medida = new SqlParameter();
            Id_Unidad_Medida.ParameterName = "@Id_Unidad_Medida";
            Id_Unidad_Medida.Value = this.Id_Unidad_Medida;
            Id_Unidad_Medida.Direction = ParameterDirection.Input;
            Id_Unidad_Medida.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Unidad_Medida);

            SqlParameter Porcentaje_Impuesto = new SqlParameter();
            Porcentaje_Impuesto.ParameterName = "@Porcentaje_Impuesto";
            Porcentaje_Impuesto.Value = this.Porcentaje_Impuesto;
            Porcentaje_Impuesto.Direction = ParameterDirection.Input;
            Porcentaje_Impuesto.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Impuesto);

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = this.Codigo_Barras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = this.Nombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = this.Descripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Imagen = new SqlParameter();
            Imagen.ParameterName = "@Imagen";
            if (this.Imagen == null)
            {
                Imagen.Value = DBNull.Value;
            }
            else
                Imagen.Value = AccionesSistema.ConvertirImagen(this.Imagen);
            Imagen.Direction = ParameterDirection.Input;
            Imagen.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(Imagen);

            SqlParameter Precio_Compra = new SqlParameter();
            Precio_Compra.ParameterName = "@Precio_Compra";
            Precio_Compra.Value = this.Precio_Compra;
            Precio_Compra.Direction = ParameterDirection.Input;
            Precio_Compra.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(Precio_Compra);

            SqlParameter Porcentaje_Detal = new SqlParameter();
            Porcentaje_Detal.ParameterName = "@Porcentaje_Detal";
            Porcentaje_Detal.Value = this.Porcentaje_Detal;
            Porcentaje_Detal.Direction = ParameterDirection.Input;
            Porcentaje_Detal.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Detal);

            SqlParameter Porcentaje_Mayoreo = new SqlParameter();
            Porcentaje_Mayoreo.ParameterName = "@Porcentaje_Mayoreo";
            Porcentaje_Mayoreo.Value = this.Porcentaje_Mayoreo;
            Porcentaje_Mayoreo.Direction = ParameterDirection.Input;
            Porcentaje_Mayoreo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Mayoreo);

            SqlParameter Porcentaje_Minimo = new SqlParameter();
            Porcentaje_Minimo.ParameterName = "@Porcentaje_Minimo";
            Porcentaje_Minimo.Value = this.Porcentaje_Minimo;
            Porcentaje_Minimo.Direction = ParameterDirection.Input;
            Porcentaje_Minimo.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Porcentaje_Minimo);

            SqlParameter Impuesto_Incluido = new SqlParameter();
            Impuesto_Incluido.ParameterName = "@Impuesto_Incluido";
            Impuesto_Incluido.Value = this.Impuesto_Incluido;
            Impuesto_Incluido.Direction = ParameterDirection.Input;
            Impuesto_Incluido.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Impuesto_Incluido);

            SqlParameter Inventariado = new SqlParameter();
            Inventariado.ParameterName = "@Inventariado";
            Inventariado.Value = this.Inventariado;
            Inventariado.Direction = ParameterDirection.Input;
            Inventariado.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventariado);

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = Inv.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Cantidad_Minima = new SqlParameter();
            Cantidad_Minima.ParameterName = "@Cantidad_Minima";
            Cantidad_Minima.Value = Inv.Cantidad_Minima;
            Cantidad_Minima.Direction = ParameterDirection.Input;
            Cantidad_Minima.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad_Minima);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = MInv.Cantidad;
            Cantidad.Direction = ParameterDirection.Input;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            Comando.Parameters.Add(Cantidad);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update_Estado()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Estado_Producto";

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
            Comando.CommandText = "UpdateAll_Estado_Producto";

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
            Comando.CommandText = "Select_Producto";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataRow SelectVista(long pId_Sucursal, long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Vista_Producto";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = pId_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataRow SelectVistaOf(long pId_Sucursal, long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Vista_Producto_Of";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = pId_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataTable SelectVender(long pId_Sucursal, string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Vista_Producto_Vender";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = pId_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = pTxt;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(Codigo_Barras);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable Like(string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Producto";

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
            Comando.CommandText = "Like_Producto_Of";

            SqlParameter txt = new SqlParameter();
            txt.ParameterName = "@txt";
            txt.Value = pTxt;
            txt.Direction = ParameterDirection.Input;
            txt.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(txt);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LikeAvanzado(string pCodigoBarras, string pNombre_Acortado, string pDescripcion, string pSucursal, string pEmpresa_Distribuidora, 
            string pMarca, string pPresentacion, string pCategoria, string pUnidad_Medida )
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Producto_Avanzado";

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = pCodigoBarras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = pNombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = pDescripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Sucursal = new SqlParameter();
            Sucursal.ParameterName = "@Sucursal";
            Sucursal.Value = pSucursal;
            Sucursal.Direction = ParameterDirection.Input;
            Sucursal.SqlDbType = SqlDbType.VarChar;
            Sucursal.Size = 40;
            Comando.Parameters.Add(Sucursal);

            SqlParameter Empresa_Distribuidora = new SqlParameter();
            Empresa_Distribuidora.ParameterName = "@Empresa_Distribuidora";
            Empresa_Distribuidora.Value = pEmpresa_Distribuidora;
            Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Empresa_Distribuidora.SqlDbType = SqlDbType.VarChar;
            Empresa_Distribuidora.Size = 40;
            Comando.Parameters.Add(Empresa_Distribuidora);

            SqlParameter Marca = new SqlParameter();
            Marca.ParameterName = "@Marca";
            Marca.Value = pMarca;
            Marca.Direction = ParameterDirection.Input;
            Marca.SqlDbType = SqlDbType.VarChar;
            Marca.Size = 30;
            Comando.Parameters.Add(Marca);

            SqlParameter Presentacion = new SqlParameter();
            Presentacion.ParameterName = "@Presentacion";
            Presentacion.Value = pPresentacion;
            Presentacion.Direction = ParameterDirection.Input;
            Presentacion.SqlDbType = SqlDbType.VarChar;
            Presentacion.Size = 30;
            Comando.Parameters.Add(Presentacion);

            SqlParameter Categoria = new SqlParameter();
            Categoria.ParameterName = "@Categoria";
            Categoria.Value = pCategoria;
            Categoria.Direction = ParameterDirection.Input;
            Categoria.SqlDbType = SqlDbType.VarChar;
            Categoria.Size = 30;
            Comando.Parameters.Add(Categoria);

            SqlParameter Unidad_Medida = new SqlParameter();
            Unidad_Medida.ParameterName = "@Unidad_Medida";
            Unidad_Medida.Value = pUnidad_Medida;
            Unidad_Medida.Direction = ParameterDirection.Input;
            Unidad_Medida.SqlDbType = SqlDbType.VarChar;
            Unidad_Medida.Size = 30;
            Comando.Parameters.Add(Unidad_Medida);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LikeAvanzadoOf(string pCodigoBarras, string pNombre_Acortado, string pDescripcion, string pSucursal, string pEmpresa_Distribuidora,
            string pMarca, string pPresentacion, string pCategoria, string pUnidad_Medida)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Producto_Avanzado_Of";

            SqlParameter Codigo_Barras = new SqlParameter();
            Codigo_Barras.ParameterName = "@Codigo_Barras";
            Codigo_Barras.Value = pCodigoBarras;
            Codigo_Barras.Direction = ParameterDirection.Input;
            Codigo_Barras.SqlDbType = SqlDbType.VarChar;
            Codigo_Barras.Size = 40;
            Comando.Parameters.Add(Codigo_Barras);

            SqlParameter Nombre_Acortado = new SqlParameter();
            Nombre_Acortado.ParameterName = "@Nombre_Acortado";
            Nombre_Acortado.Value = pNombre_Acortado;
            Nombre_Acortado.Direction = ParameterDirection.Input;
            Nombre_Acortado.SqlDbType = SqlDbType.VarChar;
            Nombre_Acortado.Size = 10;
            Comando.Parameters.Add(Nombre_Acortado);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = pDescripcion;
            Descripcion.Direction = ParameterDirection.Input;
            Descripcion.SqlDbType = SqlDbType.VarChar;
            Descripcion.Size = 200;
            Comando.Parameters.Add(Descripcion);

            SqlParameter Sucursal = new SqlParameter();
            Sucursal.ParameterName = "@Sucursal";
            Sucursal.Value = pSucursal;
            Sucursal.Direction = ParameterDirection.Input;
            Sucursal.SqlDbType = SqlDbType.VarChar;
            Sucursal.Size = 40;
            Comando.Parameters.Add(Sucursal);

            SqlParameter Empresa_Distribuidora = new SqlParameter();
            Empresa_Distribuidora.ParameterName = "@Empresa_Distribuidora";
            Empresa_Distribuidora.Value = pEmpresa_Distribuidora;
            Empresa_Distribuidora.Direction = ParameterDirection.Input;
            Empresa_Distribuidora.SqlDbType = SqlDbType.VarChar;
            Empresa_Distribuidora.Size = 40;
            Comando.Parameters.Add(Empresa_Distribuidora);

            SqlParameter Marca = new SqlParameter();
            Marca.ParameterName = "@Marca";
            Marca.Value = pMarca;
            Marca.Direction = ParameterDirection.Input;
            Marca.SqlDbType = SqlDbType.VarChar;
            Marca.Size = 30;
            Comando.Parameters.Add(Marca);

            SqlParameter Presentacion = new SqlParameter();
            Presentacion.ParameterName = "@Presentacion";
            Presentacion.Value = pPresentacion;
            Presentacion.Direction = ParameterDirection.Input;
            Presentacion.SqlDbType = SqlDbType.VarChar;
            Presentacion.Size = 30;
            Comando.Parameters.Add(Presentacion);

            SqlParameter Categoria = new SqlParameter();
            Categoria.ParameterName = "@Categoria";
            Categoria.Value = pCategoria;
            Categoria.Direction = ParameterDirection.Input;
            Categoria.SqlDbType = SqlDbType.VarChar;
            Categoria.Size = 30;
            Comando.Parameters.Add(Categoria);

            SqlParameter Unidad_Medida = new SqlParameter();
            Unidad_Medida.ParameterName = "@Unidad_Medida";
            Unidad_Medida.Value = pUnidad_Medida;
            Unidad_Medida.Direction = ParameterDirection.Input;
            Unidad_Medida.SqlDbType = SqlDbType.VarChar;
            Unidad_Medida.Size = 30;
            Comando.Parameters.Add(Unidad_Medida);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LikeSucursal(long pId_Sucursal, string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Producto_Sucursal";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = pId_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter txt = new SqlParameter();
            txt.ParameterName = "@txt";
            txt.Value = pTxt;
            txt.Direction = ParameterDirection.Input;
            txt.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(txt);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LikeSucursalOf(long pId_Sucursal, string pTxt)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Like_Producto_Sucursal_Of";

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = pId_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

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
            Comando.CommandText = "Delete_Producto";

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
            Comando.CommandText = "DeleteAll_Of_Producto";

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
