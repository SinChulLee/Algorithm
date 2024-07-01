#include <iostream>
#include <deque>
#include <vector>

using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> balloon_num(N + 1);
    deque<pair<int, int>> balloons;

    for (int i = 1; i <= N; i++)
    {
        int num;
        cin >> num;
        balloons.push_back({i, num});
    }

    while (!balloons.empty())
    {
        // 터뜨릴 풍선의 번호와 이동할 값을 얻는다
        int index = balloons.front().first;
        int move = balloons.front().second;
        balloons.pop_front(); // 풍선을 터뜨린다

        // 결과 출력
        cout << index << " ";

        // 풍선이 없으면 탈출
        if (balloons.empty())
            break;

        // move 값이 음수인 경우 왼쪽, 양수인 경우 오른쪽으로 이동
        if (move > 0)
        {
            // right shift (move - 1) times
            for (int i = 0; i < move - 1; i++)
            {
                balloons.push_back(balloons.front());
                balloons.pop_front();
            }
        }
        else
        {
            // left shift abs(move) times
            for (int i = 0; i < -move; i++)
            {
                balloons.push_front(balloons.back());
                balloons.pop_back();
            }
        }
    }
    return 0;
}