using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test11
    {
        
        [Test]
        public void WhenAdding2ItemsToACharacterTheCharactersDamageIsTheSumOfBothItems()
        {
            Elf elfo = new Elf("Eduardo");
            MagicStick palitoMagico = new MagicStick();
            MagicStick palitoMagico2 = new MagicStick();
            elfo.AddItem(palitoMagico);
            elfo.AddItem(palitoMagico2);
            int expectedAttackPower = palitoMagico.AttackPower + palitoMagico2.AttackPower;
            Assert.AreEqual(elfo.AttackPower, expectedAttackPower);
        }
        
    }
}