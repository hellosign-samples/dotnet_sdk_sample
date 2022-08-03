using System;
using HelloSign;
namespace Sample_App
{
    public class IPSignatureRequest
    {
        private Client client;

        public IPSignatureRequest(Client client)
        {
            this.client = client;
        }

        public SignatureRequest send()
        {
            var request = new SignatureRequest();
            request.TestMode = true;
            request.Title = "Intellectual Property Sharing Agreement";
            request.Subject = "IP Sharing Agreement for Our Project";
            request.Message = "Please review this agreement that we discussed in our last team meeting.  If we need to discuss further, you can decline.";
            request.AddSigner("pat@example.com", "Pat");
            request.AddSigner("sam@example.com", "Sam");
            request.AddCc("lawyer@lawfirm.com");
            request.AddFile("C:\\Users\\Me\\My Documents\\IP Agreement.pdf");
            request.AddFile("C:\\Users\\Me\\My Documents\\AppendixA.pdf");
            request.AllowDecline = true;
            return client.SendSignatureRequest(request);
        }
    }
}
