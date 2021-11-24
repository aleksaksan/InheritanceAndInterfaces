using HomeworkClasses;
using System;

namespace RPGGame
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Monster m = new Monster();
            Console.WriteLine(m.Name);
            Hero player = new Hero("Ivan228", Humanoid.Race.alien, 1000, 10, 50, 1);
            Console.WriteLine(player.IsDead); 
            Inventar inv = new Inventar(player, 20);
            Item item = new Item("меч леденец", Item.Type.sword, 200, 15);
            inv.AddItem(item);
            inv.AddItem(new Item("щитец", Item.Type.shield, 150, 50));
            player.inventar = inv;
            player.inventar.ShowContents();
            //inv.ShowContents();
            player.GetInfo();
            player.Wounds(m.GetAttack());
            
            player.GetInfo();
            Console.WriteLine(inv._owner);
        }
    }
}
