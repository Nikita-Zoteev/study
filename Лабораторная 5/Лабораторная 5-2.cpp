#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int A, B, C;
	cout << "Введите A, B и C: ";
	cin >> A >> B >> C;
	cout << "AC = " << abs(C - A) << endl;
	cout << "BC = " << abs(C - B) << endl;
	cout << "AC + BC = " << abs(C - A + C - B) << endl;
}