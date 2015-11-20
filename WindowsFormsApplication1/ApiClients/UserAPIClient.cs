using Newtonsoft.Json;
using Sonartez.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sonartez.Application.ApiClients
{
    class UserAPIClient
    {
        public static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:10539/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/users");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<User>>(jsonString);
                   
                }

                // HTTP POST
                //var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
                //response = await client.PostAsJsonAsync("api/products", gizmo);
                //if (response.IsSuccessStatusCode)
                //{
                //    Uri gizmoUrl = response.Headers.Location;

                //    // HTTP PUT
                //    gizmo.Price = 80;   // Update price
                //    response = await client.PutAsJsonAsync(gizmoUrl, gizmo);

                //    // HTTP DELETE
                //    response = await client.DeleteAsync(gizmoUrl);
                //}
            }
        }

        public static void Run()
        {
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:10539/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    // HTTP GET
            //    HttpResponseMessage response =  client.GetAsync("api/users");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var jsonString = await response.Content.ReadAsStringAsync();
            //        var list = JsonConvert.DeserializeObject<List<User>>(jsonString);

            //    }

            //    // HTTP POST
            //    //var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
            //    //response = await client.PostAsJsonAsync("api/products", gizmo);
            //    //if (response.IsSuccessStatusCode)
            //    //{
            //    //    Uri gizmoUrl = response.Headers.Location;

            //    //    // HTTP PUT
            //    //    gizmo.Price = 80;   // Update price
            //    //    response = await client.PutAsJsonAsync(gizmoUrl, gizmo);

            //    //    // HTTP DELETE
            //    //    response = await client.DeleteAsync(gizmoUrl);
            //    //}
            //}
        }
    }
}
