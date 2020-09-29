#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");

    int a, b;

    cout << "Введите А и В: ";

    cin >> a >> b;

    cout << "Количесвто отрезков В в отрезке А: " << floor(a / b) << endl;

}