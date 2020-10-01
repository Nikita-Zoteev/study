#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, b, c, d, e;

    cout << "Введите число: ";

    cin >> A;

    b = A % 10;

    c = A / 10 % 10;

    d = A / 100 % 10;

    e = A / 1000;

    if (b == e && d == c)
    {
        cout << "Высказывание истинно" << endl;
    }
    else
    {
        cout << "Высказывание ложное" << endl;
    }
}
