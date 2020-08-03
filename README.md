# Noel's Hair Salon

### By Noel Kirkland, 7/31/2020

•[Setup](#1)<br>
•[Bugs](#3)<br>
•[Contact](#4)<br>
•[Tech](#5)<br>
•[License](#6)

## Description

This project will alow a salon owner to keep track of their stylists, as well as their customers, in an easy to use web application. Once set up properly, the salon owner will be able store their employee and client data in a local database and will be able to pull up the information they need at any time.

## Setup/Installation Requirements <a name="1"></a>

* _Install the .NET framework_
  1. _This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)_

* _Install and configure MySQL_
  1. _This program utilizes MySQL Community Server version 8.0.15 and requires [this to be pre-installed](https://dev.mysql.com/downloads/file/?id=484914). Click the link at the bottom that reads "No thanks, just start my download"_
  2. _Use Legacy Password Encryption and set password to "epicodus"_
  3. _Click "Finish_
  


* _Download this application from HitHub_
  1. _Open the following web address in your browser: **`https://github.com/NoelKirkland`**_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the **`HairSalon.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Install the MySQL database_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command `> echo 'export PATH="$PATH:/usr/local/mysql/bin"' >> ~/.zprofile`_
  3. _Enter the command `> source ~/.zprofile` to confirm MsSQL has been installed_
  4. _Connect to MySQL by running the command `> mysql -uroot -pepicodus`_
  5. _Install the necessary MySQL database by copying the code block below and entering it into your terminal_
  6. _Once the following code block has been entered you will close MySQL by running the command `> exit`_

```
    DROP DATABASE IF EXISTS `noel_kirkland`;
    CREATE DATABASE `noel_kirkland` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
    USE `noel_kirkland`;
    CREATE TABLE `clients` (
      `ClientId` int(11) NOT NULL AUTO_INCREMENT,
      `Name` varchar(255) DEFAULT NULL,
      `PhoneNumber` int(11) DEFAULT NULL,
      `StylistId` int(11) DEFAULT '0',
      PRIMARY KEY (`ClientId`)
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
    CREATE TABLE `stylists` (
      `StylistId` int(11) NOT NULL AUTO_INCREMENT,
      `Name` varchar(255) DEFAULT NULL,
      `StationNumber` int(11) DEFAULT NULL,
      `Specialty` varchar(255) DEFAULT NULL,
      PRIMARY KEY (`StylistId`)
    ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

```

* _Run the application_
  1. _In the terminal, navigate to the project directory by running the command `> cd HairSalon`_
  2. _Now that we are in the HairSalon directory you will run the command `> dotnet restore`_
  3. _Once the "obj" folder has initialized you will run the command `> dotnet run`_
  4. _Go to http://localhost:5000/ in your preferred browser to use the application_


## Known Bugs <a name="2"></a>

There are no known bugs at this time

## Support and Contact Details <a name="3"></a>

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used <a name="4"></a>

*  C#/.NET
*  MySQL
*  HTML
*  CSS
*  Markdown


### License <a name="5"></a>

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Noel Kirkland LLC_**