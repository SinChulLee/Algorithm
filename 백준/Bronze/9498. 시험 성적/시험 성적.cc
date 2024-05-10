#include <iostream>

using namespace std;

int main()
{
    int jumsu;

    cin >> jumsu;

    if (jumsu < 0 || jumsu > 100)
    {
        cout << "점수는 0점 이상, 100점 이하를 입력해주세요";
    }
    else if (jumsu >= 90)
    {
        cout << "A";
    }
    else if (jumsu >= 80)
    {
        cout << "B";
    }
    else if (jumsu >= 70)
    {
        cout << "C";
    }
    else if (jumsu >= 60)
    {
        cout << "D";
    }
    else
        cout << "F";
}