#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");
	int a1, a2, t, s;
	cout << "Скорость первого = ";
	cin >> a1;
	cout << "Скорость второго = ";
	cin >> a2;
	cout << "Время = ";
	cin >> t;
	cout << "Первоначальное расстояние между ними = ";
	cin >> s;
	cout << "Расстояние между ними через " << t << " часов(а) = " << s + (a1 + a2) * t << endl;
}