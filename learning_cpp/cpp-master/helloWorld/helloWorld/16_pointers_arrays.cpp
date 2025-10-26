//// pointer, arrays and arithmetic
//#include <iostream>
//using namespace std;
//
//void changeDouble(double *pDoubleValue){
//    cout << "2. Double value (pointer): " << *pDoubleValue << endl;
//    *pDoubleValue = 10.0;
//    cout << "3. Double value (pointer): " << *pDoubleValue << endl;
//}
//
//int main(){
//    
//    /*
//     //declare pointer and play with it
//     // print pointer memory
//     // print pointer value
//     */
//    int number = 6;
//    int* pnumber = &number;
//    
//    cout << "Number is: " << number << endl;
//    cout << "Number pointer Memory is: " << pnumber << endl;
//    cout << "Number pointer value is: " << *pnumber << endl;
//    cout << "=========================" << endl;
//    
//    
//    /*
//     // Use pointer with doubles
//     // print value
//     // print value after changing pointer value
//     */
//    double doubleValue = 13.5;
//    cout << "1. Double value (variable): " << doubleValue << endl;
//    changeDouble(&doubleValue);
//    cout << "4. Double value (variable): " << doubleValue << endl;
//    cout << "=========================" << endl;
//    
//    
//    /*
//     // loop through array
//     // loop the simple way
//     // ptext stores the memory location
//     // *ptext is the pointer itself
//     */
//    string text[] = {"One", "Two", "Three"};
//    string *ptext = text;
//    
//    for (int i = 0; i < sizeof(text)/sizeof(string); i++) {
//        cout << text[i] << " " << flush;
//    }
//    cout << "\n=========================" << endl;
//    
//    
//    /*
//     // loop through array using pointer
//     // increment pointer to point next value
//     // ptext stores the memory location
//     // *ptext is the pointer itself
//     */
//    for (int i = 0; i < sizeof(text)/sizeof(string); i++, ptext++) {
//        cout << *ptext << " " << flush;
//    }
//    cout << "\n=========================" << endl;
//    
//    
//    /*
//     // loop through array using pointer
//     // set start and ending of array
//     // break while loop when both are the same
//     // increment pointer until end of arrays is reached
//     */
//    string *pItem = &text[0];
//    string *pEndItem = &text[2];
//    
//    while (true) {
//        cout << *pItem << " " << flush;
//        if (pItem == pEndItem) {
//            break;
//        }
//        pItem++;
//    }
//}
//
//
