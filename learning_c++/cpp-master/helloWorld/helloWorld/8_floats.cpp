//// floating point types
//#include <iostream>
//#include <iomanip>
//#include <cfloat>
//using namespace std;
//
//int main(){
//    // float declaration
//    float floatNumber = 75.4;
//    // double declaration
//    double doubleNumber = 75.666666;
//    // long double declaration
//    long double longDoubleNumber = 75.7777777;
//    
//    // requires #include <iomanip>
//    // Normal: printed as written
//    // Fixed: changed to reflect the amount of decimals stored
//    // Scientific: changed to scientific decimals
//    // Amount of decimals can be specified using setprecision(n)
//    cout << "Float number (normal): " << floatNumber << endl;
//    cout << "Double number (normal): " << doubleNumber << endl;
//    cout << "Long Double number (normal): " << longDoubleNumber << endl;
//    
//    cout << fixed << "\nFloat number (fixed): " << floatNumber << endl;
//    cout << fixed << "Double number (fixed): " << doubleNumber << endl;
//    cout << fixed << "Long Double number (fixed): " << longDoubleNumber << endl;
//    
//    cout << setprecision(20) << fixed << "\nFloat number (fixed 20): " << floatNumber << endl;
//    cout << setprecision(20) << fixed << "Double number (fixed 20): " << doubleNumber << endl;
//    cout << setprecision(20) << fixed << "Long Double number (fixed 20): " << longDoubleNumber << endl;
//    
//    cout << scientific << "\nFloat number (scientific): " << floatNumber << endl;
//    cout << scientific << "Double number (scientific): " << doubleNumber << endl;
//    cout << scientific << "Long Double number (scientific): " << longDoubleNumber << endl;
//    
//    
//    cout << "\nFloat byte size: " << sizeof(float) << endl;
//    cout << "Double byte size: " << sizeof(double) << endl;
//    cout << "Long Double byte size: " << sizeof(long double) << endl;
//    
//    cout << "\nMin float: " << FLT_MIN << endl;
//    cout << "Min double: " << DBL_MIN << endl;
//    cout << "Min long double: " << LDBL_MIN << endl;
//    
//    cout << "\nMax float: " << FLT_MAX << endl;
//    cout << "Max double: " << DBL_MAX << endl;
//    cout << "Max long double: " << LDBL_MAX << endl;
//    
//}
