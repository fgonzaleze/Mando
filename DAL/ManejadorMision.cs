using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ManejadorMision
    {
        public static int deleteMision(int id)
        {
            int numFilas = 0;
            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            miConexion.ConnectionString = clsConnection.connection();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                miConexion.Open();
                miComando.CommandText = "DELETE FROM Misiones WHERE ID = @id";
                miComando.Connection = miConexion;
                numFilas = miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numFilas;
        }

        public static int editMision(clsMision mision)
        {
            int numFilas = 0;
            SqlCommand miComando = new SqlCommand();
            SqlConnection miConexion = new SqlConnection();
            miConexion.ConnectionString = clsConnection.connection();

            try
            {
                miConexion.Open();
                miComando.CommandText = "UPDATE Misiones" +
                    "SET NombreMision = @NombreMision, " +
                    "DetallesMision = @DetallesMision, " +
                    "Creditos = @Creditos, " +
                    "WHERE ID=@id";
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = mision.Id;
                miComando.Parameters.Add("@NombreMision", System.Data.SqlDbType.VarChar).Value = mision.NombreMision;
                miComando.Parameters.Add("@DetallesMision", System.Data.SqlDbType.VarChar).Value = mision.DetallesMision;
                miComando.Parameters.Add("@Creditos", System.Data.SqlDbType.Date).Value = mision.Creditos;

                miComando.Connection = miConexion;
                numFilas = miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return numFilas;

        }

        public static int createMision(clsMision mision)
        {
            int numFilas = 0;

            SqlCommand miComando = new SqlCommand();

            SqlConnection miConexion = new SqlConnection();

            miConexion.ConnectionString = clsConnection.connection();

            try

            {
                miConexion.Open();
                miComando.CommandText = "INSERT INTO Misiones (Id, NombreMision, DetallesMision, Creditos)"
                    + "VALUES (@Id, @NombreMision, @DetallesMision, @Creditos)";
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = mision.Id;
                miComando.Parameters.Add("@NombreMision", System.Data.SqlDbType.VarChar).Value = mision.NombreMision;
                miComando.Parameters.Add("@DetallesMision", System.Data.SqlDbType.VarChar).Value = mision.DetallesMision;
                miComando.Parameters.Add("@Creditos", System.Data.SqlDbType.Date).Value = mision.Creditos;

                miComando.Connection = miConexion;
                numFilas = miComando.ExecuteNonQuery();
            }

            catch (Exception ex)

            {
                throw ex;

            }

            return numFilas;

        }


    }
}
