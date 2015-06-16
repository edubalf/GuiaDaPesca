using GuiaDaPesca.Services.Terceiros.Models;
using Newtonsoft.Json;
using System.Net;

namespace GuiaDaPesca.Services.Terceiros.Google
{
    public class GoogleMapsAPI
    {
        public GoogleGeocoding Geocoding(string endereco)
        {
            string urlGoogle = $"https://maps.googleapis.com/maps/api/geocode/json?address={ endereco }";
            string json = new WebClient().DownloadString(urlGoogle);

            return JsonConvert.DeserializeObject<GoogleGeocoding>(json);
        }
    }
}
