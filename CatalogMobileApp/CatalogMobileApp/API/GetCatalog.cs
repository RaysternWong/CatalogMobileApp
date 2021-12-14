using CatalogMobileApp.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogMobileApp.API
{
    public class GetCatalog
    {
        private string Url { get; set; } = "https://mangomart-autocount.myboostorder.com/wp-json/wc/v1/products";

        private string AuthName { get; set; } = "ck_2682b35c4d9a8b6b6effac126ac552e0bfb315a0";

        private string AuthPassword { get; set; } = "cs_cab8c9a729dfb49c50ce801a9ea41b577c00ad71";

        private const string TotalPageHeader = "X-WP-TotalPages";
        private const string TotalItemHeader = "X-WP-Total";

        public GetCatalog()
        {

        }


        public List<Catalog> GetAllCatalogs()
        {
            List<Catalog> catalogs = new List<Catalog>();
            int page = 1;

            var response = GetResponseByPage(page);
            int totalPage = Convert.ToInt32(response.Headers.Where(x => x.Name == TotalPageHeader)
                            .Select(x => x.Value)
                            .FirstOrDefault());

            int totalItem = Convert.ToInt32(response.Headers.Where(x => x.Name == TotalItemHeader)
                            .Select(x => x.Value)
                            .FirstOrDefault());

            catalogs = JsonConvert.DeserializeObject<List<Catalog>>(response.Content);

            while (page < totalPage)
            {
                page++;
                catalogs.AddRange(GetCatalogByPage(page));
            }

            //if(catalogs.Count < totalItem)
            //{
            //   log Error
            //}

            return catalogs;
        }

        private IRestResponse GetResponseByPage(int page)
        {
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(AuthName, AuthPassword);

            var request = new RestRequest(Method.GET);
            request.AddParameter("page", page);

            try
            {
                var response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private List<Catalog> GetCatalogByPage(int page)
        {
            List<Catalog> catalogs = new List<Catalog>();
            string content;
            try
            {
                var response = GetResponseByPage(page);
                content = response.Content;
                catalogs = JsonConvert.DeserializeObject<List<Catalog>>(response.Content);

            }
            catch (Exception ex)
            {

            }
            return catalogs;
        }

    }
}
