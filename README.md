# Park Finder

#### Independent Code Review
#### Created 01.22.2021 | Last Updated 01.22.2021

#### **By Chelsea Becker**

## 📊Project Overview

### **Description**

An API designed to list state and national ParkFinder across the United States.

### **Technologies Used**

VS Code <br>
C# 7.3.0<br>
.NET Core 2.2.0<br>
Entity Framework Core 2.2.6<br>
MySQL Workbench 8.0 for Windows<br>
Postman<br>
Swagger<br>
Swashbuckle

### **Known Bugs**

No known bugs at this time.

## 🔌Installation Requirements

### **Code Editor**

To open the project on your local machine, you will need to download and install a code editor. The most popular choices are [Atom](https://atom.io/) and [Visual Studio Code](https://code.visualstudio.com/). Visual Studio Code is the code editor used to create this application.

### **Installing .NET Core Framework for Windows(10+) Users**

1. Download the 64-bit .NET Core SDK (Software Development Kit) by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer.<br>
1a. Follow prompts to begin your download. The download will be a .exe file. Click to install when it is finished downloading.
2. After clicking the downloaded .exe file, follow the prompts in the installer and use suggested default settings.
3. You can confirm a successful installation by opening a command line terminal and running the command `$ dotnet --version` , which should return a version number.


### **Installing .NET Core Framework for Mac Users**

1. Download the .NET Core SDK by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer.<br>
1a. Follow prompts to begin your download. The download will be a .pkg file. Click to install when it is finished downloading.
2. After clicking the downloaded .pkg file, follow the prompts in the installer and use suggested default settings.
3. You can confirm a successful installation by opening a command line terminal and running the command `$ dotnet --version` , which should return a version number.

### **Install Dotnet Script**

1. Enter the command `dotnet tool install -g dotnet-script` in the command line of a terminal window, such as Terminal for macOS or PowerShell for Windows.

### **Installing MySQL Workbench**

1. [Download and install](https://dev.mysql.com/downloads/workbench/) the version of MySQL Workbench suitable for your machine.

### **Install Postman (optional)**

1. Follow [this](https://www.postman.com/downloads/) link to view the Postman website to download and install.

## 💻View Locally/Project Setup

### **Clone**
1. Follow above steps to install .NET Core.
2. Open web browser and go to https://github.com/cschweig2/ParkFinder.Solution.
3. After clicking the green "code" button, you can copy the URL for the repository.
4. Open a terminal window, such as Command Prompt or Git Bash.<br>
  4a. Type in this command: `git clone` , followed by the URL you just copied. The full command should look like this: `git clone https://github.com/cschweig2/ParkFinder.Solution` .
5. View the code on your favorite text editor, such as Visual Studio Code.

### **Download**
1. Click [here](https://github.com/cschweig2/ParkFinder.Solution) to view project repository.
2. Click "Clone or download" to find the "Download ZIP" option.
3. Click "Download ZIP" and extract files.
4. Open the project in a text editor by clicking on any file in the project folder.

### **Import Database with Entity Framework Core/Command Line**
1. Navigate to the `ParkFinder` project folder and enter `dotnet ef database update` in the command line, which will create the database in MySQL Workbench using the migrations from the `Migrations` folder.

### **Final Steps**

1. Navigate to the `ParkFinder` folder and enter `dotnet restore` in the command line to install packages.
2. After packages are installed in each of these folders, navigate to the `ParkFinder` project folder and enter `dotnet run`  in the command line to both run and build the program.

## 📄API Documentation

Explore our API endpoints with Swagger Documentation:
After entering `dotnet run` in the command line to launch the server, use a browser to navigate to `http://localhost:5000/swagger/`.

-------------------------------------------------------

## Endpoints

Base URL: `https://localhost:5000`

### HTTP Request Structure

```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### **Example Query**
```
https://localhost:5000/api/parks/1
```
### **Sample JSON Response**
```
{
    "parkId": 1,
    "parkType": "National Park",
    "parkName": "Crater Lake",
    "city": "Crater Lake",
    "state": "OR",
    "status": "Open",
    "website": "https://www.nps.gov/crla/index.htm"
}
```

----------------------------
## Parks
Access national and state park listings across the United States.

### Http Request
```
GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}
```

### Path Parameters
<table>
  <tr>
    <th>Parameter</th>
    <th>Type</th>
    <th>Default</th>
    <th>Required</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>parkType</td>
    <td>string</td>
    <td>none</td>
    <td>false</td>
    <td>Returns parks by type (National Park, National Historic Site, etc.)</td>
  </tr>
  <tr>
    <td>parkName</td>
    <td>string</td>
    <td>none</td>
    <td>false</td>
    <td>Returns park by name</td>
  </tr>
  <tr>
    <td>city</td>
    <td>string</td>
    <td>none</td>
    <td>false</td>
    <td>Returns park by the city it is primarily located in. Note that some parks span multiple cities.</td>
  </tr>
  <tr>
    <td>state</td>
    <td>string</td>
    <td>none</td>
    <td>false</td>
    <td>Returns park by the state it is primarily located in. States are in 2-letter format (OR, NJ, PA, etc.)</td>
  </tr>
    <td>status</td>
    <td>string</td>
    <td>none</td>
    <td>false</td>
    <td>Returns parks whose status are set to "Open" or "Close". Please see the website listed for the park to see further details.</td>
  </tr>
</table>

### Example Query
```
https://localhost:5000/api/parks/?city=batsto&status=open
```
### Example JSON Response
```
{
    "parkId": 2,
    "parkType": "National Reserve",
    "parkName": "New Jersey Pinelands",
    "city": "Batsto",
    "state": "NJ",
    "status": "Open",
    "website": "https://www.nps.gov/pine/index.htm"
}
```
-------------------------------------------
## 📧Support and contact details

If you run into any issues, you can contact the creator at chelraebecker@gmail.com, or make contributions to the code on GitHub via forking and creating a new branch.

## 📝Contributors

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
  </tr>
</table>

## 🧐Legal

*This software is licensed under the MIT license.*

Copyright (c) 2020 **Chelsea Becker**