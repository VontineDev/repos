#include <string>
#include <vector>
#include <iostream>
#include <queue>

using namespace std;

int solution(vector<int> scoville, int K) {
	int answer = 0;
	priority_queue< int, vector<int>, greater<int> > pq(scoville.begin(), scoville.end());

	while (!pq.empty())
	{
		if (pq.size() == 1)
		{
			if (pq.top() >= K)
			{

				break;
			}
			else
			{
				answer = -1;

				break;
			}
		}
		else
		{
			int first = pq.top();
			pq.pop();

			int second = pq.top();
			pq.pop();

			int sum = first + second * 2;

			answer++;

			pq.push(sum);

			if (pq.top() >= K)
			{
				break;
			}
		}
	}
	return answer;
}


int main()
{
	vector<int> scoville = { 1,2 };

	int ans = solution(scoville, 5);

	cout << ans << endl;
}
