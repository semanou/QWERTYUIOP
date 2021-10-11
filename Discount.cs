using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Discount
    {
        private int Nb;
        private double Ratio;

        public Discount(int nb, double price)
        {
            this.Nb = nb;
            this.Ratio = price;
            
        }

        public bool CanBeApplied(Basket b)
        {
            return b.HowManyDifferent() >= Nb;

        }

        public double Apply(double basePrice)
        {
            return basePrice * (Nb) * Ratio;
        }

        public Basket RemovePaidBooks(Basket b)
        {
            return b.RemoveDifferent(this.Nb);
        }
    }
}