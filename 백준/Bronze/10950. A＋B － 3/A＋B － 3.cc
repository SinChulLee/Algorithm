#include <iostream>

using namespace std;

int main()
{
    int T;
    int A, B;

    cin >> T;
    int Answer[T];

    for (int i = 0; i < T; i++)
    {
        cin >> A >> B;
        Answer[i] = A + B;
    }
    for (int i = 0; i < T; i++)
    {
        cout << Answer[i] << endl;
    }
}