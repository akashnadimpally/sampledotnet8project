# Project Blueprint

## 1. Overview

This document outlines the plan for setting up a .NET 8 project with a sample test for compilation and testing purposes.

## 2. Current Task: Downgrade to .NET 8 and Add Tests

### Plan

1.  **Downgrade to .NET 8:**
    *   Update `myapp.csproj` to target `net8.0`.
    *   Modify `Program.cs` for .NET 8 compatibility.
    *   Adjust `Properties/launchSettings.json` for the .NET 8 runtime.
2.  **Add a Unit Test Project:**
    *   Create a new xUnit test project.
    *   Add a reference to the main application.
    *   Create a sample test file to verify the application's behavior.
3.  **Execute Build and Test:**
    *   Restore dependencies using `dotnet restore`.
    *   Build the solution with `dotnet build`.
    *   Run the tests using `dotnet test`.
