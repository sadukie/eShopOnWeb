using BlazorAdmin.Services;
using BlazorShared.Interfaces;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.Infrastructure.Data;
using Microsoft.eShopWeb.PublicApi;
using Microsoft.eShopWeb.Web.Features.OrderDetails;
using NetArchTest.Rules;

namespace ArchitectureTests.Helpers;
internal class LayerHelper
{

    private static System.Reflection.Assembly coreAssembly = typeof(IOrderService).Assembly;
    private static System.Reflection.Assembly blazorAdminAssembly = typeof(HttpService).Assembly;
    private static System.Reflection.Assembly blazorSharedAssembly = typeof(ICatalogItemService).Assembly;
    private static System.Reflection.Assembly infrastructureAssembly = typeof(FileItem).Assembly;
    private static System.Reflection.Assembly publicAPIAssembly = typeof(BaseMessage).Assembly;
    private static System.Reflection.Assembly webAssembly = typeof(GetOrderDetails).Assembly;

internal static readonly Types CoreLayer = Types
        .InAssembly(coreAssembly);

    internal static readonly string? CoreLayerName = "Microsoft.eShopWeb.ApplicationCore";

    internal static readonly Types BlazorAdminLayer = Types
        .InAssembly(blazorAdminAssembly);

    internal static readonly string? BlazorAdminLayerName = "Microsoft.eShopWeb.Web";

    internal static readonly Types BlazorSharedLayer = Types
        .InAssembly(blazorSharedAssembly);

    internal static readonly Types InfrastructureLayer = Types
        .InAssembly(infrastructureAssembly);

    internal static readonly Types PublicAPILayer = Types
        .InAssembly(publicAPIAssembly);

    internal static readonly Types WebLayer = Types
        .InAssembly(webAssembly);
}
