double c;
double f;

Console.Clear();

Console.Write ("Digite sua temperatura em °C = ");
c = Convert.ToDouble(Console.ReadLine());

f = c * 1.8 + 32;

Console.WriteLine($"{c}ºC equivalente a {f}ºF");