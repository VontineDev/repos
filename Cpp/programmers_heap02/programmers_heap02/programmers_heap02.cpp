#include <string>
#include <vector>
#include <iostream>
using namespace std;

bool solution(vector<string> phone_book) {
	bool answer = true;
	string prefix = "";

	for (int i = 0; i < phone_book.size(); i++)
	{
		prefix = phone_book[i];
		//cout << prefix << " this is prefix\n";
		//cout << prefix.size() << "size of prefix\n";
		for (int j = 0; j < phone_book.size(); j++)
		{
			if (i != j)
			{
				if (prefix == phone_book[j].substr(0, prefix.size()))
				{
					answer = false;
					return answer;
				}			
			}
		}
	}
	return answer;
}

int main()
{
	vector<string> phone_book = { "119", "97674223", "1195524421" };

	bool ans = solution(phone_book);

	std::cout << ans << "\n";
}

