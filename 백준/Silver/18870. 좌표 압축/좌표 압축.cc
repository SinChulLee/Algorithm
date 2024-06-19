#include <bits/stdc++.h>

using namespace std;

int main()
{
    cin.tie(NULL);
    ios_base::sync_with_stdio(false);

    int n;
    cin >> n;

    vector<pair<int, int>> v(n); // vector 안에 pair를 사용
    for (int i = 0; i < n; i++)
    {
        int input;
        cin >> input;

        v[i] = {input, i};
    }

    sort(v.begin(), v.end());

    vector<int> v2(n);
    int prev = INT32_MAX;
    int count = -1;

    for (int i = 0; i < n; i++)
    {
        if (prev != v[i].first)
            count++;

        v2[v[i].second] = count;
        prev = v[i].first;
    }

    for (int i : v2)
        cout << i << ' ';

    return 0;
}