#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int x1, y1, x2, y2, x3, y3; double a, b, c, P, S;
	cout << "Введите координаты первой вершины: ";
	cin >> x1 >> y1;
	cout << "Введите координаты второй вершины: ";
	cin >> x2 >> y2;
	cout << "Введите координаты третьей вершины: ";
	cin >> x3 >> y3;
	a = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
	b = sqrt(pow((x2 - x3), 2) + pow((y2 - y3), 2));
	c = sqrt(pow((x3 - x1), 2) + pow((y3 - y1), 2));
	P = a + b + c;
	S = sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
	cout << "P = " << P << endl;
	cout << "S = " << S << endl;
}