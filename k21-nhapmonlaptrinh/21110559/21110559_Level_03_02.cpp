#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
int main()
{
	/*S=1+2*2+...N*/
	int n,s=0;
 	printf("Nhap so nguyen duong n: ");scanf("%d", &n);
 	for(int i = 1; i <= n; i++)
 	{
	 	s=s+i*i;
	 }
	  printf("Tong 1+2^2+...+%d^2 la %d: \n", n, s);
  return 0;
}