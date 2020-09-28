#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	const double PI = 3.14;
	int a;
	cout << "Введите величину угла: ";
	cin >> a;
	cout << "Величина угла в радианах = " << a * PI / 180 << endl;
}