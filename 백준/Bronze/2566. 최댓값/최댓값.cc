#include <iostream>

using namespace std;

int main()
{
    int maxtrix[9][9];
    int maxvalue = -1;
    int row_index, col_index;

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            cin >> maxtrix[i][j];
            if (maxtrix[i][j] > maxvalue)
            {
                maxvalue = maxtrix[i][j];
                row_index = i + 1, col_index = j + 1;
            }
        }
    }

    cout << maxvalue << endl
         << row_index << " " << col_index;
}