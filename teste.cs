#include <stdio.h>
#include <stdlib.h>

int main (){

int a = 1, b = 1, i;

for(i=0,i<1000,i++){

a = a + b;
printf("%d", &a);

}
return 0;
}