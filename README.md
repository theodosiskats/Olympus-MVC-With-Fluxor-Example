# Olympus MVC Example

Olympus MVC Example is a **.NET 9.0** solution designed as a modern web application using **Blazor** and **ASP.NET Core**.

### Primary Objectives

The primary goal of Olympus MVC Example is to demonstrate a streamlined, clean, and secure development approach tailored for the **Web Core Banking** team. It provides practical guidance and patterns for front-end development tasks, emphasizing robustness and flexibility. This project aims to:

- **Present a Cleaner and Safer Design**  
  It introduces a clean architecture that minimizes UI-breaking changes by clearly separating concerns between the front-end (UI) and back-end models. The use of ViewModels ensures that adjustments to data contracts (DTOs) do not directly affect the UI, making the application more secure and resilient.

- **Adopt a Non-Traditional MVC Approach**
  Due to the unconventional approach regarding two-way binding, the project implements a unidirectional data flow pattern using **Fluxor/Redux-style state management**. This centralized state management simplifies debugging, improves code maintainability, and avoids unexpected UI side-effects.

- **Showcase ViewModel-Centric Front-End Development**  
  By introducing ViewModels as intermediaries, the architecture demonstrates how developers can decouple UI components from domain models while adhering to a modular and scalable foundation. This abstraction protects the client application from inconsistencies caused by direct coupling with back-end DTO models.

This repository is a hands-on guide for Web Core Banking team developers, showcasing best practices for scalable front-end development with Blazor, leveraging advanced state management mechanisms, and emphasizing clear boundaries between layers.

## Project Structure

The solution is organized into the following key modules:

### 1. **CSB2.Client**
This is the primary Blazor WebAssembly client application.

#### Key Features:
- **Pages Directory:** Contains the Blazor pages that define the UI layout and functionality.
- **Components Directory:** Implements reusable UI components.
- **Layout Directory:** Provides shared layouts, e.g., navigation menus, headers, and footer styling.
- **ViewModels Directory:** Houses view models for storing and managing UI data logic.

#### Main Files:
- **App.razor:** Serves as the root component in the Blazor application.
- **_Imports.razor:** Simplifies namespace imports across Razor components.
- **Program.cs:** Configures the Blazor WebAssembly app's startup logic.

#### Static Resources:
The `wwwroot` directory contains static files such as CSS, JavaScript, and images used by the client application.

---

### 2. **Orchestrator**
The orchestrator module handles backend business logic and communication.

#### Key Features:
- Implements consumers or workers for processing specific backend tasks and messages.

#### Main Files:
- **GetLoanAccountStatusConsumer.cs:** Likely a class that processes or consumes loan account status requests.

---

## Development

### Requirements
- **Target Framework:** .NET 9.0
- **Languages:** C# 13.0
- **Tooling:** Visual Studio or any modern IDE/editor compatible with .NET and Blazor.

### Getting Started
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/theodosiskats/Olympus-MVC-With-Fluxor-Example.git
   ```
2. Open the solution file `OlympusMvcExample.sln` in Visual Studio.
3. Set `CSB2.Client` as the startup project.
4. Build and run the project using the IDE's debugger.

### Running the Project
- **Start the Blazor App:** By running `CSB2.Client`, you launch the web interface.
- **Start the Backend:** Ensure that the orchestrator module is configured for hosting its services.

---

## Contribution Guidelines

### File Structure
Please maintain the existing folder structure and ensure your changes are modular. Refer to the `Components`, `Pages`, and `Orchestrator` folders when adding new classes or Razor files.

### Code Style
- Follow standard .NET and C# conventions.
- Use dependency injection for service handling.

---

## Authors

This project is primarily developed and maintained by Theodosis Katsoulis.

---

## License

MIT

---

## Support

If you encounter any issues or have questions, feel free to create an issue on the project repository.