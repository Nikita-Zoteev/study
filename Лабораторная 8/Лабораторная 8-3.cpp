#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");

    int a, b;

    cout << "Введите А и В: ";

    cin >> a >> b;

    cout << "Длина незанятой части отрезка А: " << a - b * floor(a / b) << endl;

}