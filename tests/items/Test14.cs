using NUnit.Framework;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class Test14
    {
        [Test]
        public void ReciebesAcordingDamage()
        {
            Elf Elfo = new Elf("Nombre");
            Troll Trolo = new Troll("Nombre");
            int DamageRecived = Trolo.AttackPower - Elfo.DefensePower;
            Assert.AreEqual(Elfo.Health-DamageRecived,"Me quede sin tiempo xd");
        }
    }
}