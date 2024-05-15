#include <iostream>
#include <algorithm>

using namespace std;

void reverse_word(string &A, string &B)
{
    reverse(A.begin(), A.end());
    reverse(B.begin(), B.end());

    if (A > B)
    {
        cout << A;
    }
    else
    {
        cout << B;
    }
}

int main()
{
    string A, B;
    cin >> A >> B;
    reverse_word(A, B);
}