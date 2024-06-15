#include <iostream>
#include <algorithm>

using namespace std;

int repaintCount(int Board[][50], int x, int y, int startColor)
{
    int repaintCount = 0;
    int currentColor = startColor;

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (Board[x + i][y + j] != currentColor)
            {
                repaintCount++;
            }
            currentColor = (currentColor == 0) ? 1 : 0;
        }
        currentColor = (currentColor == 0) ? 1 : 0;
    }

    return repaintCount;
}

int main()
{
    int N, M;
    cin >> N >> M;
    int Board[50][50]; // 2차원 정수 배열로 변경

    // 보드 입력받기
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            char cell;
            cin >> cell;
            if (cell == 'W')
                Board[i][j] = 0;
            else
                Board[i][j] = 1;
        }
    }

    int minRepaints = 64; // 최대값을 초기값으로 설정

    // 가능한 모든 8x8 체스판을 검사
    for (int i = 0; i <= N - 8; i++)
    {
        for (int j = 0; j <= M - 8; j++)
        {
            int repaintsWStart = repaintCount(Board, i, j, 0);
            int repaintsBStart = repaintCount(Board, i, j, 1);
            int currentMinRepaints = min(repaintsWStart, repaintsBStart);
            minRepaints = min(minRepaints, currentMinRepaints);
        }
    }

    cout << minRepaints << endl;
    return 0;
}
