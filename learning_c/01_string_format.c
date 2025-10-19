/*
math.h has a constant for the first 20 digits of π

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int n;

    n = printf("π is %2.4f", M_PI);
    printf(" (That is %d characters)\n", n);

    return EXIT_SUCCESS;
}

/*
This outputs: π is 3.1416 (That is 12 characters)

The %2.4f placeholder formats a float (%[significant].[decimal]f) to output a
maximum of 6 digits. 2 digits before the period and 4 digits after the period.
Also notice that the last digit is rounded not trunk. It is also possible to
pass an expression as an argument if you properly typecast the variables.

int a, b;
a = 5
b = 4
printf("%d/%d = %f", a, b, (float)a/b)

The functions return value is the number of characters in the output. That is
why we can save the return value of printf and use it to print the next
statement.
*/