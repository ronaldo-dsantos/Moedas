using System.Globalization;

Console.Clear();

decimal valor = 10536.75m; // Tipo decimal é o mais indicado para trabalhar com moedas

Console.WriteLine(valor.ToString(
  "C", // "N" para números e "C" para moedas 
  CultureInfo.CreateSpecificCulture("pt-BR"))); // Formatando valor de acordo com a moeda local

Console.WriteLine(Math.Round(valor)); // Math.Round para arredondar valor de acordo com a casa decimal

Console.WriteLine(Math.Ceiling(valor)); // Math.Ceilin para arredondar valor para cima

Console.WriteLine(Math.Floor(valor)); // Math.Floor para arredondar valor para baixo
