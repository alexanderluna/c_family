/*
In C you can change the output buffering by setting a buffer to your output
device. The setbuf() function does just that.

With this in mind, guess the output of the following piece of code.
*/

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

/*
After you press any key, this will output:
Wait
Wait
Ok, now
Done

The setbuf() function uses 3 modes to control standard I/O buffering:

1. Unbuffered: sends output immediately to the output device
2. Block buffered: saves text in a buffer and waits for the buffer to be filled
3. Line buffered: saves text in a buffer until a new line is received

By default, setbuf() uses Block buffered. However, for terminals it uses Line
buffered which saves the text in a buffer and waits until something goes
through the standard input.

If you want to set unbuffered text for interactive programs, you can use the
set setvbuf() function.

setvbuf(stdout, buffer, _IONBUF, BUFSIZ);

_IONBUF sets the buffering mode to no buffering.

For truly interactive programs, it is recommended to use the ncurses libray.

https://en.cppreference.com/w/c/io/setbuf
https://en.cppreference.com/w/c/io/setvbuf.html
https://invisible-island.net/ncurses/announce.html
*/