# Pierre's Bakery

#### By _Seth Gonzales_

#### _A console application to take bread and pastry orders for Pierre's Bakery_

## Technologies Used

* C#
* .NET 6
* MSTest

## Description

This console application takes orders for pastry and bread for new customers. The application begins with a welcome screen, showing the customer the menu and deals of the day. If the customer decides to continue, they numerically enter their order. Once finished, the total cost is calculated and revealed. 


## Setup/Installation Requirements

1. Clone this repo.
2. Open your terminal and navigate to this project's production directory called `PierresBakery`.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
   1. Optionally, you can run `dotnet build` to compile this console app without running it.
4. Navigate to test directory, `PierresBakery.Tests`.
5. In the command line, run the command `dotnet test` to execute the tests.


## Known Bugs

* User can enter non-alphabetical characters without error, although the special character's will not be counted.

## License

MIT License

Copyright (c) _9/22/2023_ _Seth Gonzales_