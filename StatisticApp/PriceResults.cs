using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    public class PriceResults
    {
        public DateTime PriceDate { get; set; }
        public string AssetName { get; set; }
        public Branch Branch { get; set; }
        public double InitialPrice { get; set; }
        public double FinalPrice { get; set; }
        public double PriceBeforeSold { get; set; }
        public double PriceAfterSold { get; set; }

        public double PriceAverage
        {
            get { return InitialPrice / FinalPrice; }
            
        }
    }

    public enum Branch
    {
        Ikea,
        Amazon,
        HermanMiller
    }

}
