#include <iostream>
#include <string>
#include <vector>

using namespace std;
int answer = 0;

void dfs(vector<int> numbers, int target, int sum, int depth) {
	if (depth >= numbers.size()) {
		if (sum == target) {
			answer++;
		}
		return;
	}

	dfs(numbers, target, sum + numbers[depth], depth + 1);
	dfs(numbers, target, sum - numbers[depth], depth + 1);
}

int solution(vector<int> numbers, int target) {

	dfs(numbers, target, 0, 0);


	return answer;
}

int main()
{
	vector<int> numbers = { 1,1,1,1,1 };
	int target = 3;

	int ans = solution(numbers, target);
	cout << ans << endl;
}
