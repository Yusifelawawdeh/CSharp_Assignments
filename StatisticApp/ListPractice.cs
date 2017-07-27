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

            killerCrocs.Sort();
        }

        


    }


    public class MathHelpers
    {
        public static List<int> GetPowersOf2(int input)
        {
            var returningList = new List<int>();
            for (int i = 0; i < input + 1; i++)
            {
                returningList.Add((int)Math.Pow(2, i));
            }

            return returningList;
        }

    }



    public class Brogram
    {
        static void BrogrammingStart()
        {
            List<Staff> staffers = new List<Staff>
            {
                new Staff() {Name = "Margery", PayGrade = 59000},
                new Staff() {Name = "James", PayGrade = 50000},
                new Staff() {Name = "Alexander", PayGrade = 79000},
                new Staff() {Name = "Don", PayGrade = 45000},
                new Staff() {Name = "Oberin", PayGrade = 120000},
                new Staff() {Name = "Harvey", PayGrade = 90000}
            };

            staffers.Sort();

            Staff newStaff = new Staff() { Name = "Joe", PayGrade = 90200 };

            int index = staffers.BinarySearch(newStaff);

            // version 1
            //if (index < 0)
            //{
            //    staffers.Insert((-index) - 1, newStaff);
            //}

            // version 2  Bitwise operation
            if (index < 0)
            {
                staffers.Insert(~index, newStaff);
            }

            foreach (Staff staff in staffers)
            {
                Console.WriteLine($"{staff.Name} is paid {staff.PayGrade}");
            }



        }

     
    }

    // comparing things logic
    public class Staff : IComparable<Staff>
    {
        public string Name { get; set; }
        public int PayGrade { get; set; }

        public int CompareTo(Staff that)
        {
            int result = this.Name.CompareTo(that.Name);
            if (result == 0)
            {
                result = this.PayGrade.CompareTo(that.PayGrade);
            }
            return result;
        }


    }
}
