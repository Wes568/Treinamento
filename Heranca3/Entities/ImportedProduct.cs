using System.Globalization;

namespace Heranca3.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee): base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("N2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("N2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
