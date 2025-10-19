
#include <stdio.h>
#include <stdlib.h>

int main() {
  char buffer[BUFSIZ];

  setbuf(stdout, buffer);

  puts("Wait");
  puts("Wait");
  puts("Ok, now");
  getchar();
  puts("Done");

  return EXIT_SUCCESS;
}