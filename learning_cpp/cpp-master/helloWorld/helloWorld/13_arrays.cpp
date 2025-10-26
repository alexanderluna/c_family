//// arrays [] and multidimentional arrays
//#include <iostream>
//using namespace std;
//
//int main(){
//    
//    // int array with 3 values
//    int intArray[3];
//    intArray[0] = 100;
//    intArray[1] = 200;
//    intArray[2] = 300;
//    
//    cout << "============" << endl;
//    for (int i = 0; i < 3; i++) {
//        cout << "Array" << i << ": " << intArray[i] << endl;
//    }
//    
//    // double array with 3 values
//    double doubleArray[] = {2.3, 2.4, 2.5};
//    
//    cout << "============" << endl;
//    for (int i = 0; i < 3; i++) {
//        cout << "Double" << i << ": " << doubleArray[i] << endl;
//    }
//    
//    // int array - 2 dimensional
//    string stringArray[2][3] = {
//        {"Dog", "Cat", "Bird"},
//        {"Fish", "Monkey", "Eagel"}
//    };
//    
//    cout << "============" << endl;
//    for (int i = 0; i < 2; i++) {
//        for (int j = 0; j < 3; j++) {
//            cout << "Array" << i << ": " << stringArray[i][j] << endl;
//        }
//    }
//    
//    // print multiples of 1..10
//    int array[10][10];
//    cout << "=============================" << endl;
//    for (int i = 1; i <= 10; i++) {
//        for (int j = 1; j <= 10; j++) {
//            array[i][j] = i*j;
//            cout << array[i][j] << " ";
//        }
//        cout << endl;
//    }
//    
//    // use array length in for loop
//    cout << "=============================" << endl;
//    for (int i = 1; i <= sizeof(array)/sizeof(array[0]); i++) {
//        cout << "Array" << i << ": ";
//        for (int j = 1; j <= 10; j++) {
//            cout << array[i][j] << " ";
//        }
//        cout << endl;
//    }
//    
//    string animals [2][3] = {
//        {"one", "two", "three"},
//        {"four", "five", "six"}
//    };
//    
//    for (int i = 0; i < sizeof(animals)/sizeof(animals[0]); i++) {
//        cout << "Animal" << i << ": ";
//        for (int j = 0; j < sizeof(animals[0])/sizeof(string); j++) {
//            cout << animals[i][j] << " ";
//        }
//        cout << endl;
//    }
//    
//}
//
