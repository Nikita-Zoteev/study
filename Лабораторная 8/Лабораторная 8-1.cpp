#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

	int a;

	cout << "Введите число в байтах: ";

	cin >> a;

	cout << "Число в килобайтах: " << ceil(a / 1024) << endl;

}