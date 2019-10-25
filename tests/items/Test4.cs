using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test4
    {
         [Test]
        public void TestHealth()
        {
            Troll troll = new Troll("Nombre");
            int Vida = troll.Health;
            int expected = 150;
            Assert.AreEqual(expected,Vida);
        }

        public void TestArmor()
        {
            Troll Mateo = new Troll("Nombre1");
            Armor Armadura = new Armor();
            IItem Variable = null;
            foreach (IItem Elemento in Mateo.Items)
            {
                if (Elemento.GetType() == Armadura.GetType())
                {
                   Variable = Elemento;
                }
            }

            Assert.AreEqual(Armadura.GetType(),Variable.GetType());
        }

         public void TestStick()
        {
            Troll Mateo = new Troll("Nombre1");
            Stick Palo = new Stick();
            IItem Variable = null;
            foreach (IItem Elemento in Mateo.Items)
            {
                if (Elemento.GetType() == Palo.GetType())
                {
                    Variable = Elemento;
                }
            }

            
            Assert.AreEqual(Palo.GetType(),Variable.GetType());
        }

    }
}