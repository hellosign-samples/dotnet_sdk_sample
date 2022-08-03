using System;
using HelloSign;

namespace Sample_App
{
    public class ExpenseSignatureRequest
    {
        private Client client;
        private const string EXPENSE_TEMPLATE_ID = "UHD7347DHF873HDJ83UDHDJ3";

        public ExpenseSignatureRequest(Client client)
        {
            this.client = client;
        }

        public BaseSignatureRequest send()
        {
            var templateRequest = new TemplateSignatureRequest();
            templateRequest.AddTemplate(EXPENSE_TEMPLATE_ID);
            templateRequest.Subject = "Expense Sharing Agreement";
            templateRequest.Message = "A standard agreement for dividing business expenses.";
            templateRequest.AddSigner("Designer", "george@example.com", "George");
            templateRequest.AddSigner("Developer", "bess@example.com", "Bess");
            templateRequest.TestMode = true;
            return client.SendSignatureRequest(templateRequest);
        }
    }
}
