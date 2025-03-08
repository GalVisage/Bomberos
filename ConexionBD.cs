using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    class Conexion
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CuartelBomberosNoviembre2;Trusted_Connection=true";
        
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
    public class AreaABM
    {
        public DataTable ObtenerAreas()
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ID_area AS [ID area], Nombre_area AS [Nombre area]" +
                    "FROM Area", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void Agregararea(string area)
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Area (Nombre_area) VALUES(@Nombre_area)", con);
                cmd.Parameters.AddWithValue("@Nombre_area", area);
                cmd.ExecuteNonQuery();
            }
        }
        public void Eliminararea(int idArea)
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Area WHERE ID_area = @ID_area", con);
                cmd.Parameters.AddWithValue("@ID_area", idArea);
                cmd.ExecuteNonQuery();
            }

        }
        public void Modificararea(int idArea, string Nombrearea)
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Area SET Nombre_area = @Nombre_area WHERE ID_area = @ID_area", con);
                cmd.Parameters.AddWithValue("@Nombre_area", Nombrearea);
                cmd.Parameters.AddWithValue("@ID_area", idArea);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class VariablesGlobales
    {
        public static int IdArea { get; set; }
        public static string NombreArea { get; set; }
    }
}
