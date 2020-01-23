using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

using ReviewsAnalyzerApp.Models;
using ReviewsAnalyzerApp.Helpers;

using Newtonsoft.Json;

namespace ReviewsAnalyzerApp.Services
{
    public static class TextAnalyticsService
    {
        private static readonly HttpClient client = CreateHttpClient();

        public async static Task<List<Review>> AnalyzeText(List<Review> reviews)
        {
            try
            {
                var documents = PrepareRequest(reviews);

                var content = new StringContent(documents);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var serviceUrl = $"{Constants.SentimentService}?{Constants.SentimentParameters}";
                var response = await client.PostAsync(serviceUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<DocumentResponse>(json);

                    var newReviews = ProcessResult(result, reviews);
                    return newReviews;
                }
            }
            catch (Exception ex)
            {
            }

            return default(List<Review>);
        }

        private static HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Constants.TextAnalyticsEndpoint);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        private static string PrepareRequest(List<Review> reviews)
        {
            var documents = new List<Document>();

            foreach (var review in reviews)
            {
                documents.Add(new Document()
                {
                    Id = review.Id.ToString(),
                    Text = review.Text,
                    Language = review.Language
                });
            }

            return JsonConvert.SerializeObject(new { documents = documents });
        }

        private static List<Review> ProcessResult(DocumentResponse response, List<Review> reviews)
        {
            var newReviews = new List<Review>();

            foreach (var document in response.Documents)
            {
                var review = reviews.SingleOrDefault(x => x.Id == int.Parse(document.Id));

                if (review != null)
                {
                    var newReview = new Review(review);
                    newReview.Score = document.Score * 100;

                    newReviews.Add(newReview);
                }
            }

            return newReviews;
        }
    }
}
