#include <iostream>
#include <vector>
#include <unordered_set>
#include <algorithm>

using namespace std;

vector<string> findintersection(const vector<string> &A_arr, const vector<string> &B_arr)
{
    unordered_set<string> elements_set(A_arr.begin(), A_arr.end());
    vector<string> intersection;

    for (string word : B_arr)
    {
        if (elements_set.find(word) != elements_set.end())
        {
            intersection.push_back(word);
            elements_set.erase(word);
        }
    }

    return intersection;
}

int main()
{
    int N, M;
    cin >> N >> M;
    vector<string> A_arr(N);
    vector<string> B_arr(M);

    for (int i = 0; i < N; i++)
    {
        cin >> A_arr[i];
    }

    for (int j = 0; j < M; j++)
    {
        cin >> B_arr[j];
    }

    vector<string> result = findintersection(A_arr, B_arr);
    sort(result.begin(), result.end());

    cout << result.size() << "\n";
    for (string w : result)
    {
        cout << w << "\n";
    }
}