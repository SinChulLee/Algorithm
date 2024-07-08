#include <iostream>
#include <string>
#include <cstring>
#include <vector>

using namespace std;

// Helper function to perform the recursion and count calls
int recursion(const char *s, int l, int r, int *c)
{
    (*c)++; // Increment the call count
    if (l >= r)
        return 1;
    else if (s[l] != s[r])
        return 0;
    else
        return recursion(s, l + 1, r - 1, c);
}

// Function to check if the string is a palindrome and count the recursion calls
int isPalindrome(const char *s, int *cnt)
{
    *cnt = 0;
    return recursion(s, 0, strlen(s) - 1, cnt);
}

int main()
{
    int T;
    cin >> T;
    vector<pair<int, int>> results;

    for (int i = 0; i < T; i++)
    {
        string S;
        cin >> S;
        int cnt;
        int value = isPalindrome(S.c_str(), &cnt); // Use c_str() to convert string to C-style string
        results.push_back(make_pair(value, cnt));
    }

    for (const auto &result : results)
    {
        cout << result.first << " " << result.second << "\n";
    }

    return 0;
}