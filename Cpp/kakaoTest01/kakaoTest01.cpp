#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

//string deleteDot(string str, int idx)
//{
//	string tmpStr = str;
//
//	if (tmpStr.size() == 0)
//	{
//		return tmpStr;
//	}
//	if (tmpStr.size() == 1)
//	{
//		if (tmpStr.front() == '.')
//		{
//			return "";
//		}
//	}
//	else
//	{
//		if (tmpStr[idx] == '.' && tmpStr[idx + 1])
//		{
//			tmpStr[idx] == ' ';
//			tmpStr.erase(std::remove(tmpStr.begin(), tmpStr.end(), ' '), tmpStr.end());
//		}
//		deleteDot(tmpStr, idx + 1);
//	}
//	return tmpStr;
//}


string solution(string new_id) {
	string answer = "";

	string tmp = new_id;

	//step 1
	for (int i = 0; i < tmp.size(); i++)
	{
		tmp[i] = tolower(tmp[i]);
	}
	//step 2
	for (int i = 0; i < tmp.size(); i++)
	{
		if (tmp[i] < 'a' || tmp[i]>'z')
		{
			if (tmp[i] < '0' || tmp[i]>'9')
			{
				if (tmp[i] != '-' && tmp[i] != '_' && tmp[i] != '.')
				{
					tmp[i] = ' ';
				}
			}
		}
	}
	tmp.erase(std::remove(tmp.begin(), tmp.end(), ' '), tmp.end());

	//step 3
	//tmp =deleteDot(tmp, 0);
	for (int j = 0; j < tmp.size(); j++)
	{
		for (int i = 0; i < tmp.size(); i++)
		{
			if (tmp[i] == '.' && tmp[i + 1] == '.')
			{
				tmp[i] = ' ';
			}
			tmp.erase(std::remove(tmp.begin(), tmp.end(), ' '), tmp.end());
		}
	}

	//step 4
	if (tmp.size() != 0)
	{
		if (tmp.front() == '.')
		{
			tmp.front() = ' ';
			tmp.erase(std::remove(tmp.begin(), tmp.end(), ' '), tmp.end());
		}
		if (!tmp.empty() && tmp.back() == '.')
		{
			tmp.back() = ' ';
			tmp.erase(std::remove(tmp.begin(), tmp.end(), ' '), tmp.end());
		}
	}


	//step 5
	if (tmp.size() == 0)
	{
		tmp = 'a';
	}

	//step 6
	if (tmp.size() >= 16)
	{
		tmp = tmp.substr(0, 15);
		if (tmp.back() == '.')
		{
			tmp.back() = ' ';
		}
		tmp.erase(std::remove(tmp.begin(), tmp.end(), ' '), tmp.end());
	}

	//step 7
	if (tmp.size() <= 2)
	{
		char lastChar = tmp.back();
		while (tmp.size() < 3)
		{
			tmp.push_back(lastChar);
		}
	}

	answer = tmp;
	return answer;
}
int main()
{
	string new_id = "!";

	string ans = solution(new_id);

	cout << ans << endl;
}

