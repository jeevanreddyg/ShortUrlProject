Welcome to the ShortUrlProject wiki!

# About
The project is for URL Shortener, Custom Links & Link Management. Below are the functionalities.
* Paste Link and generate short URL
* View short links created (Logged in User Only)
* View analytics (Need to be implemented) 

# Design
![](https://github.com/jeevanreddyg/ShortUrlProject/blob/master/Screenshots/highleveldesign.png)

# Screenshots
![](https://github.com/jeevanreddyg/ShortUrlProject/blob/master/Screenshots/Home.png)

![](https://github.com/jeevanreddyg/ShortUrlProject/blob/master/Screenshots/Links.png)


# Techincal specifications 

**Technical Stack**
* .Net Core 3.1
* Angular 8.2
* SQL Server
* C#

Things Todo:
* IApi* interfaces 
* Test cases

![](https://github.com/jeevanreddyg/ShortUrlProject/blob/master/Screenshots/Source.png)

![](https://github.com/jeevanreddyg/ShortUrlProject/blob/master/Screenshots/Source-domain.png)

# Environment setup

* Install .net core SDK 3.1
* Visual studio 2019 
* Create the SQL Database **AppShortUrlContext**

In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database:

PM> Update-Database

Alternatively, you can apply pending migrations from a command prompt at your project directory:

> dotnet ef database update
