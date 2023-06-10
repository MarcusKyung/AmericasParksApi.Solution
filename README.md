# _AmericasParksApi_

#### By _**Marcus Kyung**_

#### _API for America's National and State Parks destinations built with C#, ASP.NET Core, and MySQL_

## Contents
* [Description](#description)
* [Setup & installation](#setupinstallation-requirements)
* [Endpoints](#endpoints)
* [Optional Query Parameters](#optional-query-string-parameters)
* [Example Get Requests](#example-get-requests)
* [Known-bugs](#known-bugs)
* [License](#license)

## Technologies Used

* _C#_
* _.NET_
* _MySQL_
* _MySQL/SQLWorkbench_
* _Postman_
* _Swagger UI_
* _Entity Framework_


## Description

_AmericasParksApi is an API used to track America's national and state parks. The starting database is seeded with data for all national parks as well as 6 national parks located in  Oregon and California. This API supports full CRUD functionality to store additional parks and to edit or delete existing ones. Parks are queryable by ```Name```, ```Location```, ```Type (national vs state)```, and ```date established```. AmericasParksApi v1 only supports the ability to get park results, while v2 supports full CRUD features including pagination and the ability to get results by page number and page size. This project was built using C#, Entity Framework Core, and MySQL._

## Setup/Installation Requirements

* _Download project repository from GH to your local machine._
* _Clone this repository to your desktop._
* _Open your device's terminal and navigate to this project's production directory at ```./AmericasParksApi.Solution/AmericasParksApi/```._

#### To Configure and Access the Database:
* _Within the production directory "AmericasParksApi", create a new file called ``appsettings.json``._
* _Within ```appsettings.json```, insert the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your desired database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the terminal command ```dotnet ef database update``` to create and populate the initial MySQL database with initial seed data._

#### To Run the API:
* _Navigate to this project's production directory named "AmericasParksApi"._
* _Run ```dotnet watch run``` in the command line to run the API from your local port. This will also open up Swagger UI in your browser. At this point, you can begin making API calls through the Swagger UI interface._
* _To make a test a "Get" request, click on the "Get" parks route in the Swagger UI, then click the "Try It Out" button._
* _Reference the endpoint urls, optional parameters, and example requests listed below. The AmericasParksApi.v2 supports Get, Post, Update, and Delete functionality._

## Endpoints
```
GET https://localhost:5001/api/{v1/v2}/parks/
GET https://localhost:5001/api/{v2}/parks/{id}
POST https://localhost:5001/api/{v2}/parks/
PUT https://localhost:5001/api/{v2}/parks/{id}
DELETE https://localhost:5001/api/{v2}/parks/{id}
```
Note: `{id}` is a variable and it should be replaced with the id number of the park you want to GET, PUT, or DELETE.
Note: `{v1/v2}` indicates the version of the API you want to use. v1 only supports GET requests, while v2 supports full CRUD functionality.

## Optional Query String Parameters
| Parameter       | Type        |  Required    | Description |
| --------------- | ----------- | -----------  | ----------- | 
| Name            | String      | Not Required | Returns parks with a matching Name value            |
| Type            | String      | Not Required | Returns parks with a matching Type value            |
| Location        | String      | Not Required | Returns parks with a matching Location value        |
| DateEstablished | String      | Not Required | Returns parks with a matching DateEstablished value |
| pageNumber      | Int         | Not Required | Returns parks from the specified page number        |
| pageSize        | Int         | Not Required | Controls the amount of parks returned on each page  |

## Example Get Requests
* _To make an Api call for all parks located in Oregon:_
https://localhost:5001/api/{v1/v2}/parks/?country=oregon
``
[
    {
        "parkId": 14,
        "name": "Crater Lake",
        "type": "National Park",
        "location": "Oregon",
        "dateEstablished": "1902",
        "area": "183,224.05 acres",
        "description": "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation."
    },
    {
        "parkId": 64,
        "name": "Tumalo",
        "type": "State Park",
        "location": "Oregon",
        "dateEstablished": "1954",
        "area": "330 acres",
        "description": "Tumalo State Park is a well-developed state park in Deschutes County, Oregon, United States. Established in 1954, the park is located northwest of the city of Bend and along the Deschutes River at a site home to many bird species. The park is popular for picnics, swimming, fishing, hiking, and camping, and is open year-round."
    },
    {
        "parkId": 65,
        "name": "Silver Falls",
        "type": "State Park",
        "location": "Oregon",
        "dateEstablished": "1933",
        "area": "9000 acres",
        "description": "Silver Falls State Park is a state park in the U.S. state of Oregon, located near Silverton, about 20 miles (32 km) east-southeast of Salem. It is the largest state park in Oregon with an area of more than 9,000 acres (36 km2), and it includes more than 24 miles (39 km) of walking trails, 14 miles (23 km) of horse trails, and a 4-mile (6.4 km) bike path."
    },
    {
        "parkId": 66,
        "name": "South Beach",
        "type": "State Park",
        "location": "Oregon",
        "dateEstablished": "1919",
        "area": "147,242.66 acres",
        "description": "South Beach State Park is a state park in the U.S. state of Oregon, administered by the Oregon Parks and Recreation Department. It is near the unincorporated community of South Beach."
    }
]
``
* _To make a call returning the first page of parks with 2 parks listed per page:_
https://localhost:5001/api/{v2}/parks/?pageNumber=1&pageSize=2
``
[
    {
        "parkId": 1,
        "name": "Acadia",
        "type": "National Park",
        "location": "Maine",
        "dateEstablished": "1919",
        "area": "49,071.40 acres",
        "description": "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats."
    },
    {
        "parkId": 2,
        "name": "American Samoa",
        "type": "National Park",
        "location": "American Samoa",
        "dateEstablished": "1988",
        "area": "8,256.67 acres",
        "description": "The southernmost national park is on three Samoan islands in the South Pacific. It protects coral reefs, rainforests, volcanic mountains, and white beaches. The area is also home to flying foxes, brown boobies, sea turtles, and 900 species of fish."
    }
]
``

## Additional Requirements for Post Request
* _POST requests https://localhost:5001/api/{v2}/parks/ require JSON body formatting shown below._
```
{
    "name": "Crater Lake",
    "type": "National Park",
    "location": "Oregon",
    "dateEstablished": "1902",
    "area": "183,224.05 acres",
    "description": "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation."
}
```

## Additional Requirements for Put Request
* _PUT requests https://localhost:5001/api/{v1/v2}/parks/{id} require JSON body formatting shown below._
```
{
    "parkId": 14,
    "name": "Crater Lake",
    "type": "National Park",
    "location": "Oregon",
    "dateEstablished": "1902",
    "area": "183,224.05 acres",
    "description": "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation."
}
```

## Known Bugs

* _No known issues as of 6/9/23_

## License

MIT License

Copyright (c) [2023] [Marcus Kyung]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: 

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR\ A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.