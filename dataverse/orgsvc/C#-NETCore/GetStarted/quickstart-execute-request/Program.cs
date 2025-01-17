﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;

class Program
{
    // TODO Enter your Dataverse environment's URL and logon info.
    static string url = "https://yourorg.crm.dynamics.com";
    static string userName = "you@yourorg.onmicrosoft.com";
    static string password = "yourPassword";

    // This service connection string uses the info provided above.
    // The AppId and RedirectUri are provided for sample code testing.
    static string connectionString = $@"
    AuthType = OAuth;
    Url = {url};
    UserName = {userName};
    Password = {password};
    AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
    RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
    LoginPrompt=Auto;
    RequireNewInstance = True";

    static void Main()
    {
        //ServiceClient implements IOrganizationService interface
        IOrganizationService service = new ServiceClient(connectionString);

        var response = (WhoAmIResponse)service.Execute(new WhoAmIRequest());

        Console.WriteLine($"User ID is {response.UserId}.");


        // Pause the console so it does not close.
        Console.WriteLine("Press the <Enter> key to exit.");
        Console.ReadLine();
    }
}