using ArchitectureTests.Helpers;
using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests.Core;
public class LayerDependencyTests
{
    [Fact]
    public void CoreShouldNotDependOnBlazorAdmin()
    {
        IArchRule coreShouldNotDependOnBlazorAdmin = Types()
            .That()
            .Are(LayerHelper.CoreLayer)
            .Should()
            .NotDependOnAny(LayerHelper.BlazorAdminLayer)
            .Because("Core and Blazor Admin should be independent of each other.");
        coreShouldNotDependOnBlazorAdmin.Check(LayerHelper.Architecture);
    }

    [Fact]
    public void CoreShouldNotDependOnBlazorShared()
    {
        IArchRule coreShouldNotDependOnBlazorShared = Types()
            .That()
            .Are(LayerHelper.CoreLayer)
            .Should()
            .NotDependOnAny(LayerHelper.BlazorSharedLayer)
            .Because("Core and Blazor Shared should be independent of each other.");
        coreShouldNotDependOnBlazorShared.Check(LayerHelper.Architecture);
    }

    [Fact]
    public void CoreShouldNotDependOnInfrastructure()
    {
        IArchRule coreShouldNotDependOnInfrastructure = Types()
            .That()
            .Are(LayerHelper.CoreLayer)
            .Should()
            .NotDependOnAny(LayerHelper.InfrastructureLayer)
            .Because("Core and Infrastructured should be independent of each other.");
        coreShouldNotDependOnInfrastructure.Check(LayerHelper.Architecture);
    }

    [Fact]
    public void CoreShouldNotDependOnPublicAPI()
    {
        IArchRule coreShouldNotDependOnPublicAPI = Types()
            .That()
            .Are(LayerHelper.CoreLayer)
            .Should()
            .NotDependOnAny(LayerHelper.PublicAPILayer)
            .Because("Core and API should be independent of each other.");
        coreShouldNotDependOnPublicAPI.Check(LayerHelper.Architecture);
    }

    [Fact]
    public void CoreShouldNotDependOnWeb()
    {
        IArchRule coreShouldNotDependOnWeb = Types()
            .That()
            .Are(LayerHelper.CoreLayer)
            .Should()
            .NotDependOnAny(LayerHelper.WebLayer)
            .Because("Core and Web should be independent of each other.");
        coreShouldNotDependOnWeb.Check(LayerHelper.Architecture);
    }
}
