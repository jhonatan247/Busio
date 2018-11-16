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
    public class Permisos_Usuario_Sucursal
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id { get; set; }
        public long Id_Usuario { get; set; }
        public long Id_Sucursal { get; set; }
        public bool Ventas { get; set; }
        public bool Productos { get; set; }
        public bool Servicios { get; set; }
        public bool Clientes { get; set; }
        public bool Proveedores { get; set; }
        public bool Corte { get; set; }
        public bool Inventario { get; set; }
        public bool Pedidos { get; set; }
        public bool Estadisticas { get; set; }
        public bool Herramientas { get; set; }
        public bool Configuraciones { get; set; }

        #endregion

        #region Constructores
        public Permisos_Usuario_Sucursal()
        {
        }
        public Permisos_Usuario_Sucursal(long pId, long pId_Usuario, long pId_Sucursal, bool pVentas,
            bool pProductos, bool pServicios, bool pClientes, bool pProveedores, bool pCorte,
            bool pInventario, bool pPedidos, bool pEstadisticas, bool pHerramientas, bool pConfiguraciones)
        {
            Id = pId;
            Id_Usuario = pId_Usuario;
            Id_Sucursal = pId_Sucursal;
            Ventas = pVentas;
            Productos = pProductos;
            Servicios = pServicios;
            Clientes = pClientes;
            Proveedores = pProveedores;
            Corte = pCorte;
            Inventario = pInventario;
            Pedidos = pPedidos;
            Estadisticas = pEstadisticas;
            Herramientas = pHerramientas;
            Configuraciones = pConfiguraciones;
        }
        public Permisos_Usuario_Sucursal(long pId_Usuario, long pId_Sucursal, bool pVentas,
            bool pProductos, bool pServicios, bool pClientes, bool pProveedores, bool pCorte,
            bool pInventario, bool pPedidos, bool pEstadisticas, bool pHerramientas, bool pConfiguraciones)
        {
            Id_Usuario = pId_Usuario;
            Id_Sucursal = pId_Sucursal;
            Ventas = pVentas;
            Productos = pProductos;
            Servicios = pServicios;
            Clientes = pClientes;
            Proveedores = pProveedores;
            Corte = pCorte;
            Inventario = pInventario;
            Pedidos = pPedidos;
            Estadisticas = pEstadisticas;
            Herramientas = pHerramientas;
            Configuraciones = pConfiguraciones;
        }
        #endregion

        #region Métodos
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Insert_Permisos_Usuario_Sucursal";

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Ventas = new SqlParameter();
            Ventas.ParameterName = "@Ventas";
            Ventas.Value = this.Ventas;
            Ventas.Direction = ParameterDirection.Input;
            Ventas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Ventas);

            SqlParameter Productos = new SqlParameter();
            Productos.ParameterName = "@Productos";
            Productos.Value = this.Productos;
            Productos.Direction = ParameterDirection.Input;
            Productos.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Productos);

            SqlParameter Servicios = new SqlParameter();
            Servicios.ParameterName = "@Servicios";
            Servicios.Value = this.Servicios;
            Servicios.Direction = ParameterDirection.Input;
            Servicios.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Servicios);

            SqlParameter Clientes = new SqlParameter();
            Clientes.ParameterName = "@Clientes";
            Clientes.Value = this.Clientes;
            Clientes.Direction = ParameterDirection.Input;
            Clientes.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Clientes);

            SqlParameter Proveedores = new SqlParameter();
            Proveedores.ParameterName = "@Proveedores";
            Proveedores.Value = this.Proveedores;
            Proveedores.Direction = ParameterDirection.Input;
            Proveedores.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Proveedores);

            SqlParameter Corte = new SqlParameter();
            Corte.ParameterName = "@Corte";
            Corte.Value = this.Corte;
            Corte.Direction = ParameterDirection.Input;
            Corte.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Corte);

            SqlParameter Inventario = new SqlParameter();
            Inventario.ParameterName = "@Inventario";
            Inventario.Value = this.Inventario;
            Inventario.Direction = ParameterDirection.Input;
            Inventario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventario);

            SqlParameter Pedidos = new SqlParameter();
            Pedidos.ParameterName = "@Pedidos";
            Pedidos.Value = this.Pedidos;
            Pedidos.Direction = ParameterDirection.Input;
            Pedidos.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Pedidos);

            SqlParameter Estadisticas = new SqlParameter();
            Estadisticas.ParameterName = "@Estadisticas";
            Estadisticas.Value = this.Estadisticas;
            Estadisticas.Direction = ParameterDirection.Input;
            Estadisticas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estadisticas);

            SqlParameter Herramientas = new SqlParameter();
            Herramientas.ParameterName = "@Herramientas";
            Herramientas.Value = this.Herramientas;
            Herramientas.Direction = ParameterDirection.Input;
            Herramientas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Herramientas);

            SqlParameter Configuraciones = new SqlParameter();
            Configuraciones.ParameterName = "@Configuraciones";
            Configuraciones.Value = this.Configuraciones;
            Configuraciones.Direction = ParameterDirection.Input;
            Configuraciones.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Configuraciones);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public long Update()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Update_Permisos_Usuario_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = this.Id;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            SqlParameter Id_Usuario = new SqlParameter();
            Id_Usuario.ParameterName = "@Id_Usuario";
            Id_Usuario.Value = this.Id_Usuario;
            Id_Usuario.Direction = ParameterDirection.Input;
            Id_Usuario.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Usuario);

            SqlParameter Id_Sucursal = new SqlParameter();
            Id_Sucursal.ParameterName = "@Id_Sucursal";
            Id_Sucursal.Value = this.Id_Sucursal;
            Id_Sucursal.Direction = ParameterDirection.Input;
            Id_Sucursal.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id_Sucursal);

            SqlParameter Ventas = new SqlParameter();
            Ventas.ParameterName = "@Ventas";
            Ventas.Value = this.Ventas;
            Ventas.Direction = ParameterDirection.Input;
            Ventas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Ventas);

            SqlParameter Productos = new SqlParameter();
            Productos.ParameterName = "@Productos";
            Productos.Value = this.Productos;
            Productos.Direction = ParameterDirection.Input;
            Productos.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Productos);

            SqlParameter Servicios = new SqlParameter();
            Servicios.ParameterName = "@Servicios";
            Servicios.Value = this.Servicios;
            Servicios.Direction = ParameterDirection.Input;
            Servicios.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Servicios);

            SqlParameter Clientes = new SqlParameter();
            Clientes.ParameterName = "@Clientes";
            Clientes.Value = this.Clientes;
            Clientes.Direction = ParameterDirection.Input;
            Clientes.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Clientes);

            SqlParameter Proveedores = new SqlParameter();
            Proveedores.ParameterName = "@Proveedores";
            Proveedores.Value = this.Proveedores;
            Proveedores.Direction = ParameterDirection.Input;
            Proveedores.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Proveedores);

            SqlParameter Corte = new SqlParameter();
            Corte.ParameterName = "@Corte";
            Corte.Value = this.Corte;
            Corte.Direction = ParameterDirection.Input;
            Corte.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Corte);

            SqlParameter Inventario = new SqlParameter();
            Inventario.ParameterName = "@Inventario";
            Inventario.Value = this.Inventario;
            Inventario.Direction = ParameterDirection.Input;
            Inventario.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Inventario);

            SqlParameter Pedidos = new SqlParameter();
            Pedidos.ParameterName = "@Pedidos";
            Pedidos.Value = this.Pedidos;
            Pedidos.Direction = ParameterDirection.Input;
            Pedidos.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Pedidos);

            SqlParameter Estadisticas = new SqlParameter();
            Estadisticas.ParameterName = "@Estadisticas";
            Estadisticas.Value = this.Estadisticas;
            Estadisticas.Direction = ParameterDirection.Input;
            Estadisticas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Estadisticas);

            SqlParameter Herramientas = new SqlParameter();
            Herramientas.ParameterName = "@Herramientas";
            Herramientas.Value = this.Herramientas;
            Herramientas.Direction = ParameterDirection.Input;
            Herramientas.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Herramientas);

            SqlParameter Configuraciones = new SqlParameter();
            Configuraciones.ParameterName = "@Configuraciones";
            Configuraciones.Value = this.Configuraciones;
            Configuraciones.Direction = ParameterDirection.Input;
            Configuraciones.SqlDbType = SqlDbType.Bit;
            Comando.Parameters.Add(Configuraciones);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataRow Select(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "Select_Permisos_Usuario_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando).Rows[0];
        }
        public DataTable SelectPermisos(long pId)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SelectUsuario_Permisos_Usuario_Sucursal";

            SqlParameter Id = new SqlParameter();
            Id.ParameterName = "@Id";
            Id.Value = pId;
            Id.Direction = ParameterDirection.Input;
            Id.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(Id);

            return ED.ProcedureExecuteReader(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
