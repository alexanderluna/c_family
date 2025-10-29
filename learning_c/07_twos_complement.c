/*

In C you can manipulate integers at a binary level. You can flip all bits of an
integer using the ~ operator.

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>

int main() {
  int a, b;

  printf("Enter a positive number: ");
  scanf("%d", &a);

  b = ~a + 1;

  printf("Result: %d\n", b);

  return (0);
}

/*
this outputs the negative for the number the user puts in.

In C the far left bit of a signed integer is used to indicate a positive or
negative value. 0 means the sign is unset and therefor positive. 1 means the
sign is set there the value is negative.

5   = 0000 0101
-5  = 1111 1011

While it might seem logical to represent -5 as 1000 0101 at first, it doesn't
make sense. When you add 1 to -5 you would get 1000 0110 which would be -6 but
-5 + 1 is -4. In order get the negative integer you have to use Two's Complement
which flips all the bits and adds 1.

5   = 0000 0101
~5  = 1111 1010 = -6
~5+1= 1111 1011 = -6 + 1
-5  = 1111 1011
-4  = 1111 1100 = -5 + 1
*/