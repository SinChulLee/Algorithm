#include <iostream>

using namespace std;

int main()
{
    long long int A, B;
    cin >> A >> B;
    if (A < 1000)
        int A = A;
    if (B < 1000)
        int B = B;

    // 최소공배수 구하기
    if (A == B)
        cout << A;
    else if (A > B)
    {
        for (int i = 1; i <= B; i++)
        {
            long long int min_value = A * i;
            if (min_value % B == 0)
            {
                cout << min_value;
                break;
            }
        }
    }
    else
    {
        for (int i = 1; i <= A; i++)
        {
            long long int min_value = B * i;
            if (min_value % A == 0)
            {
                cout << min_value;
                break;
            }
        }
    }
}