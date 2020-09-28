#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int A, B;
	cout << "Введите А и В: " << endl;
	cin >> A >> B;
	cout << "Уравнение имеет вид: " << A << " * x + " << B <<" = 0" << endl;
	cout << "x = " << (double)-B / A << endl;
}