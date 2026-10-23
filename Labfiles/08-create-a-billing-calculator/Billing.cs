namespace Billing
{
    public static class BillingCalculator
    {
        // Method to calculate tax based on subtotal and tax rate
        public static double CalculateTax(double subtotal, double taxRate = 0.08)
        {
            return subtotal * taxRate;
        }

        // Method to calculate total based on subtotal and tax
        public static double CalculateTotal(double subtotal, double tax)
        {
            return subtotal + tax;
        }
    }
}