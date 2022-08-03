using System;
namespace Sample_App.model
{
    public class Signer
    {
        private string emailAddress { get; }
        private string name { get; }

        public Signer(string name, string emailAddress)
        {
            this.name = name;
            this.emailAddress = emailAddress;
        }
    }
}
