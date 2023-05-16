using System;
using System.Net.Http;
using System.Text;

namespace burger
{
  public class MyClass
  {
    public static string merchantApiHost = "https://merchant-api.ifood.com.br";
    public static string merchantId = "bd41628b-6b9d-46df-ad63-22dbe0ce72ed";
    public static string grantType = "client_credentials";
    public static string clientId = "4280448a-2372-4692-8e26-3d5c80fa6555";
    public static string clientSecret = "fuh3ymbw4qvsw2waki12y07p1abo10lgsuufq7x900qmjzn4f157v8r1vvpig9yz53iij4e9fdlu6g9q0qss2r6zq5k1u8n0i7e";
    public static string Autoriza()
    {
      using (HttpClient client = new HttpClient())
      {
        var requestBody = new
        {
          grantType = grantType,
          clientId = clientId,
          clientSecret = clientSecret
        };
        // Serialize o corpo da solicitação para JSON
        var jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        var response = client.PostAsync($"{merchantApiHost}/authentication/v1.0/oauth/token", content).Result;
        if (response.IsSuccessStatusCode)
        {
          var respbody = response.Content.ReadAsStringAsync().Result;
          return respbody;
        }
        else
        {
          return "A solicitação falhou com o código de status: " + response.StatusCode;
        }
      }
    }
    public static string GetAccessToken()
    {
      string url = "https://merchant-api.ifood.com.br/authentication/v1.0/oauth/token";
      using (HttpClient client = new HttpClient())
      {
        var data = new StringBuilder();
        data.Append("grantType=" + Uri.EscapeDataString(grantType));
        data.Append("&clientId=" + Uri.EscapeDataString(clientId));
        data.Append("&clientSecret=" + Uri.EscapeDataString(clientSecret));
        data.Append("&authorizationCode=");
        data.Append("&authorizationCodeVerifier=");
        data.Append("&refreshToken=");
        var content = new StringContent(data.ToString(), Encoding.UTF8, "application/x-www-form-urlencoded");
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url),
          Content = content
        };
        request.Headers.Add("accept", "application/json");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string GetMerchantStatus(string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/merchant/v1.0/merchants/bd41628b-6b9d-46df-ad63-22dbe0ce72ed/status";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Get,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string Polling(string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/events:polling?types=PLC%2CREC%2CCFM&groups=ORDER_STATUS%2CDELIVERY";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Get,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string AcknowledgeEvent(string accessToken, string jsonData)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/events/acknowledgment";
      using (HttpClient client = new HttpClient())
      {
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url),
          Content = content
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "*/*");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string DetalhesPedido(string pedidoId, string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/orders/" + pedidoId;

      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Get,
          RequestUri = new Uri(url)
        };

        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "application/json");

        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();

        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string ConfirmarPedido(string pedidoId, string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/orders/" + pedidoId + "/confirm";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "*/*");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string PrepararPedido(string pedidoId, string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/orders/" + pedidoId + "/startPreparation";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "*/*");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string ProntoPedido(string pedidoId, string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/orders/" + pedidoId + "/readyToPickup";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "*/*");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
    public static string EntregarPedido(string pedidoId, string accessToken)
    {
      string url = "https://merchant-api.ifood.com.br/order/v1.0/orders/" + pedidoId + "/dispatch";
      using (HttpClient client = new HttpClient())
      {
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Post,
          RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Headers.Add("accept", "*/*");
        HttpResponseMessage response = client.SendAsync(request).Result;
        response.EnsureSuccessStatusCode();
        string result = response.Content.ReadAsStringAsync().Result;
        return result;
      }
    }
  }
}
