using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Peluquería
{
    class Conexión
    {
        static private string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string database = "PeluqueríaDB.mdf";
        private static string rutaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + database + ";Integrated Security=True";


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

        public bool ConsultaCliente(string nombre, string apellido, string telefono)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consulta = "SELECT COUNT(*) FROM Clientes WHERE Nombre=@Nombre AND Apellido=@Apellido AND Teléfono=@Telefono";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void AgregarTurno(int ClienteId, string servicio, DateTime fecha)
        {


            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    string consultaAgregar = "INSERT INTO Turnos (ClienteId, Servicio, Fecha) VALUES (@ClienteId, @Servicio, @Fecha)";
                    using (SqlCommand cmd = new SqlCommand(consultaAgregar, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                        cmd.Parameters.AddWithValue("@Servicio", servicio);
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

        public void AgregarTurno(string nombre, string apellido, string Servicio, string telefono, DateTime fecha)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AgregarTurnoYCliente", conn)) // Reemplaza "NombreDelProcedimientoAlmacenado" con el nombre real del procedimiento almacenado
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Servicio", Servicio);
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
        public void AgregarServicio(string Servicio, string Precio)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AgregarServicio", conn)) // Reemplaza "NombreDelProcedimientoAlmacenado" con el nombre real del procedimiento almacenado
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Servicio", Servicio);
                        cmd.Parameters.AddWithValue("@Precio", Precio);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al agregar Servicio: " + ex.Message);
                    // También podrías lanzar una excepción personalizada si es necesario
                }
            }
        }
        public void EliminarTurno(int TurnoId)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    string consulta = "DELETE FROM Turnos WHERE TurnoId = @TurnoId";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@TurnoId", TurnoId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al eliminar turno: " + ex.Message);
                }
            }
        }

        public void EliminarCliente(int ClienteId)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                try
                {
                    conn.Open();

                    string consulta = "DELETE FROM Clientes WHERE ClienteId = @ClienteId";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al eliminar Cliente: " + ex.Message);
                }
            }
        }
        public void EliminarServicio(int ServicioId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(rutaConexion))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarServicio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro "@ServicioId" al procedimiento almacenado
                        cmd.Parameters.AddWithValue("@ServicioId", ServicioId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine("Error al eliminar el servicio: " + ex.Message);
                // También podrías lanzar una excepción personalizada si es necesario
            }
        }
        public int ObtenerID(string nombre, string apellido)
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consulta = "SELECT ClienteId FROM Clientes WHERE Nombre=@Nombre AND Apellido=@Apellido";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            return id;
                        }
                        else
                        {
                            // Si no se encuentra el cliente, puedes devolver un valor predeterminado o lanzar una excepción.
                            // En este ejemplo, devolvemos -1 si no se encuentra el cliente.
                            return -1;
                        }
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

        public DataTable ObtenerClientes()
        {
            DataTable dtClientes = new DataTable();

            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT * FROM Clientes";
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        // Agregar las columnas al DataTable
                        for (int i = 0; i < filas.FieldCount; i++)
                        {
                            dtClientes.Columns.Add(filas.GetName(i));
                        }

                        while (filas.Read())
                        {
                            // Crear una nueva fila y asignar los valores
                            DataRow fila = dtClientes.NewRow();
                            for (int i = 0; i < filas.FieldCount; i++)
                            {
                                fila[i] = filas[i];
                            }

                            // Agregar la fila al DataTable
                            dtClientes.Rows.Add(fila);
                        }
                    }
                }
            }

            return dtClientes;
        }

        public DataTable TurnosHoy()
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaSolo = fechaActual.Date;

            DataTable turnosHoy = new DataTable();

            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = @"
                        SELECT 
                            T.TurnoId, 
                            CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente,
                            T.Servicio, 
                            CONVERT(varchar, T.Fecha, 103) AS Fecha,
                            LEFT(CONVERT(varchar, T.Fecha, 108), 5) + ' hs' AS Hora

                        FROM Turnos T
                            INNER JOIN Clientes C ON T.ClienteId = C.ClienteId
                
                        WHERE T.Fecha >= @FechaInicio AND T.Fecha < @FechaFin";

                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaSolo);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaSolo.AddDays(1)); // Agregar un día para incluir turnos hasta la medianoche

                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        turnosHoy.Load(filas);
                    }
                }
            }


            // Cambiar el nombre de las columnas
            turnosHoy.Columns["Fecha"].ColumnName = "Fecha";
            turnosHoy.Columns["Cliente"].ColumnName = "Cliente";
            turnosHoy.Columns["Servicio"].ColumnName = "Servicio";
            turnosHoy.Columns["Hora"].ColumnName = "Horario";

            return turnosHoy;
        }

        public DataTable Turnos()
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaSolo = fechaActual.Date;

            DataTable turnosHoy = new DataTable();

            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = @"
                SELECT 
                    T.TurnoId, 
                    CONVERT(varchar, T.Fecha, 103) AS Fecha,
                    DATENAME(WEEKDAY, T.Fecha) AS Dia,
                    CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente,
                    T.Servicio, 
                    LEFT(CONVERT(varchar, T.Fecha, 108), 5) + ' hs' AS Hora
                FROM Turnos T
                INNER JOIN Clientes C ON T.ClienteId = C.ClienteId";

                using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaSolo);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaSolo.AddDays(1)); // Agregar un día para incluir turnos hasta la medianoche

                    using (SqlDataReader filas = cmd.ExecuteReader())
                    {
                        turnosHoy.Load(filas);
                    }
                }
            }


            // Cambiar el nombre de las columnas
            turnosHoy.Columns["Cliente"].ColumnName = "Cliente";
            turnosHoy.Columns["Servicio"].ColumnName = "Servicio";
            turnosHoy.Columns["Hora"].ColumnName = "Horario";
            turnosHoy.Columns["Dia"].ColumnName = "Día";

            return turnosHoy;
        }

        public DataTable Servicios()
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT * FROM Servicios";
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
        public DataTable Detalles()
        {
            using (SqlConnection conn = new SqlConnection(rutaConexion))
            {
                conn.Open();

                string consultaSQL = "SELECT * FROM DetallesTurno";
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
    } 
}
