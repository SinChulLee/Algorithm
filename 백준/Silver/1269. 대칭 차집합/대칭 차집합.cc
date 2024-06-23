#include <iostream>
#include <vector>
#include <unordered_set>

using namespace std;

// target 집합과 뺄 집합을 계산하여 차집합을 return 해주는 함수
unordered_set<int> count_diff(const vector<int> &target, const vector<int> &diff)
{
    unordered_set<int> element_set(target.begin(), target.end());

    for (int d : diff)
    {
        element_set.erase(d);
    }

    return element_set;
}

int main()
{
    int N, M;
    cin >> N >> M;
    vector<int> A(N);
    vector<int> B(M);

    for (int i = 0; i < N; i++)
    {
        cin >> A[i];
    }

    for (int j = 0; j < M; j++)
    {
        cin >> B[j];
    }

    unordered_set<int> A_diff_cnt = count_diff(A, B);
    unordered_set<int> B_diff_cnt = count_diff(B, A);

    cout << A_diff_cnt.size() + B_diff_cnt.size();
}