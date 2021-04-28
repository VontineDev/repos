#include <string>
#include <vector>
#include <iostream>
#include <queue>

using namespace std;

#include <string>
#include <vector>

using namespace std;
struct cmp {
	bool operator()(vector<int> a, vector<int> b)
	{
		if (a.front() == 0 && b.front() == 0)
		{
			return a.back() > b.back();
		}
		else if (a.front() == 0)
		{
			return false;
		}
		else if (b.front() == 0)
		{
			return true;
		}
		else
		{
			return a.back() > b.back();
		}
	}
};


int solution(vector<vector<int>> jobs) {
	int answer = 0;

	priority_queue<vector<int>, vector<vector<int>>, cmp> pq(jobs.begin(), jobs.end());

	//while (!pq.empty())
	//{
	//	vector<int> a = pq.top();
	//	cout << a[0] << " " << a[1] << endl;
	//	pq.pop();
	//}
	int size = pq.size();
	int sum = 0;
	//workingTime without waitingTime
	int workingTime = pq.top().back();
	//waitingTime
	int waitingTime = 0;
	//first work
	sum = pq.top().back();
	pq.pop();

	while (!pq.empty())
	{
		vector<int> tmp = pq.top();
		pq.pop();
		
	}
	answer = sum / size;
	return answer;
}


int main()
{
	vector<vector<int>> jobs = { {0, 3},{1, 9},{2, 6} };

	int ans = solution(jobs);

	cout << ans << endl;
}
