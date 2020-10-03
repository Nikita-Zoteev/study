#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A;
    
    cout << "Введите число: ";

    cin >> A;

    if (A == 0)
        cout << "Ввденное число является нулевым" << endl;
    else
    {
        if (A > 0)
        {
            if (A % 2 == 0)
                cout << "Ввденное число является положительным четным" << endl;
            else
                cout << "Ввденное число является положительным нечетным" << endl;
        }
        else
        {
            if (A % 2 == 0)
                cout << "Ввденное число является отрицательным четным" << endl;
            else
                cout << "Ввденное число является отрицательным нечетным" << endl;
        }
    }
}