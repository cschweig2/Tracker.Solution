# Vendor and Order Tracker

#### Independent Code Review, Last Updated 12.18.2020

#### **By Chelsea Becker**

## Description

_Vendor and Order Tracker is a program that tracks the vendors that purchase baked goods from Pierre's Bakery and the orders belonging to those vendors._

## Setup/Installation Requirements

### Installing .NET Core Framework for Windows(10+) Users

1. _Download the 64-bit .NET Core SDK (Software Development Kit) by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .exe file. Click to install when it is finished downloading._
2. _After clicking the downloaded .exe file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### Installing .NET Core Framework for Mac Users

1. _Download the .NET Core SDK by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .pkg file. Click to install when it is finished downloading._
2. _After clicking the downloaded .pkg file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### View locally

1. _Open web browser and go to https://github.com/cschweig2/Bakery.Solution._
2. _After clicking the green "code" button, you can copy the URL for the repository._
3. _Open a terminal window, such as Command Prompt or Git Bash._<br>
  3a. _Type in this command: "git clone", followed by the URL you just copied. The full command should look like this: "git clone https://github.com/cschweig2/Bakery.Solution"._
4. _View the code on your favorite text editor, such as Visual Studio Code._
5._To run the program, you will need to follow the above steps for installing ASP.NET Core framework._ 
6. _Navigate to the Bakery and Bakery.Tests folders and enter "dotnet restore" in the command line to install packages._
6._After packages are installed in each of these folders, you may use "dotnet run" to both run and build the program._

## Known Bugs

No known bugs at this time.

## Test Specs


<table>
  <tr>
    <th>Test #</th>
    <th>Expected Behavior</th>
    <th>Input</th>
    <th>Output</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Create a Order class</td>
    <td>Order Order = new Order();</td>
    <td>order</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Can get a title from order</td>
    <td>newOrder.Title</td>
    <td>"Patty's Pastry Order"</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Can set a title for an order</td>
    <td>newOrder.Title = updatedTitle;</td>
    <td>"Justin's Pastry Order"</td>
  </tr>
  <tr>
    <td>4</td>
    <td>GetAll() function returns an empty list of orders</td>
    <td>Order.GetAll()</td>
    <td>List<Order> _instances = { }; </td>
  </tr>
  <tr>
    <td>5</td>
    <td>GetAll() function returns a full list of orders</td>
    <td>Order.GetAll()</td>
    <td>List<Order> _instances = { order1 }; </td>
  </tr>
  <tr>
    <td>6</td>
    <td>Return Id of each order</td>
    <td>Order.Id</td>
    <td>1</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Finds an object from corresponding Id</td>
    <td>Order.Find(1)</td>
    <td>order1;</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Creates an instance of Vendor</td>
    <td>Vendor()</td>
    <td>vendor</td>
  </tr>
  <tr>
    <td>9</td>
    <td>Get name of vendor</td>
    <td>Vendor.Name</td>
    <td>"Patty's Cafe"</td>
  </tr>
  <tr>
    <td>10</td>
    <td>Set name of vendor</td>
    <td>Vendor.Name = updatedName;</td>
    <td>"Jim's Cafe"</td>
  </tr>
  <tr>
    <td>11</td>
    <td>GetAll() returns an empty list of vendors</td>
    <td>Vendor.GetAll()</td>
    <td>List<Vendor> _vendors = { };</td>
  </tr>
  <tr>
    <td>12</td>
    <td>GetAll() returns full list of vendors</td>
    <td>Vendor.GetAll()</td>
    <td>List<Vendor> _vendors = { vendor1 };</td>
  </tr>
</table>
<br>

//TODO reformat expected behavior to use same tense

## Support and contact details

_If you run into any issues, you can contact the creator at chelraebecker@gmail.com, or make contributions to the code on GitHub via forking and creating a new branch._

## Technologies Used

_VS Code_ <br>
_C# version 7.3_<br>
_.NET Core version 2.2_<br>
_Razor_<br>
_REPL_<br>

## Legal

*This software is licensed under the MIT license.*

Copyright (c) 2020 **Chelsea Becker**