#include <string>
#include <vector>
#include <unordered_map>
#include <iostream>

using namespace std;

int solution(vector<vector<string>> clothes) {
	int answer = 1;
	unordered_map<string, int> map;
	for (auto it : clothes)
	{
		unordered_map<std::string, int>::const_iterator got = map.find(it.back());
		if (got == map.end())
		{
			map.emplace(it.back(), 2);
		}
		else
		{
			map.at(it.back())++;
		}
	}

	for (auto& x : map)
	{
		answer *= x.second;
	}

	return answer - 1;
}


int main()
{
	std::cout << "Hello World!\n";
}
