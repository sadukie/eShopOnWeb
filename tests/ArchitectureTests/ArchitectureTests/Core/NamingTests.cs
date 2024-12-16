﻿using ArchitectureTests.Helpers;
using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests.Core;
public class NamingTests
{    
    [Fact(Skip ="Show that this can enforce naming constraints")]
    public void AggregateRootsShouldHaveAggregateInTheName()
    {
        IArchRule aggregatesShouldEndInAggregate =
            Classes()
            .That()
            .ImplementInterface("Microsoft.eShopWeb.ApplicationCore.Interfaces.IAggregate")
            .Should()
            .HaveNameEndingWith("Aggregate");
        aggregatesShouldEndInAggregate.Check(LayerHelper.Architecture);
    }

    [Fact]
    public void IRepositoryShouldEndWithRepository()
    {
        IArchRule iRepositoryShouldEndWithRepository =
            Classes()
            .That()
            .AreAssignableTo("Microsoft.eShopWeb.ApplicationCore.Interfaces.IRepository*", true)
            .Should()
            .HaveNameContaining("Repository");
            
        iRepositoryShouldEndWithRepository.Check(LayerHelper.Architecture);
    }

}
