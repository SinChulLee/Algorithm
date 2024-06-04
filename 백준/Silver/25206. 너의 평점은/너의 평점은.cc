#include <iostream>

using namespace std;

int main()
{
    char subject[55], grade[5];
    float hakjum, sum = 0, hakjum_sum = 0;

    for (int i = 0; i < 20; i++)
    {
        cin >> subject >> hakjum >> grade;
        switch (grade[0])
        {
        case 'A':
            if (grade[1] == '+')
                sum += 4.5 * hakjum, hakjum_sum += hakjum;
            else
                sum += 4.0 * hakjum, hakjum_sum += hakjum;
            break;

        case 'B':
            if (grade[1] == '+')
                sum += 3.5 * hakjum, hakjum_sum += hakjum;
            else
                sum += 3.0 * hakjum, hakjum_sum += hakjum;
            break;

        case 'C':
            if (grade[1] == '+')
                sum += 2.5 * hakjum, hakjum_sum += hakjum;
            else
                sum += 2.0 * hakjum, hakjum_sum += hakjum;
            break;

        case 'D':
            if (grade[1] == '+')
                sum += 1.5 * hakjum, hakjum_sum += hakjum;
            else
                sum += 1.0 * hakjum, hakjum_sum += hakjum;
            break;

        case 'F':
            hakjum_sum += hakjum;
            break;

        case 'P':
            continue;

        default:
            break;
        };
    }

    if (hakjum_sum == 0)
        cout << hakjum_sum;
    else
        cout << (sum / hakjum_sum);
}