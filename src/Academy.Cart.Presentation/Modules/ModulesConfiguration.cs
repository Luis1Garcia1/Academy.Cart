using Microsoft.AspNetCore.Builder;

namespace Academy.Cart.Presentation.Modules;

public class ModulesConfiguration
{
    public static void Configure(WebApplication app)
    {
        app.AddCustomerModules();
    }
}