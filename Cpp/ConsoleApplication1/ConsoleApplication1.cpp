#include <stdio.h>
int MostVal(int num1, int num2, int num3)
{
	
	if (num1 > num2)
		return (num1 >num3) ? num1 : num3;
	else
		return (num2> num3) ? num2 : num3;
}

int LeastVal(int num1, int num2, int num3)
{

	if (num1 < num2)
		return (num1 < num3) ? num1 : num3;
	else
	
		return (num2 < num3) ? num2 : num3;
}

int ReadNum(void)
{
	int num;
	scanf("%d", &num);
	return num;
}

int CtoF(int num1)
{
	return (1.8 * num1 + 32);
}
int FtoC(int num1)
{
	return (num1 - 32) / 1.8;
}

void Pavo(int n)
{
	int num0=0, num1=1, num2;
	printf("%4d", num0);
	printf("%4d", num1);
	for (int i = 1; i < n-1; i++)
	{
		num2 = num0 + num1;
		printf("%4d", num2);
		num0 = num1;
		num1 = num2;
	}
	return;
}
int main(void)
{
	int num1, num2, num3;
	num1 = ReadNum();	
	num2 = ReadNum();
	num3 = ReadNum();

	printf("%d \n", MostVal(num1, num2, num3));
	printf("%d \n", LeastVal(num1, num2, num3));

	//printf("화씨를 섭씨로: %d \n", FtoC(num1));
	//printf("섭씨를 화씨로: %d \n", CtoF(num2));

	//Pavo(num1);

	return 0;
}
	

























































































































































