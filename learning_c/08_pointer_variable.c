/*

In C pointing to a data type creates a pointer variable.

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
  struct raw {
    int value;
    char string[32];
  };

  FILE *outfile;
  struct raw *data;

  data = malloc(sizeof(struct raw));
  data->value = 60;
  strcpy(data->string, "This is a string \n");

  outfile = fopen("data.dat", "w");
  if (outfile == NULL)
    exit(1);
  fwrite(data, sizeof(data), 1, outfile);
  fclose(outfile);
  puts("File written");

  free(data);
  return (0);
}

/*
This outputs:
00000000  80 5d 60 5b 01 00 00 00
00000008

A pointer variable is a pointer and not a structure. Therefore, using the sizeof
operator on a pointer will return the size of the pointer in memory namely its
address.

The fix is as simple as using the sizeof operator on the raw struct itself:

fwrite(data, sizeof(struct raw), 1, outfile);


Refer to the sections "Memory and Pointers" in the README.md for more
information about Pointer variables and how they work.
*/