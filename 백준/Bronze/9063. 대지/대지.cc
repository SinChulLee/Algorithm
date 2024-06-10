#include <iostream>

using namespace std;

int main()
{
    int max_x_point = -10000;
    int max_y_point = -10000;
    int min_x_point = 10000;
    int min_y_point = 10000;

    int N, x, y;
    cin >> N;

    for (int i = 0; i < N; i++)
    {
        cin >> x >> y;
        if (x > max_x_point)
            max_x_point = x;
        if (x < min_x_point)
            min_x_point = x;

        if (y > max_y_point)
            max_y_point = y;
        if (y < min_y_point)
            min_y_point = y;
    }

    if ((max_x_point > 0 && min_x_point < 0) && (max_y_point > 0 && min_y_point < 0))
    {
        cout << ((abs(max_x_point) - (min_x_point)) * (abs(max_y_point) - (min_y_point)));
    }
    else if (max_x_point > 0 && min_x_point < 0)
        cout << ((abs(max_x_point) - (min_x_point)) * (abs(max_y_point) - abs(min_y_point)));
    else if (max_y_point > 0 && min_y_point < 0)
        cout << ((abs(max_x_point) - abs(min_x_point)) * (abs(max_y_point) - (min_y_point)));
    else
        cout << ((abs(max_x_point) - abs(min_x_point)) * (abs(max_y_point) - abs(min_y_point)));
}