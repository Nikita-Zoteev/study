#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
    double const PI = 3.14; double a;
    cout << "Введите радианную меру угла: ";
    cin >> a;
    cout << "Величина угла в градусах: " << a * 180 / PI << endl;
}