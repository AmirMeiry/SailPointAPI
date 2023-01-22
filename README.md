# SailPointAPI

![Project Image](https://media.ttmind.com/Media/tech/article_22_8-8-201810-19-28AM.jpg)

> .NET Core API using Swagger UI

---

### Table of Contents

- [Description](#description)
- [How To Use](#how-to-use)
- [Author Info](#author-info)

---

## Description

.NET Core API that uses Swagger UI and SQLite DB to get data and transfer it using HTTP requests

### Packages

| Package | NuGet Link | Version |
| ------- | ------- | ------- |
| **Microsoft.AspNetCore.Cors** | [`@nuget/packages/Microsoft.AspNetCore.Cors`](https://www.nuget.org/packages/Microsoft.AspNetCore.Cors/) | [![version](https://img.shields.io/badge/dependencies-up%20to%20date-brightgreen)](https://www.nuget.org/packages/Microsoft.AspNetCore.Cors/)
| **Microsoft.EntityFrameworkCore.Sqlite** | [`@nuget/packages/Microsoft.EntityFrameworkCore.Sqlite`](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/) | [![version](https://img.shields.io/badge/dependencies-up%20to%20date-brightgreen)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/)
| **Swashbuckle.AspNetCore** | [`@nuget/packages/Swashbuckle.AspNetCore`](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) | [![version](https://img.shields.io/badge/dependencies-up%20to%20date-brightgreen)](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)


#### Technologies

- .NET Core API
- Swagger UI
- SQLite

[Back To The Top](#read-me-template)

---

## How To Use

#### Fast Installation

git clone the repo using
```html
git clone https://github.com/AmirMeiry/SailPointAPI.git
```

If the next terms are met, the code will run without problems:
- NET 5.0 installed (Required)
- Windows OS

> If you are using other OS you will probably have to download the latest Visual Studio 2019.

> if you got the following error
```html
A path base can only be configured using IApplicationBuilder.UsePathBase().
```
Comment out the following code in the file Program.cs
```html
webBuilder.UseUrls("...");
```


#### NuGet Installation

#### Microsoft.AspNetCore.Cors installation
```html
    # NuGet Package Manager UI

    Microsoft.AspNetCore.Cors

    # Package Manager Console

    Install-Package Microsoft.AspNetCore.Cors -Version 2.2.0
```

#### Microsoft.EntityFrameworkCore.Sqlite installation
```html
    # NuGet Package Manager UI

    Microsoft.EntityFrameworkCore.Sqlite

    # Package Manager Console

    Install-Package Microsoft.EntityFrameworkCore.Sqlite -Version 5.0.9
```

#### Swashbuckle.AspNetCore installation
```html
    # NuGet Package Manager UI

    Swashbuckle.AspNetCore

    # Package Manager Console

    Install-Package Swashbuckle.AspNetCore -Version 5.6.2
```

[Back To The Top](#read-me-template)

---

## Author Info

- Linkedin - [@amirmeiry](https://www.linkedin.com/in/amir-meiry-5aa2abb9/)

[Back To The Top](#read-me-template)
