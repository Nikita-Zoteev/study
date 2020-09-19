#include <iostream>
using namespace std;
int main()
{	
	setlocale(LC_ALL, "Rus");
	int A, B;
	cout << "A = ";
	cin >> A;
	B = A * A;
	B *= B;
	A = B * B;
	cout << "A^8 = " << A << endl;
}