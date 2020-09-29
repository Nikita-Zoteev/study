#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

	int K, N, a;

	cout << "Введите числа K, N: ";

	cin >> K >> N;

	switch (N)
	{
	case 7: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	case 1: {
		a = (K % 7 + N - 1) % 7;
		if (a == 0) {
			a = 7;
		}
		cout << "Номер дня недели: " << a;
		break;
	}
	case 2: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	case 3: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	case 4: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	case 5: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	case 6: {
		a = (K % 7 + N - 1) % 7;
		cout << "Номер дня недели: " << a;
		break;
	}
	default:
		break;
	}
}