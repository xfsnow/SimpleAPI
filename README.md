# SimpleAPI
A simple project to show how to integrate .NET Web API with Azure DevOps.
This projects uses .NET Core 3.1.

I created a free Azure App Service instance with Windows.

A build pipeline with automatic tests is built and a release pipeline to deploy this .NET project to Azure App Service.


The URL of API in this project is /WeatherForecast/. Such as https://localhost:5001/WeatherForecast/ for local development. Some modern browsers may report unsecure website. Please just ignore the message and go on visiting. Or you may use other API test tools like Postman or simply use command line curl.

This project is integrated with Azure DevOps Boards.
