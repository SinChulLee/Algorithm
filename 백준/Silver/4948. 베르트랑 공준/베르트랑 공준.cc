#include <iostream>
#include <vector>

using namespace std;

bool is_prime(long long num)
{
    if (num <= 1)
        return false;
    if (num <= 3)
        return true;
    if (num % 2 == 0 || num % 3 == 0)
        return false;
    for (long long i = 5; i * i <= num; i += 6)
    {
        if (num % i == 0 || num % (i + 2) == 0)
            return false;
    }
    return true;
}

int main()
{
    vector<int> n;
    vector<int> ans;

    while (true)
    {
        int num;
        cin >> num;
        if (num == 0)
            break;
        else
            n.push_back(num);
    }

    for (const int &num : n)
    {
        int count = 0;
        for (int i = num + 1; i <= 2 * num; i++)
        {
            if (is_prime(i))
                count += 1;
        }
        ans.push_back(count);
    }

    for (const int &count : ans)
    {
        cout << count << "\n";
    }
}