#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int N, X;
    cin >> N >> X;
    int A[N];
    vector<int> answer;

    for (int i = 0; i < N; i++)
    {
        cin >> A[i];
        if (A[i] < X)
        {
            answer.push_back(A[i]);
        }
    }

    for (int ans : answer)
    {
        cout << ans << " ";
    }
}