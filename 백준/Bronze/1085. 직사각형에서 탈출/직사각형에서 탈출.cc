#include <iostream>
#include <cmath>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int x, y, w, h;
    cin >> x >> y >> w >> h;
    vector<int> num_arr;

    num_arr.push_back(x);
    num_arr.push_back(y);
    num_arr.push_back(w);
    num_arr.push_back(h);

    // 오른쪽 위 꼭지점의 선까지 최소 거리 추가
    num_arr.push_back(w - x);
    num_arr.push_back(h - y);

    // (0,0) 및 (w,h) 와 현재점 대각선 거리 추가
    num_arr.push_back(sqrt(pow(x, 2) + pow(y, 2)));
    num_arr.push_back(sqrt(pow(w - x, 2) + pow(y - h, 2)));

    auto min_it = min_element(num_arr.begin(), num_arr.end());
    int min_value = *min_it;
    cout << min_value;
}