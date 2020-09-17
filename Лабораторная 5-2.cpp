#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int A, B, C;
	cout << "Введите A, B и C: ";
	cin >> A >> B >> C;
	cout << "AC = " << C - A << endl;
	cout << "BC = " << C - B << endl;
	cout << "AC + BC = " << C - A + C - B << endl;
}