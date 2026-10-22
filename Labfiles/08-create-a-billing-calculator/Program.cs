// Bring in the Billing namespace
using Billing;

// Set up the order
double subtotal = 49.99;

// Calculate tax and total
double tax = BillingCalculator.CalculateTax(subtotal);
double total = BillingCalculator.CalculateTotal(subtotal, tax);

// Print the receipt

 Console.WriteLine($"Subtotal: {subtotal:C}");
 Console.WriteLine($"Tax:      {tax:C}");
 Console.WriteLine($"Total:    {total:C}");

 
double outofstateSubtotal = 80.00;
double outofstateTax = BillingCalculator.CalculateTax(outofstateSubtotal , 0.05);
double outofstateTotal = BillingCalculator.CalculateTotal(outofstateSubtotal, outofstateTax);

Console.WriteLine($"\nOut-of-state subtotal: {outofstateSubtotal:C}");
Console.WriteLine($"Out-of-state tax:      {outofstateTax:C}");
Console.WriteLine($"Out-of-state total:    {outofstateTotal:C}");
