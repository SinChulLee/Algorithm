#include <iostream>

using namespace std;

int main()
{
    int line[3], max = 0, max_line, max_line_index, line1, line2;
    int ans;

    for (int i = 0; i < 3; i++)
    {
        cin >> line[i];
        if (line[i] > max)
        {
            max_line = line[i];
            max = max_line;
            max_line_index = i;
        }
    }

    if (max_line_index == 0)
    {
        line1 = line[1];
        line2 = line[2];
    }
    else if (max_line_index == 1)
    {
        line1 = line[0];
        line2 = line[2];
    }
    else if (max_line_index == 2)
    {
        line1 = line[0];
        line2 = line[1];
    }

    if (max_line >= line1 + line2)
    {
        max_line = line1 + line2 - 1;
    }

    ans = max_line + line1 + line2;
    cout << ans;
}