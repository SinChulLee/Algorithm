#include <iostream>
#include <queue>

using namespace std;

int main()
{
    int N;
    queue<int> card;
    cin >> N;

    // card 큐에 삽입
    for (int i = 1; i <= N; i++)
    {
        card.push(i);
    }

    while (card.size() > 1)
    {
        card.pop();
        card.push(card.front());
        card.pop();
    }

    cout << card.front();
}