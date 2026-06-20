# Windows Calculator (.NET 8)
<p align="center">
  <img src="https://github.com/user-attachments/assets/498e2116-eec6-429e-936a-237898721465"
       width="274"
       height="436"
       alt="image" />
</p>

This is a small toy project I built when I joined Sheffield Teaching Hospitals to strengthen my understanding of .NET development and become familiar with the .NET ecosystem. It is an implementation of a simple Windows Calculator application built using C# and .NET 8, demonstrating good software practices such as a clean project structure, unit testing, Git branching, good commit practices, pull request workflow, and CI/CD using GitHub Actions.

## Features

- Basic arithmetic operations (Add, Subtract, Multiply, Divide)
- Separate test project for unit testing, and unit testing best practices
- Lint-check setup to enforce,
        code style
        best practices
        security warnings
        unused code detection
- GitHub Actions CI pipeline
- Code coverage support
- Clean solution structure with separation of concerns


## Tech Stack

- .NET 8 (C#)
- MSTest / xUnit (unit testing framework)
- GitHub Actions (CI/CD)
- ReportGenerator (test coverage reporting)
- NuGet package management


## Software Development Lifecycle

Although this project does not solve a new real-world business problem, it was used as a learning exercise to apply a structured software development lifecycle.

In the requirements phase, I analysed the original Windows Calculator application to understand expected behaviour, user interactions, and edge cases. This helped define the functional requirements for the project.

In the design phase, I separated calculation logic from the UI to apply separation of concerns, which improved maintainability, testability, and reusability by reducing coupling and aligning the design with encapsulation and abstraction principles.

During implementation, I built the application using C# and .NET 8, following good coding practices and structured project organisation. Unit tests were added to validate core functionality, and a CI pipeline using GitHub Actions was introduced to automate build and test processes.

This exercise helped me simulate a real-world development workflow, including requirements analysis, implementation, testing, version control, and continuous integration.

## Setup Instructions

### Prerequisites
.NET development can be done on macOS using .NET 8 for cross-platform applications like console apps, web APIs, and unit testing. However, Windows-specific frameworks like WPF or WinForms require a Windows environment, so for my calculator project I used Windows due to its UI dependency.

Ensure you have the following installed:
- .NET SDK 8.0 or later
- Visual Studio 2022 (recommended) or Visual Studio or Visual Studio Code
- Git

---

### 1. Clone the repository
```bash
git clone https://github.com/YOUR_USERNAME/WindowsCalculator.git
cd WindowsCalculator

### 2. Restore Dependencies
dotnet restore

### 3. Build the Solution
dotnet build -warnaserror

### 4. Run the application
dotnet run --project WindowsCalculator

### 5. Run unit tests
dotnet test
