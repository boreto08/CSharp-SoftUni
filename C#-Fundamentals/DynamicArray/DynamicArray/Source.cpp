#include <stdio.h>
#include <stdlib.h>
void count(int br, int *mas);
void out(int br, int *mas);
void sum(int br, int *mas)

int main()	
{
	int n ,i ,*p = NULL;
	printf("Enter size");
	scanf_s("%d", &n);
	p = (int*)malloc(n * sizeof(int));
	if (p == NULL) {
		printf("No memory\n");
		return 1;
	}
	for ( i = 0; i < n; i++)
	{
		printf_s("[%d]=", i);
		scanf_s("%d", p + i);
	}
	count(n, p);
	sum(n, p);
	if (p != NULL)
	{
		free(p);
		printf_s("Memory is free");
		p = NULL;
	}

	return 0;
}

void sum(int br, int *mas) 
{
	int i; int s = 0;
	for ( i = 0; i < br; i++)
	{
		s += *(mas + i);
	}
	printf_s("sum = %d\n", s);
}
void out(int br, int *mas) 
{
	
	int i;
	for ( i = 0; i < br; i++)
	{
		printf_s("[%d]= %d\n", i, *(mas + i));
		
	}
	
}
void count(int br, int *mas) {
	int i, b = 0;
	for ( i = 0; i < br; i++)
	{
		if ((*(mas + i) % 2) == 0)
		{
			b++;
		}
		out(br, mas);
	}
	printf_s("number even nums\n");
}