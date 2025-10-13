// R1 T03: Promenljive, podaci, tipovi
// R2 T03.03: Konverzije numerickih tipova i zaokrugljivanje
// https://petlja.org/sr-Latn-RS/kurs/17862/6/1322#id7      // Kurs na Petlji za 1. razred
// https://petlja.org/sr-Latn-RS/kurs/17862/4/1314          // Kurs na Petlji za 1. razred 3.1. Realni brojevi
// https://sr.wikipedia.org/wiki/IEEE_754
// https://www.h-schmidt.net/FloatConverter/IEEE754.html
// https://numeral-systems.com/ieee-754-converter/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types?source=recommendations
// https://learn.microsoft.com/en-us/cpp/build/ieee-floating-point-representation?view=msvc-170
// https://juliensobczak.com/inspect/2019/03/10/floating-point-numbers-demystified/
// https://www.sciencedirect.com/topics/computer-science/floating-point-addition
// https://www.electronics-lab.com/article/binary-fractions/
// https://github.com/draganilicnis/R1_T03_03_Konverzije_Zaokruzivanje
// https://onlinegdb.com/3xXm9f2-Y

#include <iostream>
using namespace std;
#include <iomanip>  // za setprecision

int main()
{
    cout << 0.1 + 0.2 << endl;          // 0.3
    cout << 0.3 / 0.1 << endl;          // 3
    cout << 0.1 + 0.2 - 0.3 << endl;    // 5.55112e-17
    cout << 3 - 0.3 / 0.1 << endl;      // 4.44089e-16
    cout << 9007199254740993.0 << endl; // 9.0072e+15
    cout << 9007199254740993.0 - 9007199254740992.0 << endl;  // 0
    cout << 9007199254740993 - 9007199254740992 << endl;      // 1
    cout << fixed << setprecision(2) << 9007199254740993.0 << endl; // 9007199254740992.00
    cout << 1.0/10 + 2.0/10 - 3.0/10 << endl;       // 0.00
    cout << 1/10.0 + 2/10.0 - 3/10.0 << endl;       // 0.00
    cout << 1.0/10.0 + 2.0/10.0 - 3.0/10.0 << endl; // 0.00
    cout << 1.0/10.0 << endl;                       // 0.10
    return 0;
}
