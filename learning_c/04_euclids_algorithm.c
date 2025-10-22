/*
Euclid's algorithm is based on the principle that the greatest common divisor of
two numbers does not change if the larger number is replaced by its difference
with the smaller number.

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>

int main() {
  int nominator, denominator, larger, smaller, difference;

  printf("Enter a fraction in the following format: A/B: ");
  scanf("%d/%d", &nominator, &denominator);
  printf("%d/%d= ", nominator, denominator);

  larger = nominator > denominator ? nominator : denominator;
  smaller = nominator < denominator ? nominator : denominator;
  difference = larger - smaller;

  while (difference != larger) {
    larger = smaller > difference ? smaller : difference;
    smaller = smaller == larger ? difference : smaller;
    difference = larger - smaller;
  }

  if (difference > 1)
    printf("%d/%d\n", nominator / difference, denominator / difference);
  else
    printf("%d/%d\n", nominator, denominator);

  return 0;
}

/*
Based on your input, this will output the GCD.

There are several ways of finding the GCD between two values. You can calculate
the factor of each value and find the GCD by comparing them:

252 = 1, 2, 3, 4, 6, 7, 9, 12, 14, 18, (21), 28, 36, 42, 63, 84, 126, 252
105 = 1, 3, 5, 7, 15, (21), 35, 105

Another way is by using Euclid's algorithm. Here you calculate the difference
between two values and substract that difference until a new difference is
calculated:

1. 252/105 -> 252 - 105 = 147       (while 147 != 252)
2. 147/105 -> 147 - 105 = 42        (while 42 != 147) - larger=105 smaller=42
3. 105/42  -> 105 - (105 - 42) = 63 (while 63 != 105) - larger=63 smaller=42
4. 63/42   -> 63 - 42 = 21          (while 21 != 63) - larger=42 smaller=21
5. 42/21   -> 42 - 21 = 21          (while 21 != 42) - larger=21 smaller=21
6. 21/21   -> 21 - 21 = 0           (while 0 != 21) - larger=21 smaller=0
7. difference=21 larger=21          (while 21 != 21) breaks out

Since the difference is greater than 1 this will divide the nominator and
denominator by the difference.
*/