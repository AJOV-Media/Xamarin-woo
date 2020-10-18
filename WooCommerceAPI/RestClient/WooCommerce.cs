using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerceAPI.RestClient
{
    class WooCommerce<T>
    {
        private const string WooApiURL = "https://woocommerce.local:8091/";
        private const string JsonVersionPath = "wp-json/wc/v3";
        private const string ProductPath = "/products?";
        private const string ConsumerKey = "ck_e69ffab389c5ab9957b0f3e67a0398047f9d62d9";
        private const string ConsumerSecret = "cs_30d030a4f3d6a1e132a9b0bdb8fc35f0b81171c7";
        HttpClient _httpClient = new HttpClient();

        public async Task<T> GetAllProducts(int perpage)
        {
            var json = await _httpClient.GetStringAsync(WooApiURL + JsonVersionPath + ProductPath + "page=" + perpage + "&consumer_key=" + ConsumerKey + "&consumer_secret=" + ConsumerSecret);
            var getProductModels = JsonConvert.DeserializeObject<T>(json);
            return getProductModels;
        }
    }
}
