#include <iostream>
#include <cctype>

using namespace std;

bool isAllSpace(const string &str)
{
    if (str.empty())
        return true;

    for (char ch : str)
    {
        if (!isspace(static_cast<unsigned char>(ch)))
        {
            return false;
        }
    }
    return true;
}

void CountVoca(const string &str)
{
    int cnt = 1;

    for (int i = 0; i < str.size(); i++)
    {
        if (str[i] == ' ' && i != 0 && i != str.size() - 1)
        {
            cnt += 1;
        }
    }

    cout << cnt;
}

int main()
{
    string S;
    getline(cin, S);

    if (isAllSpace(S))
    {
        cout << 0;
    }
    else
    {
        CountVoca(S);
    }
}