using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test1
    {
        [Test]
        public void TestPower()
        {
            Stick Palo = new Stick();
            Magic Magia = new Magic();
            MagicStick PaloMagico = new MagicStick();
            
            int expected = (Magia.AttackPower + (Palo.AttackPower*3));
            int Poder = PaloMagico.AttackPower;

            Assert.AreEqual(expected,Poder);
        }
    }
}