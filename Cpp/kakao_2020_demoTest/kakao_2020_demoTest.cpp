#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

vector<int> solution(vector<vector<int> > v) {
	vector<int> ans;

	unordered_map<int, int> tmp;

	for (auto it : v)
	{
		int found = it.front();

		if (tmp.count(found) != 0)
		{
			tmp.find(found)->second = 2;
		}
		else
		{
			tmp.emplace(found, 1);
		}
	}
	for (auto it : tmp)
	{
		if (it.second == 1)
		{
			ans.emplace_back(it.first);
		}
	}
	tmp.clear();
	for (auto it : v)
	{
		int found = it.back();

		if (tmp.count(found) != 0)
		{
			tmp.find(found)->second = 2;
		}
		else
		{
			tmp.emplace(found, 1);
		}
	}
	for (auto it : tmp)
	{
		if (it.second == 1)
		{
			ans.emplace_back(it.first);
		}
	}

	return ans;
}
int main()
{
	vector<vector<int>> v = { {1,4},{3,4},{3,10} };

	vector<int> ans = solution(v);

	cout << ans.front() << " " << ans.back() << endl;
}
