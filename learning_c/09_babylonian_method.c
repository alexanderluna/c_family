/*
There are several methods to calculate the square root of a number and one of
these methods is the Babylonian method (Heron's method).

Try to understand how this method works based on the following piece of code.
*/

#include <stdio.h>

double babylonian(double r) {
  const int precision = 7;
  double low = 1.0;
  double high = r;

  int x;
  for (x = 0; x < precision; x++) {
    high = (high + low) / 2.0;
    low = r / high;
  }

  return (low);
}

int main() {
  double pointer_value, sqr;

  printf("Enter a positive value: \n");
  scanf("%lf", &pointer_value);

  if (pointer_value < 0)
    return (-1);

  sqr = babylonian(pointer_value);
  printf("The result is %.7f\n", sqr);

  return (0);
}

/*
The Babylonian method follows a four step algorithm:

1. Start with a positive integer (for example 125)

2. Calculate the average of the greater and a smaller integer than the √

    (125.00 + 1.00) / 2.0 = 63.00 (new high)

3. Divide the original input (125) by the new high to obtain the new low

    125 / 63 = 1.98 -> 1.98 is the new low

4. Iteratively improve the guess by repeating step 2. and 3.

    high: 125.0000000 + 1.0000000 / 2.0 = 63.0000000      low: 125 / 63.0000000
    high: 63.0000000 + 1.9841270 / 2.0 = 32.4920635       low: 125 / 32.4920635
    high: 32.4920635 + 3.8470933 / 2.0 = 18.1695784       low: 125 / 18.1695784
    high: 18.1695784 + 6.8796313 / 2.0 = 12.5246048       low: 125 / 12.5246048
    high: 12.5246048 + 9.9803548 / 2.0 = 11.2524798       low: 125 / 11.2524798
    high: 11.2524798 + 11.1086624 / 2.0 = 11.1805711      low: 125 / 11.1805711
    high: 11.1805711 + 11.1801086 / 2.0 = 11.1803399      low: 125 / 11.1803399

    √1250 = 11.1803399

You can increase the accuracy by increasing the precision constant but at a
point adding more precision becomes meaningless because the result is close
enough.
*/