#include <iostream>
#include<math.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	float a; float b;
	cout << "Введите первое число: ";
	cin >> a;
	cout << "Введите второе число: ";
	cin >> b;
	cout << "Сумма модулей = " << abs(a) + abs(b) << endl;
	cout << "Разность модулей = " << abs(a) - abs(b) << endl;
	cout << "Произведение модулей = " << abs(a) * abs(b) << endl;
	cout << "Частное модулей = " << abs(a) / abs(b) << endl;
}