namespace InterfaceSegregation.Models
{
    public sealed class ScannedDocument
    {
        public ScannedDocument(string referenceNumber, string storagePath)
        {
            ReferenceNumber = referenceNumber;
            StoragePath = storagePath;
        }

        public string ReferenceNumber { get; }
        public string StoragePath { get; }
    }
}
