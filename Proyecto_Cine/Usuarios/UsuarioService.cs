using Newtonsoft.Json;
using Proyecto_Cine.Logros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Usuarios
{
    public class UsuarioService
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl = "https://localhost:7091/api/Usuario";

        public UsuarioService()
        {
            _client = new HttpClient();
        }

        // =============================================
        // GET TODOS
        // =============================================
        public async Task<List<ModelUsuario>> ObtenerUsuarios()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl);
                if (!response.IsSuccessStatusCode)
                    return new List<ModelUsuario>();

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ModelUsuario>>(json)
                       ?? new List<ModelUsuario>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios: " + ex.Message);
                return new List<ModelUsuario>();
            }
        }

        // =============================================
        // GET POR ID
        // =============================================
        public async Task<ModelUsuario?> ObtenerPorId(int id)
        {
            try
            {
                var response = await _client.GetAsync($"{_baseUrl}/{id}");
                if (!response.IsSuccessStatusCode)
                    return null;

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ModelUsuario>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
                return null;
            }
        }

        // =============================================
        // POST
        // =============================================
        public async Task<bool> AgregarUsuario(ModelUsuario usuario)
        {
            try
            {
                var json = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(_baseUrl, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
                return false;
            }
        }

        // =============================================
        // PUT
        // =============================================
        public async Task<bool> ActualizarUsuario(int id, ModelUsuario usuario)
        {
            try
            {
                var json = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PutAsync($"{_baseUrl}/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                return false;
            }
        }

        // =============================================
        // DELETE
        // =============================================
        public async Task<bool> EliminarUsuario(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"{_baseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                return false;
            }
        }

        // =============================================
        // LOGIN
        // =============================================
        public async Task<ModelUsuario?> Login(string email, string password)
        {
            try
            {
                var usuarios = await ObtenerUsuarios();
                return usuarios.FirstOrDefault(u =>
                    u.Email == email &&
                    u.Password == password &&
                    u.Activo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en login: " + ex.Message);
                return null;
            }
        }
    }
}
