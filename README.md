# HelloSign .NET SDK Sample Application

## Sample App
This application is an example of how an app can integrate with the Hellosign .NET SDK to manage a system which manages contracts and users.

The app has two types of contracts:
1. EmploymentContract, which is created using a HelloSign template.
2. NDAContract, which is created without a template.

Once a contract is sent to a signer, an email is sent to the engineering team.

## SDK Integration
This application uses the HelloSign NuGet package for its access to the HelloSign API.