// Bring in the Billing namespace
using Billing;

// Set up the order
double subtotal = 49.99;

// Calculate tax and total
double tax = BillingCalculator.CalculateTax(subtotal);
double total = BillingCalculator.CalculateTotal(subtotal, tax);

// Print the receipt
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax:     {tax:C}");
Console.WriteLine($"Total:  {total:C}");





double outOfStateSubtotal = 80.00;
double outOfStateTax = BillingCalculator.CalculateTax(outOfStateSubtotal,0.05);
double outOfStateTotal = BillingCalculator.CalculateTotal(outOfStateSubtotal, outOfStateTax);

Console.WriteLine($"\nOut of State Subtotal: {outOfStateSubtotal:C}");
Console.WriteLine($"Out of State Tax:     {outOfStateTax:C}");
Console.WriteLine($"Out of State Total:  {outOfStateTotal:C}");


