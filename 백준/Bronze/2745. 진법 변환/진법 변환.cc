#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    string N;
    int B;
    cin >> N >> B;
    int multiple = N.length() - 1;
    int result = 0;

    for (int i = 0; i < N.length(); i++)
    {
        if (int(N[i]) > 64)
        {
            result += (int(N[i]) - 'A' + 10) * pow(B, multiple);
        }
        else
            result += (int(N[i]) - '0') * pow(B, multiple);

        multiple -= 1;
    }
    cout << result;
}