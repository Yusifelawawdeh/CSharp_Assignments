using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    public class ListPractice
    {
        public void StudentList()
        {
            List<string> students = new List<string>();
            students.Add("Sue");
            students.Add("JOE");
            students.Add("bob");
            students.Count();
            students.Capacity.ToString();
            students.Add("Mary");
            students.Add("beth");
        }

        public void TeacherList()
        {
            List<string> teachers = new List<string>(500);
            teachers.Add("jose");
            teachers.Count();
            teachers.Capacity.ToString();
        }
    }

    public class DifferentLists
    {

        public void CrocsList()
        {
            List<string> crocs = new List<string>() {"harvey", "Alexander", "Rex", "Rovers"};
            var crocAmount = crocs.Capacity;
            Console.Write(crocAmount);


        }

        public void AddingLists()
        {
            List<string> killerCrocs = new List<string>() {"GoGo", "Mojo", "Hobo", "Trolo"};

            List<String> KillerCrocsNewBand = new List<string>(4) {"GoGo", "Mojo", "Hobo", "Trolo"};

            List<String> KillerCrocsNewNewBand = new List<string>(KillerCrocsNewBand);

        }

        public void ListToArrayPractice()
        {

            List<string> killerCrocs = new List<string>() { "GoGo", "Mojo", "Hobo", "Trolo" };

            string[] originalGangstaCrocs = killerCrocs.ToArray();

            foreach (string ogCroc in killerCrocs)
            {
                Console.WriteLine(ogCroc);
            }


        }

        public void InsertIntoAndRemoveAtList()
        {

            List<string> killerCrocs = new List<string>() { "GoGo", "Mojo", "Hobo", "Trolo" };

            killerCrocs.Insert(1, "filthy frank");

            Console.Write(killerCrocs);

            killerCrocs.RemoveAt(2);

            Console.Write(killerCrocs);

        }

        public void RangeAndRemoveItems()
        {

            List<string> killerCrocs = new List<string>() { "GoGo", "Mojo", "Hobo", "Trolo" };

            killerCrocs.Remove("Mojo");


        }

        public void SortingLists()
        {

            List<string> killerCrocs = new List<string>() { "GoGo", "Mojo", "Hobo", "Trolo" };

            killerCrocs.Remove("Mojo");


        }


    }

}
