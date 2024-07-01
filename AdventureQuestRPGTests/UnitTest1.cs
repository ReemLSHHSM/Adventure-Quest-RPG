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

        //Testing if winner's health is greater than 0
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
    }
}