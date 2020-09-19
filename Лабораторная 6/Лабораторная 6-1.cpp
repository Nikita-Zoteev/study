#include <iostream>
using namespace std;
int main()
{
	int A, B, c;
	cout << "A = ";
	cin >> A;
	cout << "B = ";
	cin >> B;
	c = A;
	A = B;
	B = c;
	cout << "A = " << A << endl;
	cout << "B = " << B << endl;
}
