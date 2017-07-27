using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class KeeperTogethor
    {
        static void Arbitrary()
        {
            List<Keeper> keepers = new List<Keeper>
            {
                new Keeper() {Name = "Hodor", BlockLevel = 1000},
                new Keeper() {Name = "Leviathan", BlockLevel = 780},
                new Keeper() {Name = "JoJo", BlockLevel = 6000},
                new Keeper() {Name = "Sauron", BlockLevel = 50}
            };

            PracticingGenerics practicingGenerics = new PracticingGenerics();
            practicingGenerics.AddKeepers(keepers);
            
            foreach (Keeper keeper in practicingGenerics.Keepers)
            {
                Console.WriteLine($"{keeper.Name} has a blocking level of {keeper.BlockLevel}");
            }

        }
    }
}
