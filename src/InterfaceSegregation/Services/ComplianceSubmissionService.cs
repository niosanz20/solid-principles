namespace InterfaceSegregation.Services
{
    using InterfaceSegregation.Contracts;
    using InterfaceSegregation.Models;

    public sealed class ComplianceSubmissionService
    {
        private readonly IFaxDevice _faxDevice;

        public ComplianceSubmissionService(IFaxDevice faxDevice)
        {
            _faxDevice = faxDevice;
        }

        public void Submit(Document document, string regulatorFaxNumber)
        {
            _faxDevice.SendFax(document, regulatorFaxNumber);
        }
    }
}
