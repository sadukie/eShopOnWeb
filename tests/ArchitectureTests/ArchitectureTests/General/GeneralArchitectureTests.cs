using ArchitectureTests.Helpers;
using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.Slices.SliceRuleDefinition;

namespace ArchitectureTests.General;
public class GeneralArchitectureTests
{
    [Fact(Skip ="This needs work on layers")]
    public void NoCircularDependencies()
    {
        IArchRule noCircularDependencies = Slices()
            .Matching("Microsoft.eShopWeb.ApplicationCore.(*)..")
            .Should()
            .BeFreeOfCycles();
        noCircularDependencies.Check(LayerHelper.Architecture);
    }
}
