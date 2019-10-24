using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace CrewPocket
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Book>> GetBooksAsync(string uri)
        {
            List<Book> books = null;
            try
            {
                HttpResponseMessage respons = await _client.GetAsync(uri);
                if (respons.IsSuccessStatusCode)
                {
                    string content = await respons.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<List<Book>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }
            return books;
        }

        public async Task<List<Video>> GetVideosAsync(string uri)
        {
            List<Video> videos = null;
            try
            {
                HttpResponseMessage respons = await _client.GetAsync(uri);
                if (respons.IsSuccessStatusCode)
                {
                    string content = await respons.Content.ReadAsStringAsync();
                    videos = JsonConvert.DeserializeObject<List<Video>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}" , ex.Message);
            }
            return videos;
        }

        public async Task<List<Paper>> GetPapersAsync(string uri)
        {
            List<Paper> papers = null;
            try
            {
                HttpResponseMessage respons = await _client.GetAsync(uri);
                if (respons.IsSuccessStatusCode)
                {
                    string content = await respons.Content.ReadAsStringAsync();
                    papers = JsonConvert.DeserializeObject<List<Paper>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }
            return papers;
        }
    }
}
