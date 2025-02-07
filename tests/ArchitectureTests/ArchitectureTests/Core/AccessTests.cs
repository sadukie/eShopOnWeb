using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ArchitectureTests.Helpers;
using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using static ArchUnitNET.Fluent.ArchRuleDefinition;


namespace ArchitectureTests.Core;
public class AccessTests
{

    [Fact]
    public void FieldsInEntitiesShouldBePrivate()
    {
        // For property members in entities
        // Make sure their setters are set to private
        FieldMembers()
            .That()
            .AreDeclaredIn(Classes().That().ResideInNamespace("Microsoft.eShopWeb.ApplicationCore.Entities*", true))
            .Should()
            .BePrivate()
            .Check(LayerHelper.Architecture);
    }
}
