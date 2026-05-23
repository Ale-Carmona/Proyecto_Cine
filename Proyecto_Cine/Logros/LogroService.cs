using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Logros
{
    public class LogroService
    {
        private readonly HttpClient _httpClient;

        private readonly string baseUrl = "https://localhost:7166/api/Logro";

        public LogroService()
        {
            _httpClient = new HttpClient();
        }

        // =========================================
        // OBTENER TODOS LOS LOGROS
        // =========================================
        public async Task<List<ModelLogro>> ObtenerLogros()
        {
            var response = await _httpClient.GetAsync(baseUrl);

            if (!response.IsSuccessStatusCode)
                return new List<ModelLogro>();

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ModelLogro>>(json)!;
        }

        // =========================================
        // AGREGAR LOGRO
        // =========================================
        public async Task<bool> AgregarLogro(ModelLogro logro)
        {
            var json = JsonConvert.SerializeObject(logro);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync(baseUrl, content);

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // ACTUALIZAR LOGRO
        // =========================================
        public async Task<bool> ActualizarLogro(int id, ModelLogro logro)
        {
            var json = JsonConvert.SerializeObject(logro);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PutAsync(
                $"{baseUrl}/{id}",
                content
            );

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // ELIMINAR LOGRO
        // =========================================
        public async Task<bool> EliminarLogro(int id)
        {
            var response = await _httpClient.DeleteAsync(
                $"{baseUrl}/{id}"
            );

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // ASIGNAR LOGRO A USUARIO
        // =========================================
        public async Task<bool> AsignarLogro(ModelUsuario logroUsuario)
        {
            var json = JsonConvert.SerializeObject(logroUsuario);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync(
                $"{baseUrl}/Asignar",
                content
            );

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // OBTENER LOGROS DE USUARIO
        // =========================================
        public async Task<List<ModelUsuario>> ObtenerLogrosUsuario()
        {
            var response = await _httpClient.GetAsync(
                $"{baseUrl}/Usuarios"
            );

            if (!response.IsSuccessStatusCode)
                return new List<ModelUsuario>();

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ModelUsuario>>(json)!;
        }
    }
}