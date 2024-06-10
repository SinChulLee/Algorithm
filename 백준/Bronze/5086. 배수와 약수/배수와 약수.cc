#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int num1, num2;
    vector<string> ans;

    while (true)
    {
        cin >> num1 >> num2;
        if (num1 == 0 && num2 == 0)
            break;

        if (num2 % num1 == 0)
            ans.push_back("factor");
        else if (num1 % num2 == 0)
            ans.push_back("multiple");
        else
            ans.push_back("neither");
    }
    for (int i = 0; i < ans.size(); i++)
    {
        cout << ans[i] << endl;
    }
}