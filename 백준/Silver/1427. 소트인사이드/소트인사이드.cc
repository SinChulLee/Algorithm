#include <iostream>

using namespace std;

int main()
{
    string N;
    cin >> N;
    for (int i = 0; i < N.size(); i++)
    {
        for (int j = i + 1; j < N.size(); j++)
        {
            if (int(N[i]) < int(N[j]))
            {
                int temp = N[i];
                N[i] = N[j];
                N[j] = temp;
            }
        }
    }

    for (int k = 0; k < N.size(); k++)
    {
        cout << N[k];
    }
}