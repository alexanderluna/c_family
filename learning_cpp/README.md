# Learning C++

## The Basics

C++ is a statically typed and compiled language, meaning that your source code
has to be compiled into an object files which are then combined by a linker
creating an executable. Each executable is created for a specific
hardware/system (non portable). Nonetheless, we do talk about C++ portability in
terms of source code which can be compiled and run on a variety of systems. The
ISO C++ standard defines two kinds of entities.

1. Core languages features (built-in types):
2. Standard-library components (container, I/O operations): provided by C++ implementation

Your typical C++ program looks like this:

```cpp
// makes standard library declarations available in your program
#include <iostream>;

using namespace std;

// the main function is your required entry point
// with an int return value to the system
int main() {
    cout << "Greeting from C++\n";
}
```

**Function** declarations have a name, return type and the types of the
arguments that must be supplied in a call. Functions can be a member of a class
in which case the name of its class is also part of the function type. C++ also
supports **function overloading** (multiple functions with the same name).

```cpp
double get(const vector<double>& vec, int index);

char& String::operator[](int index);

// the compiler choses the most appropriate for each call.
void print(int);
void print(double);
void print(string)
```

Every name and expression has a type that limits the operations it can perform.
A declaration introduces an entity into the program and specifies the type:

- type: set of possible values and operations with a fixed size
- object: memory that holds a value
- value: bits interpreted as a type
- variable: named object

C++ offers a long list of **fundamental types** and **arithmetic operators**.
For a complete list reference the C++ Reference:

- [Fundamental types](https://en.cppreference.com/w/cpp/language/types.html)
- [Arithmetic operators](https://en.cppreference.com/w/cpp/language/operator_arithmetic.html)

Before you can use an object you have to **initialize** it and C++ has several
ways of accomplishing this:

```cpp
double rate = 5.5;      // traditional
double rate {5.5};      // preferred
double rate = {5.5};

auto playable = true;
auto firstCharacter = 'a';
auto year = 1980;
```

> The `{}` is preferred because it will throw an error early if the value
> doesn't match the type while the `=` will try to convert the type and result
> in unexpected behavior.

Each declaration introduces its name into a **scope**:

1. local scope: declared in a function or lambda
2. class scope: a member name defined within a class
3. namespace scope: defined within a namespace but outside any other scope

You can declare two types of **immutability**. One with `const` and another with
`constexpr`. Functions declared `constexpr` or `consteval` are the C++ version
of a **pure function**.

```cpp
constexpr double nth(double x, int n)
{
    // own local variables
    double res = 1;
    int i = 0;

    // can use loops
    while (i < n) {
        res *= x;
        ++i;
    }

    return res;
}
```

You can allocate a contiguous sequence of objects in memory using an **array**,
**pointers** and **references**. An array has to declare its type and size.

```cpp
char name[10];              // an array of 10 characters

char* initial = &name[0];   // initial points to the 1st element of name

char* end = nullptr;
```

> `*` means "contents of" and `&` means "address of". If you don't have an
> object to point to you can use the **null pointer** `nullptr`.

You loop over an array with a **for loop** or **while loop**:

```cpp
char name[10] = {'a', 'l', 'e', 'x', 'a', 'n', 'd', 'e', 'r'};

for (auto c=0; c!=10; ++c)
    cout << name[c] << '\n';

for (auto &letter : name)
    cout << letter << '\n';
```

> When you don't want to modify an argument and don't want to copy a value, you
> can use a **const reference**. When you use them in declarations, the
> operators (&, *, []) are called **declarator operators**.

You can control the flow of your program with `if` and `switch` statements:

```cpp
if (answer == true)
    cout << "OK" << '\n';

switch (answer) {
    case 'yes':
        cout << "OK,  let's do that" << '\n';
        break;
    case 'no':
        cout << "Too bad,  let's not do that" << '\n';
        break;
    default:
        cout << "I don't know what you mean" << '\n';
        return false;
}
```

## User-Defined Types
