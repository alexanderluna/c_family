#ifndef Dog_h
#define Dog_h

#include <iostream>
using namespace std;

namespace dogs {

    class Dog {
    public:
        Dog();
        virtual ~Dog();
        void speak();
    };
}

#endif /* Dog_hpp */
