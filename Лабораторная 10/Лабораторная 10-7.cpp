﻿#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");

    int A, B, C;

    cout << "Введите A, B и C: ";

    cin >> A >> B >> C;

    if (A + B > C && A + C > B && B + C > A) 
    {
        cout << "Высказывание истинное " << endl;
    }
    else
    {
        cout << "Высказывание ложное " << endl;
    }
}