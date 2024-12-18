using ArchitectureTests.Helpers;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace ArchitectureTests_NetArchRules;

public class InfrastructureLayerTests
{    
    [Fact]
    public void AggregateNameShouldEndInAggregate()
    {
        var result = LayerHelper.InfrastructureLayer                        
            .Should()
            .NotHaveDependencyOn("Microsoft.eShopWeb.ApplicationCore.Interfaces")
            .GetResult();
        Assert.True(result.IsSuccessful);
    }
}
