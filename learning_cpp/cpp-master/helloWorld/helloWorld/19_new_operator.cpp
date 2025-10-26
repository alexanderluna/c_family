//// new operator
//#include <iostream>
//using namespace std;
//
//class Animal {
//private:
//    string name;
//    
//public:
//    Animal() {
//        cout << "Animal created" << endl;
//    }
//    
//    Animal(const Animal& other): name(other.name) {
//        cout << "Animal created by copying" << endl;
//    }
//    
//    ~Animal() {
//        cout << "Animal destroyed" << endl;
//    }
//    
//    void setName(string name) {
//        this->name = name;
//    }
//    
//    void speak() const {
//        cout << "My name is: " << name << endl;
//    }
//};
//
//
//int main(){
//    Animal cat;
//    cat.setName("Garfield");
//    cat.speak();
//    
//    cout << endl;
//    
//    Animal *pCat = new Animal();
//    pCat->setName("Jimmy");
//    pCat->speak();
//    delete pCat;
//    
//    cout << sizeof(pCat) << endl;
//    
//    return 0;
//    
//}
//
//
