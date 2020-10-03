#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B;

    cout << "Введите A и B: ";

    cin >> A >> B;

    if (A > B)
    {
        B = A;
        
        cout << "Новые значения A = " << A << "; B = " << B << endl;
    }
    else if (B > A)
    {
        A = B;

        cout << "Новые значения A = " << A << "; B = " << B << endl;
    }
    else
    {
        A = 0;

        B = 0;

        cout << "Новые значения A = " << A << "; B = " << B << endl;
    }
}