using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosComentario
    {
        public List<Entidades.Comentario> GetComentarios()
        {
            List<Entidades.Comentario> lstComent = new List<Entidades.Comentario>();

            HttpClient httpcliente = new HttpClient();
            httpcliente.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/comments");
            HttpResponseMessage respons = httpcliente.GetAsync("").Result;

            if (respons.IsSuccessStatusCode)
            {
                var objects = respons.Content.ReadAsStringAsync();

                lstComent = JsonConvert.DeserializeObject<List<Entidades.Comentario>>(objects.Result);

            }
            return lstComent;
        }

        public List<Entidades.Comentario> GetComentarios(int FotoId)
        {
            List<Entidades.Comentario> lstComent = new List<Entidades.Comentario>();

            HttpClient httpcliente = new HttpClient();
            httpcliente.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/comments");
            HttpResponseMessage respons = httpcliente.GetAsync("").Result;

            if (respons.IsSuccessStatusCode)
            {
                var objects = respons.Content.ReadAsStringAsync();

                lstComent = JsonConvert.DeserializeObject<List<Entidades.Comentario>>(objects.Result);

            }
            return lstComent.Where(x=>x.PostId==FotoId).ToList();
        }
    }
}
