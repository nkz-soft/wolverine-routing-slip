using AwesomeAssertions;

namespace Wolverine.RoutingSlip.Tests;

public sealed class RoutingSlipStateTests
{
    [Test]
    public void start_should_switch_status_to_running()
    {
        var state = new RoutingSlipState
        {
            DefinitionName = "demo",
        };

        state.Start();

        state.Status.Should().Be(RoutingSlipStatus.Running);
    }
}
