using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class Test3
    {
        [Test]
        public void TestElfCreationWith120HP()
        {
            Elf elfo = new Elf("Eduardo");
            int expectedHp = 120;
            Assert.AreEqual(expectedHp, elfo.Health);
        }
        [Test]
        public void TestElfCreationWithRobesItem()
        {
            Elf elfo = new Elf("Eduardo");
            Robes robe = new Robes();
            IItem RobeItem = null;
            foreach (IItem item in elfo.Items)
            {
                if (item.GetType() == robe.GetType())
                {
                    RobeItem = item;
                }
            }
            Assert.AreEqual(robe.GetType(),RobeItem.GetType());
        }
        [Test]
        public void TestElfCreation()
        {
            Elf elfo = new Elf("Eduardo");
            string expectedName = "Eduardo";
            Assert.AreEqual(expectedName,elfo.Name);
           
        }
    }
}