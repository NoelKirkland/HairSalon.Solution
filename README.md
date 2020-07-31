# Noel's Hair Salon

### By Noel Kirkland, 7/31/2020

[Setup](#1)
[Specs](#2)
[Bugs](#3)
[Contact](#4)
[Tech](#5)
[License](#6)

## Description

This project will alow a salon owner to keep track of their customers, as well as their stylists, in an easy to use web application. Once set up properly, the salon owner will be able store their employee and client data in a local database and will be able to pull up the information they need at any time.

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
  5. _Install the necessary MySQL database by copying the following code block and entering it into your terminal:_

      ```

      ```

  6. _Exit MySQL by running the command `> exit`_

* _Run the application_
  1. _In the terminal, navigate to the project directory by running the command `> cd HairSalon`_
  2. _Now that we are in the HairSalon directory you will run the command `> dotnet restore`_
  3. _Once the "obj" folder has initialized you will run the command `> dotnet run`_
  4. _Go to http://localhost:5000/ in your preferred browser to use the application_


## Specifications <a name="2"></a>

## Known Bugs <a name="3"></a>

There are no known bugs at this time.

## Support and Contact Details <a name="4"></a>

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used <a name="5"></a>

*  C#/.NET
*  HTML
*  CSS
*  Markdown


### License <a name="6"></a>

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Noel Kirkland LLC_**