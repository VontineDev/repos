#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
using namespace std;

class Menu
{
public:

	Menu(vector<string> orders)
	{
		for (int i = 0; i < orders.size(); i++)
		{
			order.emplace_back(orders[i]);
		}
		courseSize = order.size();
		menu = orders;
	}
	vector<char> order;
	vector<string> menu;
	int courseSize;
	int orderCount;
	int count;

	void OrderCounting(vector<string>orders)
	{
		for (int i = 0; i < orders.size(); i++)
		{
			for (int j = 0; j < order.size(); j++)
			{
				if (orders[i].find(order[j], 0))
				{
					orderCount++;
				}
			}
		}
		if (orderCount == order.size())
		{
			count++;
		}
	}
};

bool compare(string a, string b)
{
	return a.size() < b.size();
}

vector<string> solution(vector<string> orders, vector<int> course) {
	vector<string> answer;

	vector<string> tmp = orders;

	sort(tmp.begin(), tmp.end(), compare);



	return answer;
}
int main()
{
	vector<string> orders = { "ABCFG", "AC", "CDE", "ACDE", "BCFG", "ACDEH" };

	vector<string> ans = solution(orders, { 1 });

	for (auto it : ans)
	{
		cout << it << endl;
	}
}

