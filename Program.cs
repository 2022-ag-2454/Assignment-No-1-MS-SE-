﻿
class GFG {
    public static int gcd(int a, int b)
    { if (a == 0)
            return b;

        return gcd(b % a, a);
    }
    public static void main(string[] args)
    {
        int a = 10, b = 15, g;
        g = gcd(a, b);
        System.Out.println("GCD (" + a + " , " + b + ") = " + g);
        a = 35;
        b = 10;
        g = gcd(a, b);
        System.Out.println("GCD (" + a + " , " + b + ") = " + g);
        a = 31;
        b = 2;
        g = gcd(a, b);
        System.Out.println("GCD (" + a + " , " + b + ") = " + g);

    }
}