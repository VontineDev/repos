#include <stdio.h>

//�������� �ڵ�
typedef struct USERDATA
{
	int nAge;
	char szName[32];
} USERDATA;

void PrintData(USERDATA* pUser)
{
	printf("%d, %s\n", pUser->nAge, pUser->szName);
}

//������� �ڵ�
int main(void)
{
	USERDATA user = { 20,"ö��" };

	//printf("%d, %s\n", user.nAge, user.szName);           //1�ܰ�
	PrintData(&user);

	return 0;
}