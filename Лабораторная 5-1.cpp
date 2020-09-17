#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int x1, x2, y1, y2;
	cout << "Введите первую координату: ";
	cin >> x1 >> y1;
	cout << "Введите вторую координату: ";
	cin >> x2 >> y2;
	cout << "Расстояние между точками = " << sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2))<< endl;
}
