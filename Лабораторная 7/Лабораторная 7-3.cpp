#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
    int a; double b;
    cout << "Сколько килограмм конфет купили?" << endl;
    cin >> a;
    cout << "Сколько это стоило?" << endl;
    cin >> b;
    cout << "килограмм конфет стоит " << b / a  << endl;
}
