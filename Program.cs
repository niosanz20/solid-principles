using Principles.SOLID.DependencyInversion;
using Principles.SOLID.InterfaceSegregation;
using Principles.SOLID.LiskovSubstitution;
using Principles.SOLID.OpenClosed;
using Principles.SOLID.SingleResponsibility;

var available = new[]
{
    "solid", "srp", "ocp", "lsp", "isp", "dip"
};

var principle = args.Length > 0 ? args[0].ToLowerInvariant() : string.Empty;

if (string.IsNullOrWhiteSpace(principle) || principle == "list")
{
    Console.WriteLine("Usage: dotnet run -- <principle>\nAvailable examples:\n" + string.Join(", ", available));
    return;
}

try
{
    switch (principle)
    {
        case "solid":
            SingleResponsibilityDemo.Run();
            OpenClosedDemo.Run();
            LiskovSubstitutionDemo.Run();
            InterfaceSegregationDemo.Run();
            DependencyInversionDemo.Run();
            break;
        case "srp":
        case "singleresponsibility":
            SingleResponsibilityDemo.Run();
            break;
        case "ocp":
        case "openclosed":
            OpenClosedDemo.Run();
            break;
        case "lsp":
        case "liskovsubstitution":
            LiskovSubstitutionDemo.Run();
            break;
        case "isp":
        case "interfacesegregation":
            InterfaceSegregationDemo.Run();
            break;
        case "dip":
        case "dependencyinversion":
            DependencyInversionDemo.Run();
            break;
        default:
            Console.WriteLine($"Unknown principle '{principle}'. Use 'list' to see available examples.");
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while running the demo: {ex.Message}");
}
