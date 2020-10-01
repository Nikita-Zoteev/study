#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A;

    cout << "Введите число: ";

    cin >> A;

    if (A % 2 == 0 && A > 9 && A < 100)
    {
        cout << "Высказываение истинно" << endl;
    }
    else
    {
        cout << "Высказываение ложное" << endl;
    }
}
