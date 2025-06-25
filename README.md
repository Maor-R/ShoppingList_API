# Shopping_LIst
Part A: Server side in .NET



##
Compile and run instructions:



## Installation
```js
Copy the file  EFShopingList.bak (from root .net project) to C drive
and now run the following command in MS-SQL as a script



USE [master];
go

RESTORE DATABASE EFShopingList
  FROM DISK = 'C:\EFShopingList.bak'
  WITH REPLACE;
  GO


In files: 
AppDbContext.cs
Program.cs

DB login details : the default login details is:(local)
This should be changed as needed for your login details.

```

## Run the app
```js
From root folder ShoppingListAPI run the following command from CLI:
dotnet run
or click the Play button from within Visual Studio.

```