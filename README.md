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

* Navigate to Pierre's Bakery repository on [GitHub](https://github.com/sethgonzales/Pierres-Bakery).
* Clone the repository down using `$ git clone https://github.com/sethgonzales/Pierres-Bakery.git` in your terminal.
* Navigate to this project's production directory called `PierresBakery`.
* In the command line, run the command `dotnet run` to compile and execute the console application. 
   * To compile the console app without running it, use the following command: `$ dotnet build`.
* Interact with each of the prompts to enter the shop and place an order. If you make a mistake, or would like to leave, follow the 'input error' or 'continuation' prompts as needed.
* To test the business logic, navigate to test directory, `PierresBakery.Tests`.
   * In the command line, run the command `$ dotnet restore` to install any testing files.
   * In the command line, run the command `$ dotnet test` to execute the tests.

## Known Bugs

* Users can enter non-alphabetical characters as part of their name. These characters will not trigger an error.

## MIT License

Copyright (c) 2023 Seth Gonzales

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact Information

If you run into any issues, or would like to contribute to our code, please email: sethgonzales157@gmail.com.
