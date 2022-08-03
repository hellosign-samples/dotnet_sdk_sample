using System;
using HelloSign;
using System.Collections.Generic;

namespace Sample_App
{
    public class NDASignatureRequest
    {
        private Client client;
        private const string NDA_TITLE = "Intellectual Property Sharing Agreement";
        private const string NDA_SUBJECT = "IP Sharing Agreement for Our Project";
        private const string NDA_MESSAGE = "Please review this agreement that we discussed in our last team meeting.  If we need to discuss further, you can decline.";
        private const string LEGAL_EMAIL_ADDRESS = "lawyer@lawfirm.com";
        public NDASignatureRequest(Client client)
        {
            this.client = client;
        }

        public SignatureRequest sendRequest(List<string> filePaths, List<Signer> signers)
        {
            var request = new SignatureRequest();
            request.TestMode = true;
            request.Title = NDA_TITLE;
            request.Subject = NDA_SUBJECT;
            request.Message = NDA_MESSAGE;
            request.AddCc(LEGAL_EMAIL_ADDRESS);
            request.AllowDecline = true;

            foreach (Signer signer in signers)
            {
                request.AddSigner(signer.EmailAddress, signer.Name);
            }

            foreach (var file in filePaths)
            {
                request.AddCc(file);
            }
            return client.SendSignatureRequest(request);
        }
    }
}
