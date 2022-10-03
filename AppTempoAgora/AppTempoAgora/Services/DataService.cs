using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppTempoAgora.Model;

namespace AppTempoAgora.Services
{
    class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo (string cidade)
        {
            string appId = "6ca829fba8a5212cc4dfdf1dea427374";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;
            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            if (resultado["wheather"] != null)
            {
                Tempo previsao = new Tempo();
                previsao.Title = (string) resultado["name"];
                previsao.Temperature
            }
        }

    }
}