#include<string.h>
#include<stdio.h>
void HexadecimalToDecimal() {
    int p, j;
    int i;
    int k=0;
    char n[50];
    do {
        printf("\tEnter Hexadecimal number:");
        fpurge(stdin);
        gets(n);
    }
    unsigned long long int decimal[50];
    j = 0;
    for (i = strlen(n) - 1; i >= 0; i--) {
        if (isdigit(n[i]))
            p = n[i] - 48;
        else if (isupper(n[i]))
            p = n[i] - 55;
        else if (islower(n[i]))
            p = n[i] - 87;
        decimal[k] = p * pow(16, j);
        k=k+1;
        j++;
    }
    unsigned long long int decimall;
    for(int n=0; n <= k; n++){
        decimall=decimal[n]+decimall;
    }
    printf("\tDecimal number is: %lld\n", decimall);
}

int main(int argc, char** argv) {
	HexadecimalToDecimal();
    return 0;
}