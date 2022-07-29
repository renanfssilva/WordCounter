# WordCounter
WordCounter is a web app that counts how many words exists on an inputed text.
It can be in any language and separated by anything.

## Running the project
### 1. Heroku
The WordCounter project is published on Heroku, you can access through the website [WordCounter App](https://word-counter-app-renan.herokuapp.com/).

### 2. .NET
Steps to run the project:
* First you'll need to install .NET 6.0, the download link is at the [Developed With](https://github.com/renanfssilva/WordCounter#developed-with) section;
* Clone this project:
```bash
git clone https://github.com/renanfssilva/WordCounter
cd .\WordCounter\
```
* Build it:
```bash
dotnet build
```
* Enter subfolder WordCounter:
```bash
cd .\WordCounter
```
* Run the project:
```bash
dotnet run
```
* Open your browser and you can access it through:
  * HTTPS: https://localhost:7033 or
  * HTTP: http://localhost:5033

## Testing the project
Steps to run project tests:
* After installing .NET 6.0, clone the project and build it;
* Access the folder **_{root}\WordCounter\WordCounter.Tests_** through console;
* Run tests:
```bash
dotnet test
```

## Reviewing the code
All the logic about the number of words counted is at [Counter.razor](https://github.com/renanfssilva/WordCounter/blob/main/WordCounter/Pages/Counter.razor).

All the tests were developed at the [WordCounter.Tests project](https://github.com/renanfssilva/WordCounter/tree/main/WordCounter.Tests).

## Developed With
* [.NET 6.0 (Blazor)](https://dotnet.microsoft.com/en-us/download)
* [Bootstrap](https://getbootstrap.com/)
