using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Peluquería
{
    class Conexión
    {
        private static string rutaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Peluquería;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool ComprobarDatos(string Usuario, string Contraseña)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consulta = "SELECT COUNT(*) FROM Cuentas WHERE Usuario=@Usuario AND Contraseña=@Contraseña";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        public void AgregarTurno(string nombre, string apellido, string servicio, string telefono, DateTime fecha)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    string consulta = "INSERT INTO Turnos (Nombre, Apellido, Servicio, Teléfono, Fecha) VALUES (@Nombre, @Apellido, @Servicio, @Telefono, @Fecha)";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Servicio", servicio);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al agregar turno: " + ex.Message);
                    // También podrías lanzar una excepción personalizada si es necesario
                }
            }
        }


        public List<string> ObtenerServicios()
        {
            List<string> servicios = new List<string>();

            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    string consulta = "SELECT Servicio FROM Servicios";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string descripcion = reader.GetString(0);
                                servicios.Add(descripcion);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener servicios: " + ex.Message);
                    // También podrías lanzar una excepción personalizada si es necesario
                }
            }

            return servicios;
        }


        public DataTable TurnosHoy()
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaSolo = fechaActual.Date;
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT CONVERT(VARCHAR(50), Nombre + ' ' + Apellido) AS Cliente, Servicio, CONVERT(VARCHAR(5), Fecha, 108) AS Horario FROM Turnos WHERE Fecha >= @FechaInicio AND Fecha < @FechaFin";
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaSolo);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaSolo.AddDays(1)); // Agregar un día para incluir turnos hasta la medianoche
                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(filas);
                        return dt;
                    }
                }
            }
        }


        public DataTable Servicios()
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT Servicio, Precio FROM Servicios";
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(filas);
                        return dt;
                    }
                }
            }
        }


        public string getNombre(string Usuario)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT Nombre_Apellido FROM Cuentas WHERE Usuario=@Usuario";
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        if (filas.Read())
                        {
                            return filas["Nombre_Apellido"].ToString();
                        }
                    }
                }
            }

            return null;
        }


    } 
}
