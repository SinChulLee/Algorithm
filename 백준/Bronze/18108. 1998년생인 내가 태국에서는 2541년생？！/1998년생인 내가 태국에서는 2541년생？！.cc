#include <iostream>

using namespace std;

int main()
{
    int year, Answer;

    while (year < 1000 || year > 3000)
    {
        cin >> year;
    }

    Answer = year - 543;
    cout << Answer;
}