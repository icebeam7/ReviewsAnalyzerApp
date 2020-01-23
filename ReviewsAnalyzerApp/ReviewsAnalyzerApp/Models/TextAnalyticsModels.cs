namespace ReviewsAnalyzerApp.Models
{
    public class Document
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Language { get; set; }
    }

    public class DocumentResponse
    {
        public DocumentResult[] Documents { get; set; }
        public DocumentError[] Errors { get; set; }
        public DocumentStatistics Statistics { get; set; }
    }

    public class DocumentResult
    {
        public string Id { get; set; }
        public float Score { get; set; }
        public Statistics Statistics { get; set; }
    }

    public class Statistics
    {
        public int CharactersCount { get; set; }
        public int TransactionsCount { get; set; }
    }

    public class DocumentError
    {
        public string Code { get; set; }
        public InnerError InnerError { get; set; }
        public string Message { get; set; }
    }

    public class InnerError
    {
        public string RequestId { get; set; }
    }

    public class DocumentStatistics
    {
        public int DocumentsCount { get; set; }
        public int ValidDocumentsCount { get; set; }
        public int ErroneousDocumentsCount { get; set; }
        public int TransactionsCount { get; set; }
    }
}
