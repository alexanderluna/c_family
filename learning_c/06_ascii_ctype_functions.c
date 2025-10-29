/*
C has ctype functions to convert strings to upper or lower case.
However, the way ASCII is designed, upper and lower case letters are 32 apart or
0x20 hexadecimal:

A = 65
a = 97

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>

int main() {
  char a;

  for (a = 'A'; a < 'Z'; a++)
    putchar(a | 0x20);
  putchar('\n');

  for (a = 'a'; a < 'z'; a++)
    putchar(a & 0xdf);
  putchar('\n');

  return (0);
}

/*
This outputs:
abcdefghijklmnopqrstuvwxy
ABCDEFGHIJKLMNOPQRSTUVWXY

The | and & are bitwise logical operators. Using 0x20 (00100000) you can flip
the 6th bit from the right to convert "A" into "a":

A     01000001
0x20  00100000 (bitwise or |)
--------------
      01100001 = a

Similarly you can convert "a" into "A" using the reverse approach flipping the
6th bit from the right to zero.

a     01100001
0dxf  11011111 (bitwise and &)
--------------
      01000001 = A
*/