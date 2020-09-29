#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

	int a, b;

	cout << "Введите число: ";

	cin >> a;

	b = a / 100;

	a = a % 100 * 10 + b;

	cout << "Полученное число: " << a << endl;

}
