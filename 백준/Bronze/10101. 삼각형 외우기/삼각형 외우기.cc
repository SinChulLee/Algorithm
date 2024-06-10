#include <iostream>

using namespace std;

int main()
{
    int angle[3], sum = 0;

    for (int i = 0; i < 3; i++)
    {
        cin >> angle[i];
        sum += angle[i];
    }

    if (sum != 180)
    {
        cout << "Error";
        return 0;
    }

    if (angle[0] == angle[1] && angle[0] == angle[2] && angle[1] == angle[2])
    {
        cout << "Equilateral";
    }
    else if (angle[0] != angle[1] && angle[0] != angle[2] && angle[1] != angle[2])
    {
        cout << "Scalene";
    }
    else
        cout << "Isosceles";
}