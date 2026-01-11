string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");

Console.WriteLine($"As a customer of {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");

Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:N2}\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

string currentReturnText = currentReturn.ToString("P2");

Console.WriteLine($"{currentProduct.PadRight(20)}{currentReturnText.PadRight(9)}{currentProfit:C2}");

string newReturnText = newReturn.ToString("P2");

Console.WriteLine($"{newProduct.PadRight(20)}{newReturnText.PadRight(9)}{newProfit:C2}");

Console.WriteLine(comparisonMessage);

