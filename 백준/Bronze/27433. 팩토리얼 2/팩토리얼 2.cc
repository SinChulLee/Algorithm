#include <iostream>

using namespace std;

long long factorial(const int &a, const long long &mul)
{
    if (a == 0)
    {
        return 1;
    }
    else if (a == 1)
    {
        return mul;
    }
    else
    {
        return factorial(a - 1, mul * a);
    }
}

int main()
{
    int N;
    long long multi = 1;
    cin >> N;
    long long result = factorial(N, multi);
    cout << result;
}