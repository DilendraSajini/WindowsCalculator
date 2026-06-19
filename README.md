# Windows Calculator (.NET 8)

This is a small toy project I built when I joined Sheffield Teaching Hospitals to strengthen my understanding of .NET development and become familiar with the .NET ecosystem. It is an implementation of a simple Windows Calculator application built using C# and .NET 8, demonstrating good software practices such as a clean project structure, unit testing, Git branching, good commit practices, pull request workflow, and CI/CD using GitHub Actions.

## Features

- Basic arithmetic operations (Add, Subtract, Multiply, Divide)
- Separate test project for unit testing
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

In the design phase, I focused on separating concerns by isolating the calculation logic from the UI layer, ensuring the codebase remained clean and testable.

During implementation, I built the application using C# and .NET 8, following good coding practices and structured project organisation. Unit tests were added to validate core functionality, and a CI pipeline using GitHub Actions was introduced to automate build and test processes.

This exercise helped me simulate a real-world development workflow, including requirements analysis, implementation, testing, version control, and continuous integration.
