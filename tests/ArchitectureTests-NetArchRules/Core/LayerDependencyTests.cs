using ArchitectureTests.Helpers;
using NetArchTest.Rules;

namespace ArchitectureTests.Core;
public class LayerDependencyTests
{
    [Fact]
    public void CoreShouldNotDependOnAnyExternalProjects()
    {
        var coreShouldNotDependOnBlazorAdmin = LayerHelper.WebLayer
            .Should()
            .HaveDependencyOn("BlazorAdmin")
            .GetResult();
        Assert.True(coreShouldNotDependOnBlazorAdmin.IsSuccessful);
    }

//    [Fact]
//    public void CoreShouldNotDependOnBlazorShared()
//    {
//        IArchRule coreShouldNotDependOnBlazorShared = Types()
//            .That()
//            .Are(LayerHelper.CoreLayer)
//            .Should()
//            .NotDependOnAny(LayerHelper.BlazorSharedLayer)
//            .Because("Core and Blazor Shared should be independent of each other.");
//        coreShouldNotDependOnBlazorShared.Check(LayerHelper.Architecture);
//    }
//
//    [Fact]
//    public void CoreShouldNotDependOnInfrastructure()
//    {
//        IArchRule coreShouldNotDependOnInfrastructure = Types()
//            .That()
//            .Are(LayerHelper.CoreLayer)
//            .Should()
//            .NotDependOnAny(LayerHelper.InfrastructureLayer)
//            .Because("Core and Infrastructured should be independent of each other.");
//        coreShouldNotDependOnInfrastructure.Check(LayerHelper.Architecture);
//    }
//
//    [Fact]
//    public void CoreShouldNotDependOnPublicAPI()
//    {
//        IArchRule coreShouldNotDependOnPublicAPI = Types()
//            .That()
//            .Are(LayerHelper.CoreLayer)
//            .Should()
//            .NotDependOnAny(LayerHelper.PublicAPILayer)
//            .Because("Core and API should be independent of each other.");
//        coreShouldNotDependOnPublicAPI.Check(LayerHelper.Architecture);
//    }
//
//    [Fact]
//    public void CoreShouldNotDependOnWeb()
//    {
//        IArchRule coreShouldNotDependOnWeb = Types()
//            .That()
//            .Are(LayerHelper.CoreLayer)
//            .Should()
//            .NotDependOnAny(LayerHelper.WebLayer)
//            .Because("Core and Web should be independent of each other.");
//        coreShouldNotDependOnWeb.Check(LayerHelper.Architecture);
//    }
}
