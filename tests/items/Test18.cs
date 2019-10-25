using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{
    public class Test18
    {
       
        [Test]
        public void WhenThereIsAnExchangeEncounterTheSenderLosesAllItems()
        {
            Elf elfo = new Elf("Eduardo");
            MagicStick palitoMagico = new MagicStick();
            MagicStick palitoMagico2 = new MagicStick();
            Robes robe = new Robes();
            elfo.AddItem(palitoMagico);
            elfo.AddItem(palitoMagico2);
            Elf elfoChorro = new Elf("El roba eduardos");
            List<IItem> items = new List<IItem>();
            items.Add(palitoMagico);
            items.Add(palitoMagico2);
            items.Add(robe);
            ExchangeEncounter encuentro = new ExchangeEncounter(elfo,elfoChorro,items);
            encuentro.DoEncounter();
            List<IItem> expectedItems = new List<IItem>();
            Assert.AreEqual(expectedItems, elfo.Items);
        }
        
    }
}