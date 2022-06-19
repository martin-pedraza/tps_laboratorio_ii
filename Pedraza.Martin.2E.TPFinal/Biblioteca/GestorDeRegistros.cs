using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class GestorDeRegistros
    {
        /// <summary>
        /// Serializará el Centro en un archivo .json
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="clientes"></param>
        /// <exception cref="RegistrosException">lanzara una excepcion RegistrosException</exception>
        public static void Serializar_JSON(string nombreArchivo, Centro<Cliente> clientes)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    JsonSerializerOptions op = new JsonSerializerOptions();
                    op.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(clientes, op);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception)
            {

                throw new RegistrosException("Error al guardar archivo");
            }
        }
        /// <summary>
        /// Deserializa un archivo .json en un Centro<Cliente>
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="c1"></param>
        /// <returns>Devuelve el Centro generado</returns>
        /// <exception cref="RegistrosException">lanzara una excepcion RegistrosException</exception>
        public static Centro<Cliente> DesSerializar_JSON(string nombreArchivo, Centro<Cliente> c1)
        {
            try
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string json = sr.ReadToEnd();
                    Centro<Cliente> c2 = JsonSerializer.Deserialize<Centro<Cliente>>(json);
                    c1.duplicarCentro(c2);
                    return c1;
                }
            }
            catch (Exception)
            {
                throw new RegistrosException("No se pudo abrir archivo");
            }
        }
        /// <summary>
        /// Guardara el string que recibe en la direccion indicada
        /// </summary>
        /// <param name="nombreArchivo">direccion del archivo</param>
        /// <param name="texto">string a guardar</param>
        /// <exception cref="RegistrosException">lanzara una excepcion RegistrosException</exception>
        public static void GuardarCorreo(string nombreArchivo, string texto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.WriteLine(texto);
                }
            }
            catch (Exception)
            {
                throw new RegistrosException("No se pudo guardar el archivo correctamente");
            }
        }
        /// <summary>
        /// Verificará la direccion del archivo recibida y devuelve el string del archivo
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        /// <exception cref="RegistrosException">lanzara una excepcion RegistrosException</exception>
        public static string AbrirCorreo(string nombreArchivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (RegistrosException)
            {
                throw new RegistrosException("No se pudo abrir archivo");
            }
        }
        /// <summary>
        /// Se conectará a la base de datos y agregará todos los elementos al Centro
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        /// <exception cref="RegistrosException">lanzara una excepcion RegistrosException</exception>
        public static Centro<Cliente> ConectarBase(Centro<Cliente> clientes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=.;Database=OtraSucursal;Trusted_Connection=True"))
                {
                    string query = "select * from Cliente inner join Servicio on Cliente.dni = Servicio.dniCliente";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int dni = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string telefono = reader.GetString(3);
                        Cliente cliente = new Cliente(dni, nombre, apellido, telefono);
                        int id = reader.GetInt32(4);
                        int duracion = reader.GetInt32(5);
                        double costo = decimal.ToDouble( reader.GetDecimal(6));
                        DateTime fecha = reader.GetDateTime(7);
                        ETipo tipo = (ETipo)Enum.Parse(typeof(ETipo), reader.GetString(8));
                        bool estaPagado = reader.GetInt32(9) == 1;
                        Servicio servicio = new Servicio(id, duracion, costo, fecha, tipo, estaPagado);
                        cliente.Sevicios.Add(servicio);
                        clientes.Lista.Add(cliente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new RegistrosException("", ex);
            }
            return clientes;
        }
    }
}
