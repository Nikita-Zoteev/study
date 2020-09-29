#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

	int a, b;

	cout << "Введите число: ";

	cin >> a;

	b = a % 10;

	a = b * 10 + a / 10;

	cout << "Полученное число: " << a << endl;

}
