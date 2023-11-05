# _Pierres Sweet and Savory Treats_

#### By _**Brandon Wright**_

#### _A deceptively simple many-to-many realational database management web app with authentication._

## Technologies Used

* _C#_
* _.NET_
* _ASP.NET Core MVC_
* _Razor Pages_
* _Identity_
* _Entity Framework Core_
* _HTML_
* _CSS_
* _Git_

## Description

_An awesome web application for managing the sweet and asavory treats of pierre's Bakery with authentication._

## Setup/Installation Requirements

Note: An installation of the .NET SDK is required in order to run this application locally. See [Here](https://dotnet.microsoft.com/en-us/) for installation.

1. Copy project directory or clone repo from Github (https://github.com/brandonfullstack/PierresSweetAndSavoryTreats.Solution) to your desktop.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Bakery".
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. Replace the database value with the name that you wish to give the database that will back up this application. Entity will create the `database` for you in a subsequent step.

    ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
      }
    }
    ```

5. Run `$ dotnet ef database update`. This command will create the database and required tables on your local treat.
6. Navigate to the project directory: `$ cd Bakery`
7. In the command line, run the command `$ dotnet watch run` to compile and execute the web application. Since this is a web application, you'll interact with it through the UI in your browser.
8. Open the browser at: https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* _No known issues_
* _Please visit this projects [GitHub repository](https://github.com/brandonfullstack/PierresSweetAndSavoryTreats.Solution) to submit Issues and Pull Requests._

## License

_[MIT](https://choosealicense.com/licenses/mit/)_

Copyright (c) _2023_ _Brandon Wright_