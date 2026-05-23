using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Recompensas
{
    public class RecompensasService
    {

        private readonly string url = "https://localhost:7115/api/Recompensas";

        HttpClient client = new HttpClient();

        // GET BY ID
        public async Task<ModelRecompensas?> ObtenerPorId(int id)
        {
            try
            {
                var response = await client.GetAsync($"{url}/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<ModelRecompensas>(json);
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);

                return null;
            }
        }

        // GET
        public async Task<List<ModelRecompensas>> ObtenerRecompensas()
        {
            try
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<ModelRecompensas>>(json)
                           ?? new List<ModelRecompensas>();
                }

                return new List<ModelRecompensas>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
                return new List<ModelRecompensas>();
            }
        }

        // POST
        public async Task<bool> AgregarRecompensa(ModelRecompensas recompensa)
        {
            try
            {
                var json = JsonConvert.SerializeObject(recompensa);

                var contenido = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, contenido);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                return false;
            }
        }

        // PUT
        public async Task<bool> ActualizarRecompensa(int id, ModelRecompensas recompensa)
        {
            try
            {
                var json = JsonConvert.SerializeObject(recompensa);

                var contenido = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{url}/{id}", contenido);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
        }

        // DELETE
        public async Task<bool> EliminarRecompensa(int id)
        {
            try
            {
                var response = await client.DeleteAsync($"{url}/{id}");

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }
    }
}