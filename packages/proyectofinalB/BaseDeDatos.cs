using System;
using System.Data.SQLite;

// Clase que maneja las operaciones de base de datos
class BaseDeDatos
{
    // Método estático que comprueba el login de un usuario dado su nombre
    public static string ComprobarLogin(string nombre)
    {
        // Cadena de conexión a la base de datos SQLite
        string connectionString = "Data Source=database/biblioteca.db;Version=3;";

        // Usando la instrucción 'using' para asegurar la correcta liberación de recursos
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            try
            {
                // Abre la conexión a la base de datos
                conn.Open();

                string clave = ""; // Variable para almacenar la clave del usuario
                // Consulta SQL para obtener la clave del usuario basado en su nombre
                string query = "SELECT clave FROM usuarios WHERE nombre='" + nombre + "'";

                // Prepara y ejecuta la consulta
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // Lee los resultados de la consulta
                        while (reader.Read())
                        {
                            clave = reader.GetString(0); // Obtiene la clave
                            return clave; // Retorna la clave del usuario
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: imprime el error en la consola
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                // Asegura que la conexión se cierre en cualquier caso
                conn.Close();
            }

            return null; // Retorna null si no se encontró el usuario o si hubo un error
        }
    }


    public static void RegistrarUsuarios(string nombre, string clave)
    {
        // Ruta de la base de datos
        string connectionString = "Data Source=database/biblioteca.db;Version=3;";

        // Cadena de conexión SQLite
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            try
            {
                // Abre la conexión
                conn.Open();

                // Consulta SQL para insertar los datos
                string query = "INSERT INTO usuarios (nombre, clave) VALUES (@nombre, @clave)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Parámetro para evitar inyección SQL
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    // Ejecuta el comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                conn.Close();
            }
        }
    }
}
