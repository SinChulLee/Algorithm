#include <iostream>

using namespace std;

int main()
{
    int student[30];
    int num[30];

    // 학생 번호 붙이기
    for (int i = 0; i < 30; i++)
    {
        student[i] = i + 1;
        cin >> num[i];
    }

    for (int j = 0; j < 30; j++)
    {
        for (int k = 0; k < 30; k++)
        {
            if (student[j] == num[k])
            {
                student[j] = 0;
            }
        }
    }

    for (int z = 0; z < 30; z++)
    {
        if (student[z] != 0)
        {
            cout << student[z] << endl;
        }
    }
}