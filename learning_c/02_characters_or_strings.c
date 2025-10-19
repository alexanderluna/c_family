/*
A character array hold single characters but aren't strings. Strings have a
null '\0' at the end which terminates them.

With this in mind, guess the output of the following piece of code.
*/

#include <stdio.h>
#include <stdlib.h>

int main() {
  char a_bunch_of_characters[] = {'h', 'e', 'l', 'l', 'o', ' ',
                                  'w', 'o', 'r', 'l', 'd'};

  char data[] = {127, 129, 255};

  printf("%s\n", a_bunch_of_characters);

  return EXIT_SUCCESS;
}

/*
If you are lucky, this outputs: hello world

Strings have a terminating null character. When you use printf(), the function
expects to find a terminating null character. If it doesn't find it, it will
keep printing until it finds a null character in the existing memory garbage.
That is why it is important terminate your array of characters or you risk
creating an error or even worse, a security vulnerability.

the data array exists to fill the next 16-byte chunk with garbage.
*/