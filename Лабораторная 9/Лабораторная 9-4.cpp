#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

	int a, b, c, d, e;

	cout << "Введите A, B и C: ";

	cin >> a >> b >> c;

	d = a / c;

	e = b / c;

	cout << "Количество квадратов C в прямоугольнике AB: " << e * d << endl;

	cout << "Площадь незанятой части прямогульника: " << a * b - e * d * pow(c, 2) << endl;

}
