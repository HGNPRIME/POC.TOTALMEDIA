# POC.TOTALMEDIA

Steps to run the solution:

1- Create a Local Database on SQL Server Management Studio with the name "PocTotalMedia" OR run the "DB.sql" script.

2- Go to ".\Back\POC_backEnd" and change de ConnectionStrings

3- Go to ".\back\POC_backEnd" and execute the command `dotnet ef database update` to populate the DB

4- Run the command `dotnet run` to initiate the API

5- Go to ".\front\POC-App" and execute the command `npm start`

