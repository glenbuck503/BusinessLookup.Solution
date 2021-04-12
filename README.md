# Business Lookup

<div align="center">
<img src="https://github.com/glenbuck503.png" width="200px" height="auto" >
</div>
<br>
<br>
<br>

#### 

#### By Glen Buck

## Description
This is an customized API call to the BusinessLooup server. It will alow users to query the database using the middleware swashbuckle using swagger. 


## Setup/Installation Requirements

Repository: https://github.com/glenbuck503/BusinessLookup.Solution.git
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/) , clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to BusinessLookup directory within the BuisnessLookup.Solution directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in BusinessLookup directory, run "dotnet restore."
5. You will require a text or code editor to complete the following steps. [VS Code is recommended](https://code.visualstudio.com/)
6. Make sure to do a dotnet restore.


### _Installation: Database Recreation_

1. Ensure you are running MySQL Server 8 and MySQL WorkBench 8. If you are running windows, use the [Windows Installer ](https://dev.mysql.com/downloads/installer/) for MySQL and follow the instructions provided by the installer. For Macs, visit [MySQL Commuinity Downloads](https://dev.mysql.com/downloads/mysql/) and select macOS from the Operation Systems. This will be a manual installation. If you need additional assistance on this, please visit Epicodus's [Learn How to Program Article](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
2. Once you verify you have SQL installed, create a file called "appsettings.json" in the BusinessLookup directory (not the BuisnessLookup.Solution root directory) and Paste the following into this file.

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={PORT OF SERVER};database=glen_buck;uid=root;pwd={PASSWORD OF SERVER};"
  }
}

3. In your terminal, run "dotnet ef database update"


### _Installation: General Use_

1. Back in your terminal in the BusinessLookup production directory, type "dotnet run." The terminal will present local host routes for you to navigate to in your browser. An example would be "http://localhost:5000." Enter this into a web browser of choice to use this application. Keep the terminal running as it is being used to control the local server.

2. If you navigate to localhost:5000, it will bring you to an index page using Swagger.swagger lets the application have a UI (user interface) with readability user friendly. It lets users see the data in the database rendered from a JSON format.

### Swagger End Points for Restaurant

* If you go to the GET endpoint for Restaurants, click "try it out" and then "execute" and it will show a list of all Restaurants.

The body for each restaurant should look like this:

  {
    
    "restaurantId": 0,  
    "name": string,  
    "food": string,
    "number": string,  
  
  }
  
  


-make sure you press clear in swagger before doing this next step-
To look up a restaurant by ID number in your browser, navigate to http://localhost:5000/restaurant/[choose ID number]. Where choose ID number, enter in an ID number for a restaurant.


* If you go to the POST endpoint for Restaurants, click "try it out" and then a body template will show up that will look like this:

    {

      "restaurantId": 0,
      "name": "string",
      "food": "string",
      "number": "string"

    }

From here, you can edit those properties in any way you want and then click "try it out" and then it will add the new restaurant to the list of restaurents. To verify, you can go back to the GET endpoint, and click "try it out" and then "execute" and you will see the new updated lists of restaurants.


* The PUT endpoint will allow you to edit existing items. If you go to the PUT endpoint for Restaurants, click "try it out" and a body template will come up that will look like this:

  {
   
      "restaurantId": 0
      "name": "stridfdfng"
      "food": "string"
      "number": "string"
   
  }

You will have to enter an ID number in the box before this before you can edit. Now you can edit the existing restaurant ID.

* The DELETE endpoint lets you delete a restaurant by ID. If you want to delete a restaurant, go to the DELETE endpoint and then click "try it out", type in the ID of the restaurant that you want to delete, and then click "execute". To verify it properly deleted, go back to the GET endpoint and see the list of restaurants.


NOTE: You can use these methods the exact same way with Shops.



## No known bugs as of 4/11/2021

## Support and contact details

For contact support, please email Glen Buck <a href = "mailto: glenbuck@gamil.com">Send Email</a>

## Technologies Used

- C# 9
- .NET 5.0.102
- SDK 8.0.19
- -Razor
- Bootstrap 4.5
- HTML 5 (CS version)/CSS3
- My SQL 8.0.19/WorkBench 8.0.19
- Entity Framework
- HTML Helper
- Identity Framework
- Swagger
- Entity Design
- SwashBuckle


### License

333.23.21

Copyright (c) 2021 Glen Buck Inc.
```