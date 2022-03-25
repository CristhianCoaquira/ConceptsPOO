namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercetange { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercetange;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentage: {$"{CommissionPercetange:P2}", 18}" +
                $"\n\tSales................: {$"{Sales:C2}", 18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
