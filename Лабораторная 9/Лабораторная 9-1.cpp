#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");

	int a;

	cout << "Введите число: ";

	cin >> a;

	cout << "Количество секунд прошло с последней минуты: " << a - a / 60 * 60 << endl;

}