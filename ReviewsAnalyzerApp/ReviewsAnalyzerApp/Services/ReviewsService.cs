using System.Threading.Tasks;
using System.Collections.Generic;

using ReviewsAnalyzerApp.Models;

namespace ReviewsAnalyzerApp.Services
{
    public static class ReviewsService
    {
        public async static Task<List<Review>> GetReviews()
        {
            return new List<Review>()
            {
                new Review() { Id = 1, Customer = "Anne S.", Language = "de", Rating = 1, Text = "Diese Kamera hat keinen Mittelkontakt mehr für Blitze von vielen Drittanbietern! Ich kann deswegen nur von dieser Kamera abraten." },
                new Review() { Id = 2, Customer = "Juan S.", Language = "es", Rating = 5, Text = "Es una cámara muy buena, tiene una calidad muy alta, tiene acceso a los lentes intercambiables, creo que de las réflex de sensor pequeño ésta es la mejor; en relación calidad - precio, no tiene comparación." },
                new Review() { Id = 3, Customer = "Luis B.", Language = "en", Rating = 3, Text = "I am having some issues when using your product. It doesn't work at all." },
                new Review() { Id = 4, Customer = "Michal R.", Language = "en", Rating = 2, Text = "It was a bit expensive." },
                new Review() { Id = 5, Customer = "Robert F.", Language = "en", Rating = 4, Text = "I think your product is amazing!!!" },
            };
        }
    }
}
