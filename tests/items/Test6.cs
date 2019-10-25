using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test6
    {
        [Test]
        public void WhenHPIs0CharacterIsDead()
        {
            Elf elfo = new Elf("Eduardo");
            Elf elfoBufado = new Elf("El Mata Eduardos");
            Gauntlet gauntlet = new Gauntlet();
            for (int i = 0; i < 10; i++)
            {
                gauntlet.AddGem(new Gem());
            }
            elfoBufado.AddItem(gauntlet);
            elfo.ReceiveAttack(elfoBufado.AttackPower);
            bool expectedIsDead = true;
            Assert.AreEqual(elfo.IsDead, expectedIsDead);
        }
        [Test]
        public void WhenHPIsNot0CharacterIsNotDead()
        {
            Elf elfo = new Elf("Eduardo");
            bool expectedIsDead = false;
            Assert.AreEqual(expectedIsDead,elfo.IsDead);
        }
        
    }
}