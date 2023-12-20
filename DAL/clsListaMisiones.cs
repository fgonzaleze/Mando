using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class clsListaMisiones
    {
        public static List<clsMision> listadoMisiones()
        {
            SqlConnection miConexion = new SqlConnection();
            List<clsMision> listadoMisiones = new List<clsMision>();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsMision mision;
            miConexion.ConnectionString = clsConnection.connection();
            try
            {
                miConexion.Open();
                miComando.CommandText = "SELECT * FROM Misiones";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        mision = new clsMision();

                        mision.Id = (int)miLector["ID"];
                        if (miLector["NombreMision"] != System.DBNull.Value)
                        {
                            mision.NombreMision = (string)miLector["NombreMision"];
                        }
                        if (miLector["DetallesMision"] != System.DBNull.Value)
                        {
                            mision.DetallesMision = (string)miLector["DetallesMision"];
                        }
                        mision.Creditos = (int)miLector["Creditos"];

                        listadoMisiones.Add(mision);
                    }
                }

                miLector.Close();
                miConexion.Close();
            }

            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listadoMisiones;

        }

        public static clsMision getMisionId(int id)
        {
            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsMision misionId = new clsMision();
            miConexion.ConnectionString = clsConnection.connection();

            try
            {
                miConexion.Open();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.CommandText = "SELECT * FROM Misiones WHERE ID=@id"; 
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    miLector.Read();
                    misionId.Id = (int)miLector["ID"];

                    misionId.Id = (int)miLector["ID"];
                    misionId.NombreMision = (string)miLector["NombreMision"];
                    misionId.DetallesMision = (string)miLector["DetallesMision"];
                    misionId.Creditos = (int)miLector["Creditos"];
                }
            miLector.Close();
            miConexion.Close();
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            return misionId;
        }

    }
}
