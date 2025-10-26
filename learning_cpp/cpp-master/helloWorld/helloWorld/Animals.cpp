#include "Animals.h"

namespace alexander {
    Dog::Dog() {
        // dog created using namespace
    }

    Dog::~Dog() {
        // dog destroyed using namespace
    }
    
    void Dog::speak() {
        cout << "Wuff - from namespace" << endl;
    }
}
