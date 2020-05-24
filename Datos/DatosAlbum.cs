using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosAlbum
    {

        public List<Entidades.Album> GetAlbunes()
        {
            List<Entidades.Album> lstAlbums = new List<Entidades.Album>();

            HttpClient httpcliente = new HttpClient();
            httpcliente.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/albums");
            HttpResponseMessage respons = httpcliente.GetAsync("").Result;

            if(respons.IsSuccessStatusCode)
            {
                var objects = respons.Content.ReadAsStringAsync();

                lstAlbums = JsonConvert.DeserializeObject<List<Entidades.Album>>(objects.Result);

            }
            return lstAlbums;
        }
    }
}
