using System.Xml.Linq;
using System.Xml.Serialization;
using AdventureQuestRPG;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        //Testing Attack when target is monster
        [Fact]
        public void test_MonsterAttack()
        {
            //Assign 
            Player player = new Player("Reem", 100, 30, 10);
            Zombie zombie = new Zombie();

            //Act
            int result = BattleSystem.Attack(player, zombie);

            //Assert
            Assert.Equal(result, 64);
        }

        //Testing Attack when target is player
        [Fact]
        public void test_PlayerAttack()
        {
            //Assign 
            Player player = new Player("Reem", 100, 30, 10);
            Zombie zombie = new Zombie();

            //Act
            int result = BattleSystem.Attack(zombie,player);

            //Assert
            Assert.Equal(result,90);
        }

<<<<<<< Updated upstream
        //Testing if winner's health is greater than 0
=======
        // Testing if winner's health is greater than 0
>>>>>>> Stashed changes
        [Fact]
        public void StartBattle_PlayerWins_HealthGreaterThanZero()
        {
            // Arrange
            var player = new Player("Reem", 1000, 100, 100);


            Zombie zombie = new Zombie();


            // Act
            BattleSystem.StartBattle(player, zombie);

            // Assert
            Assert.True(player.Health > 0, "Player's health should be greater than zero after winning the battle.");
            Assert.True(zombie.Health == 0, "Zombie's health should be zero after losing the battle.");
        }

        //[Fact]
        //public void DiscoverLocation_ShouldUpdatePlayerLocation_WhenLocationAvailable()
        //{
        //    // Arrange
        //    var adventure = new Adventure();
        //    var player = new Player("reem");
        //    // Act
        //    bool discovered = adventure.DiscoverLocation();

        //    // Assert
        //    Assert.True(discovered);
        //    Assert.NotEqual(Location.Forest, adventure.player.Location); // Assuming Forest is starting location
        //}

        //[Fact]
        //public void TestEncounterBossMonster()
        //{
        //    // Arrange
        //    var adventure = new Adventure();

        //    // Act
        //    bool encounteredBoss = false;
        //    for (int i = 0; i < 100; i++) // Simulate multiple encounters
        //    {
        //        adventure.EncounterMonster();
        //        if (adventure.monsters.Any(monster => monster is BossMonster))
        //        {
        //            encounteredBoss = true;
        //            break;
        //        }
        //    }

        //    // Assert
        //    Assert.True(encounteredBoss, "Boss monster was not encountered in 100 attempts.");
        //}
    }
}