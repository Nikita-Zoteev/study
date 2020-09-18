#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int x1, x2, y1, y2, a, b, P, S;
	cout << "Введите координаты точки A: ";
	cin >> x1 >> y1;
	cout << "Введите координаты точки C: ";
	cin >> x2 >> y2;
	a = abs(x2 - x1);
	b = abs(y2 - y1);
	P = 2 * (a + b);
	S = a * b;
	cout << "P = " << P << endl;
	cout << "S = " << S << endl;
}

