#include <stdio.h>
#include <stdlib.h>


int main()
{
	unsigned int number = 0;
    unsigned int prev=0, cur=1;
	int counter = 0;

	while (number < INT_MAX)
	{
		number = prev + cur;
		prev = cur;
		cur = number;
		counter++;
	}
	printf("Number : %u\nCounter:%d", prev,counter);

	unsigned int sum = 1;
	prev = 0;
	cur = 1;
	number = 0;

	while (sum < INT_MAX)
	{
		number = prev + cur;
		prev = cur;
		cur = number;
		sum += number;
	}
	sum -= number;
	printf("\nMax sum :%u\n", sum);
	system("pause");
}