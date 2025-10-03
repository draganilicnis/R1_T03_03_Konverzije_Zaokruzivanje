// R1 T03: Promenljive, podaci, tipovi
// R2 T03.03: Konverzije numerickih tipova i zaokrugljivanje
// https://sr.wikipedia.org/wiki/IEEE_754
// https://petlja.org/sr-Latn-RS/kurs/17862/6/ 
// https://www.h-schmidt.net/FloatConverter/IEEE754.html
// https://github.com/draganilicnis/R1_T03_03_Konverzije_Zaokruzivanje/blob/main/R1_T03_03_Konverzije_Zaokruzivanje.cs

using System;

class R1_T03_03_Konverzije_Zaokruzivanje
{
    static void Main()
    {
        Tip_Realan_broj();
    }

    static void Tip_Realan_broj()
    {
        Console.WriteLine("Realni brojevi: double, float, decimal");
        Tip_Realan_broj_double();
    }

    static void Tip_Realan_broj_double()
    {
        Console.WriteLine("double");
        double a = double.MaxValue;
        Console.WriteLine(a);
        Tip_Realan_broj_double_Preciznost();
        double b = 1e16;    // 1e15
        Tip_Realan_broj_double_Preciznost(b);
    }
    static void Tip_Realan_broj_double_Preciznost()
    {
        Console.WriteLine("Tip_Realan_broj_double_Preciznost:");
        Console.WriteLine("1e0 + 1 - 1e0");
        Console.WriteLine(1e0 + 1 - 1e0);
        Console.WriteLine(1e7 + 1 - 1e7);
        Console.WriteLine(1e8 + 1 - 1e8);
        Console.WriteLine(1e10 + 1 - 1e10);
        Console.WriteLine(1e16 + 1 - 1e16);
    }
    static void Tip_Realan_broj_double_Preciznost(double a)
    {
        Console.WriteLine("Tip_Realan_broj_double_Preciznost(1e16 + 1):");
        double b = a + 1;
        double r = a - b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(r);
        a = a / 10;
        b = a + 1;
        r = a - b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(r);
    }
}
