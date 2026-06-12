namespace InterfaceSegregation.Models
{
    public sealed class Document
    {
        public Document(string referenceNumber, string content)
        {
            ReferenceNumber = referenceNumber;
            Content = content;
        }

        public string ReferenceNumber { get; }
        public string Content { get; }
    }
}
