/*
C doesn't automatically check array bounds.

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
  int array[5];
  int x;

  srand((unsigned)time(NULL));

  for (x = 0; x < 12; x++) {
    array[x] = rand() % 100;
    printf(" %d", array[x]);
  }

  putchar('\n');

  return (0);
}

/*
The result are random numbers and an error.

C doesn't check the array bound while the for loop keeps adding items to the
array. This behavior can result in security problems and exploits. You can avoid
this problem by setting the array size to a constant or defined constant.

#define SIZE 5

const int size = 5;
*/