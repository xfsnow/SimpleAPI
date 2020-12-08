[![Board Status](https://dev.azure.com/netmyth/35f62c55-c965-454e-828f-efa2780290f3/e012162c-5415-4d27-9c54-b9ce51a86ba2/_apis/work/boardbadge/f22b3428-c4fa-4af2-9e32-f347c04d63f3)](https://dev.azure.com/netmyth/35f62c55-c965-454e-828f-efa2780290f3/_boards/board/t/e012162c-5415-4d27-9c54-b9ce51a86ba2/Microsoft.FeatureCategory/) 



# SimpleAPI
A simple project to show how to integrate .NET Web API with Azure DevOps.
This projects uses .NET Core 3.1.

I created a free Azure App Service instance with Windows.

A build pipeline with automatic tests is built and a release pipeline to deploy this .NET project to Azure App Service.


The URL of API in this project is /WeatherForecast/. Such as https://localhost:5001/WeatherForecast/ for local development. Some modern browsers may report unsecure website. Please just ignore the message and go on visiting. Or you may use other API test tools like Postman or simply use command line curl.

This project is integrated with Azure DevOps Boards.

Use AB#{ID} to link to Azure Boards work item, where {ID} is the ID of work item in the connected Azure Project.

Add Boards status badge in README.md.
