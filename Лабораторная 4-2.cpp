#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");
	int d;
	const double PI = 3.14;
	cout << "Введите диаметр: ";
	cin >> d;
	cout << "L = " << PI * d << endl;
}