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
	cout << "Среднее арифметическое = " << (a+b)/2 << endl;
}

