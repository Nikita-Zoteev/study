#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B, C;

    cout << "Введите A, B и C: ";

    cin >> A >> B >> C;

    if (A > B && A > C)
    {
        if (pow(A, 2) == pow(B,2) + pow(C, 2))
        {
            cout << "Высказывание истино" << endl;
        }
        else
        {
            cout << "Высказывание ложное " << endl;
        }
    }
    else if (B > C && B > A)
    {
        if (pow(B, 2) == pow(A, 2) + pow(C, 2))
        {
            cout << "Высказывание истино" << endl;
        }
        else
        {
            cout << "Высказывание ложное " << endl;
        }
    
    }
    else
    {

        if (pow(C, 2) == pow(B, 2) + pow(A, 2))
        {
            cout << "Высказывание истино" << endl;
        }
        else
        {
            cout << "Высказывание ложное " << endl;
        }
    }
}