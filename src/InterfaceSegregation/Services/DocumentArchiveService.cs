namespace InterfaceSegregation.Services
{
    using System;
    using InterfaceSegregation.Contracts;
    using InterfaceSegregation.Models;

    public sealed class DocumentArchiveService
    {
        private readonly IScannableDevice _scanner;

        public DocumentArchiveService(IScannableDevice scanner)
        {
            _scanner = scanner;
        }

        public void ArchiveSignedCopy(Document document)
        {
            var scannedDocument = _scanner.Scan(document);
            Console.WriteLine($"  Archived {scannedDocument.ReferenceNumber} from {scannedDocument.StoragePath}.");
        }
    }
}
