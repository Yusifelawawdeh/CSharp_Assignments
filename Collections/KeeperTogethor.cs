using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class KeeperTogethor
    {
        static void Main()
        {

            HashSet<Keeper> keepers = new HashSet<Keeper>
            {
                new Keeper() {Name = "Hodor", BlockLevel = 1000},
                new Keeper() {Name = "Leviathan", BlockLevel = 780},
                new Keeper() {Name = "JoJo", BlockLevel = 6000},
                new Keeper() {Name = "Sauron", BlockLevel = 50}
            };
            PracticingGenerics practicingGenerics = new PracticingGenerics();
            practicingGenerics.AddKeepers(keepers);

            LearningDictionary learningDictionary = new LearningDictionary();
            learningDictionary.AddKeepers2(keepers);

            Keeper joe = new Keeper() {Name = "joe", BlockLevel = 1};
            keepers.Add(joe);
            Keeper duplicateJoe = new Keeper() { Name = "joe", BlockLevel = 1 };
            keepers.Add(duplicateJoe);

            Console.WriteLine(joe.GetHashCode());
            Console.WriteLine(duplicateJoe.GetHashCode());

            foreach (Keeper keeper in keepers)
            {
                Console.WriteLine($"{keeper.Name} has a blocking level of {keeper.BlockLevel}");
            }

        }
    }
}
