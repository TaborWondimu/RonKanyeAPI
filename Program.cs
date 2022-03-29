using Newtonsoft.Json.Linq;
using System;
namespace RonKanyeAPI
{
    class program
    {
        public static void Main(string[] args)
        {
            var client = new HttpClient();
            for (int i = 0; i < 5; i++)
            {
                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var KanyeURL = "https://api.kanye.rest";

                var ronResponse = client.GetStringAsync(ronURL).Result;
                var kanyeResponse = client.GetStringAsync(KanyeURL).Result;

                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                Console.WriteLine($"Kanye talking: {kanyeQuote} ");
                Console.WriteLine($"Ron talking: { ronQuote} ");    


            }


        }
    }
}