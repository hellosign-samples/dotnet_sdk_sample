using System;
using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;
using Sample_App.model;

namespace Sample_App.client
{
    public class HelloSignClient
    {
        private SignatureRequestApi SignatureRequestApi;
        public HelloSignClient(Configuration config)
        {
            this.SignatureRequestApi = new SignatureRequestApi(config);
        }

        public BaseContract sendContract(BaseContract contract)
        {
            if (contract.HasTemplate())
            {
                return sendTemplateContract(contract);
            }
            else
            {
                return sendBasicContract(contract);
            }
        }

        private BaseContract sendBasicContract(BaseContract contract)
        {
            var response = SignatureRequestApi.SignatureRequestSend((SignatureRequestSendRequest)contract.GetSignatureRequest());
            contract.contractId = response.SignatureRequest.SignatureRequestId;
            EmailClient.sendEmail(contract.GetSentEmail());
            return contract;
        }

        private BaseContract sendTemplateContract(BaseContract contract)
        {
            var response = SignatureRequestApi.SignatureRequestSendWithTemplate((SignatureRequestSendWithTemplateRequest)contract.GetSignatureRequest()); //.SignatureRequestSend((SignatureRequestSendRequest)contract.GetSignatureRequest());
            contract.contractId = response.SignatureRequest.SignatureRequestId;
            EmailClient.sendEmail(contract.GetSentEmail());
            return contract;
        }
    }
}
