#include <iostream>

using namespace std;

int main()
{
    int T, money;
    cin >> T;
    int C[T][4];
    for (int i = 0; i < T; i++)
    {
        int rest_money;
        cin >> money;
        rest_money = money;
        C[i][0] = rest_money / 25;
        rest_money %= 25;
        C[i][1] = rest_money / 10;
        rest_money %= 10;
        C[i][2] = rest_money / 5;
        rest_money %= 5;
        C[i][3] = rest_money / 1;
    }

    for (int j = 0; j < T; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            cout << C[j][k] << " ";
        }
        cout << endl;
    }
}