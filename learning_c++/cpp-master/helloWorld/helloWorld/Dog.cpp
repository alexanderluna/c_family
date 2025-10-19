#include "Dog.h"

using namespace std;

namespace dogs {

    Dog::Dog() {
        // dog created
    }

    Dog::~Dog() {
        // dog destroyed
    }

    void Dog::speak() {
        cout << "Wuff" << endl;
    }
}
