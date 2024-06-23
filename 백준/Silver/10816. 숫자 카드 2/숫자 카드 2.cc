#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 입출력 동기화 비활성화
    cin.tie(NULL);               // cin과 cout의 묶음을 풀어줌

    int N, M;
    cin >> N;
    vector<int> num(N);
    unordered_map<int, int> num_cnt;

    for (int i = 0; i < N; i++)
    {
        cin >> num[i];
        num_cnt[num[i]] += 1;
    }

    cin >> M;
    for (int j = 0; j < M; j++)
    {
        int pro_num;
        cin >> pro_num;
        cout << num_cnt[pro_num] << " ";
    }
}