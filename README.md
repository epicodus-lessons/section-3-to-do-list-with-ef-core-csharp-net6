## What Is This?

This is an example repo corresponding to multiple lessons within the LearnHowToProgram.com walkthrough on creating a To Do List application in [Section 3: Database Basics](https://www.learnhowtoprogram.com/c-and-net/database-basics).

This project corresponds to the classwork and lessons that describe how to connect an ASP.NET Core MVC project to a MySQL database using [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/). There are multiple lessons in this series. The first lesson in the series is [Introducing Entity Framework Core](https://www.learnhowtoprogram.com/c-and-net/database-basics/introducing-entity-framework).

There are multiple branches in this repo that are described more below.

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/lessons/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `todolist_with_ef_core_dump.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `to_do_list_with_ef_core`.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ToDoList".
3. Within the production directory "ToDoList", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
```

5. Within the production directory "ToDoList", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).


## Available Branches

**1_ef_core_setup**: This is the default branch with the starter code for the To Do List project as an ASP.NET Core MVC web application that is configured to use Entity Framework Core to communicate with a MySQL database. This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/database-basics/introducing-entity-framework-core
- https://www.learnhowtoprogram.com/c-and-net/database-basics/configuration-for-entity-framework-core


**2_create_read_and_details_with_html_helpers**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/database-basics/read-with-ef-core
- https://www.learnhowtoprogram.com/c-and-net/database-basics/create-with-ef-core
- https://www.learnhowtoprogram.com/c-and-net/database-basics/html-helper-methods-lambda-expressions-and-string-interpolation
- https://www.learnhowtoprogram.com/c-and-net/database-basics/showing-item-details-with-ef-core
- https://www.learnhowtoprogram.com/c-and-net/database-basics/further-exploration-with-testing

**3_update_and_delete**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/database-basics/update-with-ef-core
- https://www.learnhowtoprogram.com/c-and-net/database-basics/delete-with-ef-core

**4_one_to_many_relationship**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/database-basics/establishing-a-one-to-many-relationship-with-navigation-properties
- https://www.learnhowtoprogram.com/c-and-net/database-basics/using-viewbag
- https://www.learnhowtoprogram.com/c-and-net/database-basics/create-and-update-with-a-one-to-many-relationship
