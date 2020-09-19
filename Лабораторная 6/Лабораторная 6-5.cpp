#include <iostream>
using namespace std;
int main()
{
    int y, x;
    cout << "y = 4*(x-3)^6 - 7*(x-3)^3 + 2" << endl;
    cout << "x = ";
    cin >> x;
    y = 4 * pow(x-3, 6) - 7 * pow(x-3, 2) + 2;
    cout << "y = " << y << endl;
}
