# solid-principles

Concise, beginner-friendly C# examples of the SOLID principles.

## Structure

- `src/solid/SingleResponsibility`: Single Responsibility Principle
- `src/solid/OpenClosed`: Open/Closed Principle
- `src/solid/LiskovSubstitution`: Liskov Substitution Principle
- `src/solid/InterfaceSegregation`: Interface Segregation Principle
- `src/solid/DependencyInversion`: Dependency Inversion Principle

## How To Run

1. Install .NET 8 SDK or later.
2. Run a single principle example:

```powershell
dotnet run --project solid-principles.csproj -- srp
```

Available principle keys:

- `srp` or `singleresponsibility`
- `ocp` or `openclosed`
- `lsp` or `liskovsubstitution`
- `isp` or `interfacesegregation`
- `dip` or `dependencyinversion`

Run all SOLID examples together only when you want to see the full demo:

```powershell
dotnet run --project solid-principles.csproj -- solid
```

Use `list` to see runnable examples