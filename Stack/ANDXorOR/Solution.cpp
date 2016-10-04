#include <cmath>
#include <stack>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int n; cin >> n;
    vector<int> in(n);
    for(int i = 0; i < n; i ++)
        cin >> in[i];
    
    int ret = 0;
    {
        //in.push_back(0); 
        stack<int> stk;
        for (int i = 0; i <= in.size(); i++)
        {
            if (stk.empty() || in[i] > stk.top())
            {
                stk.push(in[i]);
            }
            else
            {
                int lastV = stk.top(); stk.pop();
                if (!stk.empty())
                {
                    ret = std::max(ret, (lastV ^ stk.top()));            
                    //cout << lastV << "-" << stk.top() << "=" << (lastV ^ stk.top()) << endl;
                }
                i--;
            }
        }
        //in.pop_back();
    }
    {
        
        stack<int> stk;
        in.insert(in.begin(), 0);
        for (int i = in.size() - 1; i >= 0; i --)
        {
            if (stk.empty() || in[i] > stk.top())
            {
                stk.push(in[i]);
            }
            else
            {
                int lastV = stk.top(); stk.pop();
                if (!stk.empty())
                {
                    ret = std::max(ret, (lastV ^ stk.top()));
                }
                i++;
            }
        }
    }
    
    cout << ret << endl;
    return 0;
}