using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class MarcaService
    {
        public async Task<List<Marca>> GetMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();

            using (SqlCommand cmd = await DBConnectionHelper.getConnectedSqlCommand("SELECT * FROM MARCA"))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync())
                {
                    while (sqlDataReader.Read())
                    {
                        Marca marca = new();
                        marca.ID_MARCA = (int)sqlDataReader["ID_MARCA"];
                        marca.NOMBRE = (string)sqlDataReader["NOMBRE"];

                        listaMarcas.Add(marca);
                    }
                }
            }
            return listaMarcas;
        }
    }
}
