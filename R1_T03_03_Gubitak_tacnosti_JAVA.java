public class Main    // Java OnLine GDB
{
    public static void main(String[] args) 
    {
        System.out.println(0.1 + 0.2);                               // 0.30000000000000004
        System.out.println(0.3 / 0.1);                               // 2.9999999999999996
        System.out.println(0.1 + 0.2 - 0.3);                         // 5.551115123125783E-17
        System.out.println(3 - 0.3 / 0.1);                           // 4.440892098500626E-16
        System.out.println(9007199254740993.0);                      // 9.007199254740992E15
        System.out.println(9007199254740993.0 - 9007199254740992.0); // 0.0
        System.out.println(9007199254740993L - 9007199254740992L);   // 1
        System.out.printf("%.17g%n", 9007199254740993.0);            // 9007199254740992.0
        System.out.printf("%.2f%n", 9007199254740993.0);             // 9007199254740992.00
        System.out.println(1.0 / 10 + 2.0 / 10 - 3.0 / 10);          // 5.551115123125783E-17
        System.out.println(1 / 10.0 + 2 / 10.0 - 3 / 10.0);          // 5.551115123125783E-17
        System.out.println(1.0 / 10.0 + 2.0 / 10.0 - 3.0 / 10.0);    // 5.551115123125783E-17
        System.out.println(1.0 / 10.0);                              // 0.1
    }
}
