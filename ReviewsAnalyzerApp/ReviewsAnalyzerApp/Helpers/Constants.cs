namespace ReviewsAnalyzerApp.Helpers
{
    public static class Constants
    {
        public static readonly string TextAnalyticsEndpoint = "http://192.168.99.102:5000/";
        public static readonly string SentimentService = "text/analytics/v2.0/sentiment";
        public static readonly string SentimentParameters = "showStats=true";
    }
}
