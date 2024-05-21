#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
    string A;
    cin >> A;
    string original_word = A;
    reverse(A.begin(), A.end());
    if (original_word == A)
    {
        cout << "1";
    }
    else
        cout << "0";
}