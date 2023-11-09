using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class ProductoService
    {
        public async Task<List<Producto>> GetProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (SqlCommand cmd = await DBConnectionHelper.getConnectedSqlCommand("SELECT * FROM PRODUCTO"))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync())
                {
                    while (sqlDataReader.Read())
                    {
                        Producto producto = new();
                        producto.ID_PRODUCTO = (int)sqlDataReader["ID_PRODUCTO"];
                        producto.NOMBRE = (string)sqlDataReader["NOMBRE"];
                        producto.TIPO_DISPONIBILIDAD = (string)sqlDataReader["TIPO_DISPONIBILIDAD"];
                        producto.ID_MARCA = (int)sqlDataReader["ID_MARCA"];
                        producto.ID_SUBCATEGORIA = (int)sqlDataReader["ID_SUBCATEGORIA"];

                        listaProductos.Add(producto);
                    }
                }
            }
            return listaProductos;
        }
    }
}
