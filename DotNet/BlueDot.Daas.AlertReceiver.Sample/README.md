# BlueDot DaaS Alert Receiver Sample
This .Net Core 3.1 Blazor project demonstrates how to retrieve data from BlueDot DaaS notification service bus.

## Usage
1) Contact BlueDot to provide you with ConnectionString, Subscription, and Topic
2) Set the ConnectionString, Subscription, and Topic in appsettings.json
3) Simply run the project locally using Visual Studio or host the sample code on a web server that support .Net Core 3.1
4) This sample will display the Alert whenever BlueDot publish new one

## Note
The service bus could be invoked and listened to using many programming languages.