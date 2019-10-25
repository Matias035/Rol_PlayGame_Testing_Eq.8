using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test15
    {
        
        [Test]
        public void WhenACharacterRecivesAnAttackItsLifeCannotBeLessThan0()
        {
            Elf elfo = new Elf("Eduardo");
            elfo.ReceiveAttack(150);
            int expectedHealth = 0;
            Assert.AreEqual(elfo.Health, expectedHealth);
        }
        
    }
}