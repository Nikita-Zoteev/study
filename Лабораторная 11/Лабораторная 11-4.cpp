#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int x, y;

    cout << "Введите координаты точки А: " << endl;

    cin >> x >> y;

    if (x > 0 && y > 0)
        cout << "Точка находится в первой четверти ";
    if (x < 0 && y > 0)
        cout << "Точка находится во второй четверти ";
    if (x < 0 && y < 0)
        cout << "Точка находится в третьей четверти ";
    if (x > 0 && y < 0)
        cout << "Точка находится в четвертой четверти ";
}