#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");

	int A, b, c, d;

	cout << "Введите число: ";

	cin >> A;

	b = A % 10;

	c = A / 10 % 10;

	d = A / 100;

	if ((b < c && c < d)||(b > c && c > d) )
	{
		cout << "Высказывание истинное " << endl;
	}
	else
	{
		cout << "Высказывание ложное" << endl;
	}
}