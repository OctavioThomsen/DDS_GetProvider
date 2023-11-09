using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class ModeloService
    {
        public async Task<List<Modelo>> GetModelos()
        {
            List<Modelo> listaModelos = new List<Modelo>();

            using (SqlCommand cmd = await DBConnectionHelper.getConnectedSqlCommand("SELECT * FROM MODELO"))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync())
                {
                    while (sqlDataReader.Read())
                    {
                        Modelo modelo = new();
                        modelo.ID_MODELO = (int)sqlDataReader["ID_MODELO"];
                        modelo.NOMBRE = (string)sqlDataReader["NOMBRE"];

                        listaModelos.Add(modelo);
                    }
                }
            }
            return listaModelos;
        }
    }
}
