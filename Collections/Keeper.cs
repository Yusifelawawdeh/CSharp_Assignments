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

        public override int GetHashCode()
        {
            return Name.GetHashCode() + BlockLevel.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Keeper that = obj as Keeper;
            if (that == null)
            {
                return false;
            }

            return this.Name == that.Name && this.BlockLevel == that.BlockLevel;
        }

    }
}