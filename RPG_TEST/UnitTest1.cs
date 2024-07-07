using Xunit;
using AdventureQuestRPG;

namespace AdventureQuestRPG.Tests
{
    public class AdventureTests
    {
        [Fact]
        public void DiscoverLocation_CorrectlyUpdatesPlayerLocation()
        {
            var adventure = new Adventure();
            adventure.TestDiscoverLocation();
        }
    }
}
