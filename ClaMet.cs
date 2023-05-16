using Newtonsoft.Json;
using System.Net.Http;

namespace burger
{
  public class Apis
  {
    public static Endereco ConsultarCep(string cep)
    {
      using (var client = new HttpClient())
      {
        var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
        var content = response.Content.ReadAsStringAsync().Result;
        var result = JsonConvert.DeserializeObject<Endereco>(content);       
        return result;
      }
    }
  }
}
