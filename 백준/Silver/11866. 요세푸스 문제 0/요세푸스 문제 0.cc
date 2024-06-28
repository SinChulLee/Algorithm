#include <iostream>
#include <queue>

using namespace std;

void josephus(int n, int k)
{
    queue<int> q;

    // 큐에 1부터 n까지의 숫자를 넣음
    for (int i = 1; i <= n; ++i)
    {
        q.push(i);
    }

    cout << "<";
    while (!q.empty())
    {
        // k-1번 앞의 원소를 뒤로 보냄
        for (int i = 0; i < k - 1; ++i)
        {
            q.push(q.front());
            q.pop();
        }
        // k번째 원소를 제거하여 출력
        cout << q.front();
        q.pop();

        if (!q.empty())
            cout << ", ";
    }
    cout << ">" << endl;
}

int main()
{
    int n, k;
    cin >> n >> k;
    josephus(n, k);
    return 0;
}
