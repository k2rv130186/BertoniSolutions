using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosFoto
    {
        public List<Entidades.Fotos> GetFotos()
        {
            List<Entidades.Fotos> lstFotos = new List<Entidades.Fotos>();

            HttpClient httpcliente = new HttpClient();
            httpcliente.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/photos");
            HttpResponseMessage respons = httpcliente.GetAsync("").Result;

            if (respons.IsSuccessStatusCode)
            {
                var objects = respons.Content.ReadAsStringAsync();

                lstFotos = JsonConvert.DeserializeObject<List<Entidades.Fotos>>(objects.Result);

            }
            return lstFotos;
        }


        public List<Entidades.Fotos> GetFotos(int AlbumId)
        {
            List<Entidades.Fotos> lstFotos = new List<Entidades.Fotos>();

            HttpClient httpcliente = new HttpClient();
            httpcliente.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/photos");
            HttpResponseMessage respons = httpcliente.GetAsync("").Result;

            if (respons.IsSuccessStatusCode)
            {
                var objects = respons.Content.ReadAsStringAsync();

                lstFotos = JsonConvert.DeserializeObject<List<Entidades.Fotos>>(objects.Result);

            }
            return lstFotos.Where(x=> x.AlbumId==AlbumId).ToList();
        }

    }
}
