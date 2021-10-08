# BlueDot DaaS Client Sample
This .Net Core 3.1 Web api project demonstrates how to retrieve data from BlueDot DaaS api following the OAuth 2.0 protocol.
The Web api has one controller "Sample" with one GET method that gets the list of diseases supported by BlueDot DaaS.

## Getting the bearer token
The Startup.cs has the code that adds the named HttpClient (responsible for the communications with BlueDot DaaS) to the DI.
There it retrieves the access token from BlueDot token authority and sets the HTTP Authorization header of every request.
Communicating with the token authority is aided by the [Identity Model](https://www.nuget.org/packages/IdentityModel) package.
On every request it also adds the "Ocp-Apim-Subscription-Key" header the value is a unique key generated for every customer subscription.

## Calling BlueDot DaaS
The Sample controller uses the injected "BluedotDaasService" service to call DaaS disease lookup endpoint, 
it is a straight forward GET call since all the plumbing for OAuth and Subscription keys is done by the middleware. 

## Settings
The following settings are required to run this sample (please contact BlueDot support or your account manager to get the test values):
1. TokenAuthority: BlueDot auth service URL.
2. ClientId OAuth2.0 ClientId for the sample api.
3. ClientSecret OAuth2.0 Client Secret for the sample api.
4. Scope: The DaaS api scope
5. SubscriptionKey: Key can be generates using the developer portal or contact BlueDot support.
6. DiseaseLookupUrl: Relative URL for DaaS disease lookup endpoint

## Usage
Simply run the project locally using Visual Studio, the launch URL is set to "sample", this will navigate to the GET disease endpoint.