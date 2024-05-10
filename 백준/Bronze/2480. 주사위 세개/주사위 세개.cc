#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int A, B, C, prize;
    cin >> A >> B >> C;

    if (A == B && B == C)
    {
        prize = 10000 + A * 1000;
    }
    else if (A == B || A == C || B == C)
    {
        if (A == B || A == C)
        {
            prize = 1000 + A * 100;
        }
        else
            prize = 1000 + B * 100;
    }
    else
    {
        int max_value = max({A, B, C});
        prize = max_value * 100;
    }

    cout << prize;
}