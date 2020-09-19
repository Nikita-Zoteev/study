#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
	int A, B, C, d;
	cout << "A = ";
	cin >> A;
	cout << "B = ";
	cin >> B;
	cout << "C = ";
	cin >> C;
	d = B;
	B = A;
	A = C;
	C = d;
	cout << "A = " << A << endl;
	cout << "B = " << B << endl;
	cout << "C = " << C << endl;
}
