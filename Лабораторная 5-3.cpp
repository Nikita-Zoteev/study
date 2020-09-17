#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
	int A, B, C;
	cout << "Введите A, C и B: ";
	cin >> A >> C >> B;
	cout << "AC * BC = " << (C - A) * (B - C) << endl;
}

