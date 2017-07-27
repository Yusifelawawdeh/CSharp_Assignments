namespace StatisticApp
{
    public class Keeper : System.IComparable<Keeper>
    {
        public string Name { get; set; }
        public int BlockLevel { get; set; }

        public int CompareTo(Keeper that)
        {

            int result = this.Name.CompareTo(that.Name);
            if (result == 0)
            {
                result = this.BlockLevel.CompareTo(that.BlockLevel);
            }
            return result;
        }

    }
}