#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int A1, A2, B2, B1, C1, C2, del, delx, dely;
	cout << "Введите A1, B1, C1: ";
	cin >> A1 >> B1 >> C1;
	cout << "Введите A2, B2, C2: ";
	cin >> A2 >> B2 >> C2;
	cout << "система уравнений имеет вид: " << endl;
	cout << A1 << "*x + " << B1 << "*y = " << C1 << endl;
	cout << A2 << "*x + " << B2 << "*y = " << C2 << endl;
	del = A1 * B2 - B1 * A2;
	delx = C1 * B2 - B1 * C2;
	dely = A1 * C2 - C1 * A2;
	cout << "x = " << delx / del << " y = " << dely / del << endl;
}
