#include <iostream>
#include "Header.h"
#include <math.h>

int main()
{
    double k = sqrt(-3);

    struct Mytype { int t1; };
    Mytype t;
    std::cout << t.t1;

    int* a = new int; 
    int* b = new int[2]; 
    delete b;
    delete[] a;

    double d = Divide(5, 0);

    double d1 = 0.67;
    int a = d1;
    
    int* p = 0;
    ptr(p);

    bool neg = isNegative(1);
    WhileIncorect();
    ForIncorrect();

    return 0;
}

