#include <iostream>
using namespace std;
int main()
{
	int A, B, C;
	cout << "A = ";
	cin >> A;
	B = A * A * A;
	C = B * B;
	C = C * C;
	A = B * C;
	cout << "A^15 = " << A << endl;
}
