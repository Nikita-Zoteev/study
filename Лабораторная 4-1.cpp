#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");
    int a; int b;
    cout << "Введите длину : ";
    cin >> a;
    cout << "Введите ширину : ";
    cin >> b;
    cout << "S = " << a * b << endl;
    cout << "P = " << 2 * (a + b) << endl;

}
