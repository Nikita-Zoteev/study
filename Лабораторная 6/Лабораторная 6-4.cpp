#include <iostream>
using namespace std;
int main()
{
    int y, x;
    cout << "y = 3*x^6 - 6*x^2 - 7" << endl;
    cout << "x = ";
    cin >> x;
    y = 3 * pow(x, 6) - 6 * pow(x, 2) - 7;
    cout << "y = " << y << endl;
}
