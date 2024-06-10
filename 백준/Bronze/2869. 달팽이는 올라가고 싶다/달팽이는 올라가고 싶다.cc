#include <iostream>
#include <cmath>
using namespace std;

// 시간 초과 코드
// int main()
// {
//     int A, B, V, height = 0, count = 0;
//     cin >> A >> B >> V;
//     while (true)
//     {
//         count++;
//         height += A;
//         if (height >= V)
//             break;
//         height -= B;
//     }
//     cout << count;
// }

int main()
{
    int A, B, V;
    cin >> A >> B >> V;
    int days = ceil((double)(V - B) / (A - B));
    cout << days;
}