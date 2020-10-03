#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B, C;

    cout << "Введите A, B и C: ";

    cin >> A >> B >> C;

    if (A > B) {
        if (B > C)
        {
            cout << "Сумма 2 наибольших = " << A + B << endl;
        }
        else
        {
            cout << "Сумма 2 наибольших = " << A + C << endl;
        }
    }
    else
    {
        if (A > C)
        {
            cout << "Сумма 2 наибольших = " << A + B << endl;
        }
        else
        {
            cout << "Сумма 2 наибольших = " << C + B << endl;
        }
    }
}