//// char arrays
//#include <iostream>
//using namespace std;
//
//int main(){
//    
//    /*
//     Working with basic characters
//     and array structure
//     1. loop: loop character
//     2. loop: cast character into int (ascii code)
//     3. loop: characters using 0 return from array
//     */
//    
//    char text[] = "hello";
//    
//    for (int i = 0; i < sizeof(text); i++) {
//        cout << i << ": " << text[i] << endl;
//    }
//    cout << "\n=======================" <<endl;
//    
//    for (int i = 0; i < sizeof(text); i++) {
//        cout << i << ": " << (int)text[i] << endl;
//    }
//    cout << "\n=======================" <<endl;
//    
//    int k = 0;
//    while (true) {
//        if(text[k] == 0)
//            break;
//        cout << text[k] << flush;
//        k++;
//    }
//    cout << "\n=======================" <<endl;
//    
//    
//    
//    /*
//     Working character arrays
//     1. loop: reverse string
//     2. loop: reverse string using pointer
//     */
//    
//    for (int i = 5; i >= 0; i--) {
//        cout << text[i] << endl;
//    }
//    cout << "=======================" <<endl;
//    
//    char newText[] = "hello";
//    int len = sizeof(text) -1;
//    
//    char *pTextStart = newText;
//    char *pTextEnd = newText + len - 1;
//    
//    while (pTextStart < pTextEnd) {
//        
//        char saveChar = *pTextStart;
//        
//        *pTextStart = *pTextEnd;
//        *pTextEnd = saveChar;
//        
//        pTextStart++;
//        pTextEnd--;
//    }
//    
//    cout << newText << endl;
//}
//
//
