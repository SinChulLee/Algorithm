#include <iostream>

using namespace std;

int main()
{
    int N;
    string Answer;

    cin >> N;
    int loop = N / 4;

    for (int i = 0; i < loop; i++)
    {
        Answer += "long ";
    }

    cout << Answer << "int";
}