using System;

class Trojkat
{
    // Pola
    private double bokA;
    private double bokB;
    private double bokC;

    // Konstruktory
    public Trojkat(double a, double b, double c)
    {
        if (CzyTrojkatJestPoprawny(a, b, c))
        {
            bokA = a;
            bokB = b;
            bokC = c;
        }
        else
        {
            throw new ArgumentException("Podane długości boków nie spełniają warunku istnienia trójkąta.");
        }
    }

    // Metoda obliczająca pole trójkąta za pomocą wzoru Herona
    public double ObliczPole()
    {
        double polowaObwodu = ObliczObwod() / 2;
        return Math.Sqrt(polowaObwodu * (polowaObwodu - bokA) * (polowaObwodu - bokB) * (polowaObwodu - bokC));
    }

    // Metoda obliczająca obwód trójkąta
    public double ObliczObwod()
    {
        return bokA + bokB + bokC;
    }

    // Metoda sprawdzająca, czy podane długości boków spełniają warunek istnienia trójkąta
    private bool CzyTrojkatJestPoprawny(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    }

    // Metoda ToString() zwracająca informacje o trójkącie
    public override string ToString()
    {
        return $"Bok A: {bokA}, Bok B: {bokB}, Bok C: {bokC}, Pole: {ObliczPole()}, Obwód: {ObliczObwod()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektu trójkąta
        try
        {
            Trojkat trojkat = new Trojkat(3, 4, 5);

            // Testowanie metod
            Console.WriteLine(trojkat);
            Console.WriteLine($"Pole: {trojkat.ObliczPole()}");
            Console.WriteLine($"Obwód: {trojkat.ObliczObwod()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
    }
}
