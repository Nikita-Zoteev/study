#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Rus");

    int a;

    cout << "Введите число: ";

    cin >> a;

	switch (a % 7)
	{
	case 0: {
		cout << "Воскресенье" << endl;
			break;
	}
	case 1: {
		cout << "Понедельник" << endl;
		break;
	}
	case 2: {
		cout << "Вторник" << endl;
		break;
	}
	case 3: {
		cout << "Среда" << endl;
		break;
	}
	case 4: {
		cout << "Четверг" << endl;
		break;
	}
	case 5:{
		cout << "Пятница" << endl;
		break;
	}
	case 6: {
		cout << "Суббота" << endl;
		break;
	}
	default:
		break;
	}
}