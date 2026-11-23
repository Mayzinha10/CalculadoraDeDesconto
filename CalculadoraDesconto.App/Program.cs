using CalculadoraDesconto.App;
var calculadora = new CalculadoraDescontos();
Console.Write("Preço: ");
decimal preco = Convert.ToDecimal(Console.ReadLine());
Console.Write("Desconto (%): ");
decimal percentual = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Total: {calculadora.Calcular(preco, percentual):C}");
