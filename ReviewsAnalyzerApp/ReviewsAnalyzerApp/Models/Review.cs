namespace ReviewsAnalyzerApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Text { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }

        public float Score { get; set; }

        public Review(Review r)
        {
            this.Id = r.Id;
            this.Customer = r.Customer;
            this.Text = r.Text;
            this.Language = r.Language;
            this.Rating = r.Rating;
            this.Score = r.Score;
        }

        public Review()
        {

        }
    }
}
