# .NET Project: Build and Run Instructions

This document provides step-by-step instructions on how to compile, test, build, package, and run this project using the .NET command-line interface (CLI).

## 1. Restore Dependencies

Before you build the project, you need to restore the NuGet packages that it depends on. This command reads the project file (`.csproj`) and downloads any required libraries.

*   **Command:**

    ```bash
    dotnet restore
    ```

*   **When to use it:** You typically only need to run this once, or whenever you add or update a dependency. The `build` and `test` commands will also run this automatically if needed.

## 2. Compile the Code

This step compiles your C# code into an intermediate language (IL) and creates a DLL file in the `bin` directory. This is a good way to check for any syntax errors in your code without running the full application.

*   **Command:**

    ```bash
    dotnet build
    ```

*   **When to use it:** Use this command whenever you want to check your code for errors or create an updated build of the application.

## 3. Run Tests

Testing is a crucial part of the development process. This command runs all the tests in your solution and reports whether they passed or failed.

*   **Command:**

    ```bash
    dotnet test
    ```

*   **When to use it:** Run this command after making changes to your code to ensure that you haven't introduced any regressions.

## 4. Run the Application

This command builds and runs the application. The `--urls` option tells the application to listen on a specific port.

*   **Command:**

    ```bash
    dotnet run --project myapp.csproj --urls=http://localhost:3000
    ```

*   **When to use it:** Use this command to run the application locally for development and testing.

***Note:*** *If you get an "address already in use" error, it means another process is already using port 3000. You may need to stop any other running instances of this application.*

## 5. Package for Deployment

This command compiles your application and all of its dependencies into a folder called `publish`. This folder contains everything you need to run the application on a server.

*   **Command:**

    ```bash
    dotnet publish -c Release -o ./publish
    ```

    *   `-c Release` specifies that you want to build the application in "Release" mode, which is optimized for production.
    *   `-o ./publish` specifies the output directory.

*   **When to use it:** Use this command when you are ready to deploy your application to a hosting environment. The contents of the `publish` folder are what you would deploy.
