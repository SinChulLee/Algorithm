#include <iostream>

using namespace std;

int main()
{
    int N;
    string star = "";
    cin >> N;

    for (int i = 0; i < N; i++)
    {
        star += "*";
        cout << star << endl;
    }
}