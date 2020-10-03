#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B, C;

    cout << "Введите точки A, B и C: ";

    cin >> A >> B >> C;

    if (abs(A - B) > abs(A - C))
    {
        cout << "Точка С находится ближе, расстояние межу А и С = " << abs(A - C) << endl;
    }
    else
    {
        cout << "Точка B находится ближе, расстояние межу А и B = " << abs(A - B) << endl;
    }
}