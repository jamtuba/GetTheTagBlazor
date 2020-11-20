using GetTheTagBlazor.Shared.ModelsDTO;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GetTheTagBlazor.Client.Helpers
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TagDTO> Get<T>(string url)
        {
            string funcUrl = "https://uss-exam-func-app.azurewebsites.net/api/HttpTriggerGetTheTag";

            _httpClient.BaseAddress = new Uri(funcUrl);

            
            
            var result = await _httpClient.PostAsJsonAsync("?code=7szykiYv4e1TQd2iPD3WpYNUaCroMMcwIqi2XhUfQ7Zdq2aa67MS1w==", url);

            //responseTask.Headers.Add("url", url);

            //responseTask.EnsureSuccessStatusCode();

            //    string responseBody = await responseTask.Content. ReadAsStringAsync();

            
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://uss-exam-function-app.azurewebsites.net/api/HttpTriggerGetTheTag?");
            //var headerResult = responseTask.Headers.TryAddWithoutValidation("url", url);

            //Console.WriteLine("HeaderResult: " + headerResult);

            //    using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);



            //if (responseTask.IsSuccessStatusCode)
            //{
            //    // perhaps check some headers before deserialising

            //    try
            //    {
            //        return await _httpClient.GetFromJsonAsync<TagDTO>(funcUrl + "?code=d6cCQ3R5adtFUSI7lcwUT8zBX/hrAC9K4gYyWUlOthQyPahyEZUyrg==");
            //    }
            //    catch (NotSupportedException) // When content type is not valid
            //    {
            //        Console.WriteLine("The content type is not supported.");
            //    }
            //    catch (JsonException) // Invalid JSON
            //    {
            //        Console.WriteLine("Invalid JSON.");
            //    }
            //}

            return null;

            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create("function-url");
            //req.Method = "POST";
            //req.ContentType = "application/json";
            //Stream stream = req.GetRequestStream();
            //string json = "{\"name\": \"Azure\" }";
            //byte[] buffer = Encoding.UTF8.GetBytes(json);
            //stream.Write(buffer, 0, buffer.Length);
            //HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            //var responseHTTP = await _httpClient.GetAsync(url);

            //if (responseHTTP.IsSuccessStatusCode)
            //{
            //    var response = await Deserialize<T>(responseHTTP, DefaultJsonSerializerOptions);
            //    return new HttpResponseWrapper<T>(response, true, responseHTTP);
            //}
            //else
            //{
            //    return new HttpResponseWrapper<T>(default, false, responseHTTP);
            //}
        }
    }
}
