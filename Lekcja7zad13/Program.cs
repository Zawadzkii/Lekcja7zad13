using System;

class Program
{
	static void Main(string[] args)
	{
		double liczba1, liczba2, wynik;
		int operacja;

		Console.WriteLine("Podaj pierwszą liczbę:");
		liczba1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Podaj drugą liczbę:");
		liczba2 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Wybierz operację do wykonania:");
		Console.WriteLine("1. Dodawanie");
		Console.WriteLine("2. Odejmowanie");
		Console.WriteLine("3. Mnożenie");
		Console.WriteLine("4. Dzielenie");

		operacja = Convert.ToInt32(Console.ReadLine());

		switch (operacja)
		{
			case 1:
				wynik = liczba1 + liczba2;
				Console.WriteLine($"Twój wynik to: {wynik}");
				break;
			case 2:
				wynik = liczba1 - liczba2;
				Console.WriteLine($"Twój wynik to: {wynik}");
				break;
			case 3:
				wynik = liczba1 * liczba2;
				Console.WriteLine($"Twój wynik to: {wynik}");
				break;
			case 4:
				if (liczba2 != 0)
				{
					wynik = liczba1 / liczba2;
					Console.WriteLine($"Twój wynik to: {wynik}");
				}
				else
				{
					Console.WriteLine("Nie można dzielić przez zero.");
				}
				break;
			default:
				Console.WriteLine("Niepoprawny wybór operacji.");
				break;
		}
	}
}