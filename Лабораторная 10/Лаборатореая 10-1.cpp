#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B;

    cout << "Введите A и В: ";

    cin >> A >> B;

    if (A > 2 && B <= 3)
    {
        cout << "Высказывание истинное" << endl;
    }
    else
    {
        cout << "Высказывание ложное" << endl;
    }
}
