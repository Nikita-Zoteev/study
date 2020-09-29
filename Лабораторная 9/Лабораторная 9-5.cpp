#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int a;

    cout << "Введите год: ";

    cin >> a;

    cout << "Век: " << ceil((double)a / 100) << endl;
}
