#include <iostream>

using namespace std;

int Fibonacci(const int &num)
{
    if (num <= 1)
    {
        return num;
    }
    else
    {
        return Fibonacci(num - 1) + Fibonacci(num - 2);
    }
}

int main()
{
    int n;
    cin >> n;
    int result = Fibonacci(n);
    cout << result;
}