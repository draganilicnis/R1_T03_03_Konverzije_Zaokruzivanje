// R1 T03: Promenljive, podaci, tipovi
// R2 T03.03: Konverzije numerickih tipova i zaokrugljivanje
// https://sr.wikipedia.org/wiki/IEEE_754
// https://petlja.org/sr-Latn-RS/kurs/17862/6/ 
// https://www.h-schmidt.net/FloatConverter/IEEE754.html
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types?source=recommendations
// https://juliensobczak.com/inspect/2019/03/10/floating-point-numbers-demystified/
// https://www.sciencedirect.com/topics/computer-science/floating-point-addition
// https://www.electronics-lab.com/article/binary-fractions/

using System;

class R1_T03_03_Konverzije_Zaokruzivanje_Gubitak_tacnosti
{
    static void Main()
    {
        Console.WriteLine("{0:F}", 9007199254740993.0);
        Console.WriteLine("{0:R}", 9007199254740993.0);
    }


    
    static void Main_Menu()
    {
        // Tip_Realan_broj();
        // Tip_Realan_broj_Primeri();
        // Tip_Realan_broj_ispis_Write();
        Main_Print();
    }
    static void Tip_Realan_broj_Primeri()
    {
        Console.WriteLine("Tip_Realan_broj_Primeri");
        Console.WriteLine(0.3 / 0.1);   // ispisuje: 4.44089209850063E-16 
        Console.WriteLine(0.2 + 0.1);
        Console.WriteLine(0.2 + 0.1 - 0.3);
        double d1 = 0.1;
        double d2 = 0.2;
        double d3 = 0.3;
        double d4 = d1 + d2;
        double d5 = d4 - d3;
        Console.WriteLine(d4);
        Console.WriteLine(d5);
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
        Console.WriteLine("{0:X}", 25);
    }

    // **********************************************************
    // https://chatgpt.com/c/68e0b66b-4688-8331-8fd0-d7e813d5b5ac
    static void Tip_Realan_broj_ispis_Write()
    {
        double d1 = 0.1, d2 = 0.2, d3 = 0.3, d5 = 0.5;
        decimal m1 = 0.1m, m2 = 0.2m, m3 = 0.3m, m5 = 0.5m;

        Console.WriteLine("Broj    |   double                     |   decimal");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"0.1     | {d1:R}   | {m1}");
        Console.WriteLine($"0.2     | {d2:R}   | {m2}");
        Console.WriteLine($"0.3     | {d3:R}   | {m3}");
        Console.WriteLine($"0.5     | {d5:R}   | {m5}");

        Console.WriteLine();
        Console.WriteLine("Zbir / poredjenje:");
        Console.WriteLine($"0.1 + 0.2 (double)  = {d1 + d2}");
        Console.WriteLine($"0.1m + 0.2m (decimal) = {m1 + m2}");

        Console.WriteLine($"0.3 / 0.1 (double)  = {d3 / d1}");
        Console.WriteLine($"0.3m / 0.1m (decimal) = {m3 / m1}");
    }


    // **********************************************************
    // https://chatgpt.com/c/68e0b66b-4688-8331-8fd0-d7e813d5b5ac
    // **********************************************************
    static void PrintDouble(double value, string name)
    {
        long bits = BitConverter.DoubleToInt64Bits(value);
        string binary = Convert.ToString(bits, 2).PadLeft(64, '0');
        Console.WriteLine($"{name,-6} (double): {value:R}");
        Console.WriteLine($"   Hex: 0x{bits:X16}");
        Console.WriteLine($"   Bin: {binary}");
    }

    static void PrintDecimal(decimal value, string name)
    {
        int[] bits = decimal.GetBits(value);    // decimal koristi 128 bita (96 za mantisu + 1 bajt za skalu + znak)
        string hex = string.Join(" ", Array.ConvertAll(bits, b => $"0x{b:X8}"));
        Console.WriteLine($"{name,-6} (decimal): {value}");
        Console.WriteLine($"   Bits: {hex}");
    }

    static void Main_Print()
    {
        double d1 = 0.1, d2 = 0.2, d3 = 0.3, d5 = 0.5, d6 = 1.0, d7 = 1.5, d8 = 2.0, d9 = 3.0, d10 = 0.25;
        decimal m1 = 0.1m, m2 = 0.2m, m3 = 0.3m, m5 = 0.5m, m6 = 1.0m, m7 = 1.5m, m8 = 2.0m, m9 = 3.0m, m10 = 0.25m;

        Console.WriteLine("=== DOUBLE ===");
        PrintDouble(d1, "0.1");
        PrintDouble(d2, "0.2");
        PrintDouble(d3, "0.3");
        PrintDouble(d5, "0.5");
        PrintDouble(d6, "1.0");
        PrintDouble(d7, "1.5");
        PrintDouble(d8, "2.0");
        PrintDouble(d9, "3.0");
        PrintDouble(d10, "0.25");

        Console.WriteLine("\n=== DECIMAL ===");
        PrintDecimal(m1, "0.1");
        PrintDecimal(m2, "0.2");
        PrintDecimal(m3, "0.3");
        PrintDecimal(m5, "0.5");
        PrintDecimal(m6, "1.0");
        PrintDecimal(m7, "1.5");
        PrintDecimal(m8, "2.0");
        PrintDecimal(m9, "3.0");
        PrintDecimal(m10, "0.25");

        Console.WriteLine("\n=== OPERACIJE ===");
        Console.WriteLine($"0.1 + 0.2 (double)  = {d1 + d2}");
        Console.WriteLine($"0.1m + 0.2m (decimal) = {m1 + m2}");
        Console.WriteLine($"0.3 / 0.1 (double)  = {d3 / d1}");
        Console.WriteLine($"0.3m / 0.1m (decimal) = {m3 / m1}");
    }
}
