# solid-principles

Concise, beginner-friendly C# examples of the SOLID principles.

## Structure

- `SolidPrinciples.sln`: Visual Studio solution that groups all examples under `SOLID`
- `src/SingleResponsibility`: Single Responsibility Principle executable project
- `src/OpenClosed`: Open/Closed Principle executable project
- `src/LiskovSubstitution`: Liskov Substitution Principle executable project
- `src/InterfaceSegregation`: Interface Segregation Principle executable project
- `src/DependencyInversion`: Dependency Inversion Principle executable project

## How To Run

1. Install .NET 8 SDK or later.
2. Run a single principle project:

```powershell
dotnet run --project src/SingleResponsibility/SingleResponsibility.csproj
```

Available projects:

- `src/SingleResponsibility/SingleResponsibility.csproj`
- `src/OpenClosed/OpenClosed.csproj`
- `src/LiskovSubstitution/LiskovSubstitution.csproj`
- `src/InterfaceSegregation/InterfaceSegregation.csproj`
- `src/DependencyInversion/DependencyInversion.csproj`

Build the full solution:

```powershell
dotnet build SolidPrinciples.sln
```
