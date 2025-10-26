//// static keyword
//// good to declare constants
//#include <iostream>
//
//using namespace std;
//
//// .h file
//class Test {
//private:
//    int id;
//    static int count;
//public:
//    Test() { id = ++count; }
//    static void showInfo() { cout << count << endl; }
//    int getId() {return id; }
//};
//
//// .cpp file
//int Test::count = 0;
//
//
//int main(){
//    
//    Test::showInfo();
//    
//    Test test1;
//    cout << "Object 1 ID: " << test1.getId() << endl;
//    
//    Test test2;
//    cout << "Object 2 ID: " << test2.getId() << endl;
//    
//    Test::showInfo();
//    
//    return 0;
//}
