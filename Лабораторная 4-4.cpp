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
	cout << "Сумма квадратов = " << pow(a, 2) + pow(b, 2) << endl;
	cout << "Разность квадратов = " << pow(a, 2) - pow(b, 2)<< endl;
	cout << "Произведение квадратов = " << pow(a, 2) * pow(b, 2) << endl;
	cout << "Частное квадратов = " << pow(a, 2) / pow(b, 2) << endl;
}
