
# LifeDots Blazor Application

![Screenshot](screen.jpg)

## Overview

The **LifeDots** project is a Blazor application designed to visualize the remaining weeks of a user's estimated lifespan as colored dots. This application is built using Blazor (.NET-Platform).

## Features

- **User-Friendly Interface**: The application provides a simple and intuitive interface to calculate and visualize remaining life weeks.
- **Customizable Components**: Built with reusable Blazor components to ensure maintainability and scalability.
- **SOLID Principles**: Adheres to SOLID principles to ensure the code is modular, extensible, and easy to maintain.

## Project Structure

The project is structured into several key components:

### Interfaces
- **ICounterHandler.cs**: Interface for handling counter logic.
- **IDotColorizer.cs**: Interface for managing the logic of coloring dots based on user data.
- **IDotGenerator.cs**: Interface responsible for generating the dot visualization.
- **IHomeService.cs**: Interface for managing home page services.
- **IMessageService.cs**: Interface for handling message services within the application.

### Pages
- **Home.razor**: The main page of the application, where the dot visualization is rendered.
- **Home.razor.cs**: Code-behind for `Home.razor` handling logic and interactions.

### Services
- **CounterHandler.cs**: Implementation of the `ICounterHandler` interface, managing the counting logic.
- **DotColorizer.cs**: Implementation of the `IDotColorizer` interface, providing the logic for coloring dots.
- **DotGenerator.cs**: Implementation of the `IDotGenerator` interface, responsible for generating the dots based on user input.
- **HomeService.cs**: Implementation of the `IHomeService` interface, managing services related to the home page.
- **MessageService.cs**: Implementation of the `IMessageService` interface, providing messaging capabilities within the app.

### Main Program
- **Program.cs**: The entry point of the application, configuring services and the app's request pipeline.

## Setup and Deployment

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/)

### Running Locally

1. Create a new directory and navigate into it:
   ```bash
   mkdir LifeDotsProject
   cd LifeDotsProject
   ```

2. Clone the repository:
   ```bash
   git clone https://github.com/rudolphreti/LifeDots-Blazor
   cd LifeDots-Blazor
   ```

3. Open the project in Visual Studio:
* Open Visual Studio.
* Click on Open a project or solution.
* Navigate to the cloned repository folder LifeDots-Blazor and open the .sln file.

5. Press F5 to run the project.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements
Thanks to the Blazor and .NET communities for their support and resources!
