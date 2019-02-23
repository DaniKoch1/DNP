using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest2
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange
            Hero hercules=new Hero{HitPoints=2};
            // Act
            bool actual=hercules.IsAlive();
            // Assert
            Assert.True(actual);
        }

        
        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void IsAlive_HitPointsAreZeroOrLess_ShouldReturnFalse(int value)
        {
             // Arrange
            Hero hercules=new Hero{HitPoints=value};
            // Act
        
            // Assert
            Assert.False(hercules.IsAlive());
        }
        


        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
             // Arrange
            Hero hercules=new Hero{HitPoints=0};
            // Act
        
            // Assert
            Assert.Equal(0,hercules.Attack());
        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {
             // Arrange
            Hero hercules=new Hero{HitPoints=6, Strength=8};
            // Act
        
            // Assert
            Assert.Equal(4,hercules.Attack());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Attack_WithWeaponWithAttackOneAndMore_ShouldReturnAttackValue(int value)
        {
             // Arrange
            Weapon attackOne=new Weapon{Attack=value};
            Hero hercules=new Hero{HitPoints=1, Strength=8, MainHandWeapon=attackOne};
            // Act
        
            // Assert
            Assert.Equal(value*4,hercules.Attack());
        }


        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {
              // Arrange
            Weapon attackOne=new Weapon{Attack=1};
            Hero hercules=new Hero{HitPoints=12, Strength=8, MainHandWeapon=attackOne, Defence=0};
            // Act
            Hero hades=new Hero{HitPoints=4, Strength=6, MainHandWeapon=attackOne, Defence=5};
            hercules.Defend(hades);
            // Assert
            Assert.Equal(9,hercules.HitPoints);
        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {
              // Arrange
            Weapon attackOne=new Weapon{Attack=1};
            Hero hercules=new Hero{HitPoints=12, Strength=8, MainHandWeapon=attackOne, Defence=2};
            // Act
            Hero hades=new Hero{HitPoints=4, Strength=6, MainHandWeapon=attackOne, Defence=5};
            hercules.Defend(hades);
            // Assert
            Assert.Equal(11,hercules.HitPoints);
        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {
              // Arrange
            Weapon attackOne=new Weapon{Attack=100};
            Hero hercules=new Hero{HitPoints=12, Strength=8, MainHandWeapon=attackOne, Defence=2};
            // Act
            Hero hades=new Hero{HitPoints=4, Strength=6, MainHandWeapon=attackOne, Defence=5};
            hercules.Defend(hades);
            // Assert
            Assert.False(hercules.HitPoints<0);
        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {
             // Arrange
            Weapon attackOne=new Weapon{Attack=100};
            Hero hercules=new Hero{HitPoints=12, Strength=8, MainHandWeapon=attackOne, Defence=2};
            // Act
            Hero hades=null;
           Action actual = () => hercules.Defend(hades);
            // Assert
            Assert.Throws<ArgumentNullException>(actual );
        }
    }
}
