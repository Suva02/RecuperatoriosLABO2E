using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public abstract class BaseDAO
    {
        protected SqlConnection? conexion;
        protected SqlCommand? comando;
        protected string? conexionDB;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public BaseDAO()
        {
            conexion = null;
            comando = null;
            conexionDB = @"Server = DESKTOP-CFUPRGC\SUVA02 ; Database = parcial_dos ; Trusted_Connection = True;";
        }

        /// <summary>
        /// PROPIEDAD QUE RETORNA LA CONEXION
        /// </summary>
        public SqlConnection? Conexion { get => conexion; set => conexion = value; }
        /// <summary>
        /// PROPIEDAD QUE RETORNA EL COMANDO
        /// </summary>
        public SqlCommand? Comando { get => comando; set => comando = value; }
        /// <summary>
        /// PROPIEDAD QUE RETORNA LA CADENA DE CONEXION A LA BASE DE DATOS
        /// </summary>
        public string? ConexionDB { get => conexionDB; set => conexionDB = value; }
    }
}
