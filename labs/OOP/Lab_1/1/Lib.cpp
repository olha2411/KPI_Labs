#include "Header.h"
using namespace std;

void func_decrease(int* num) {  //зменшення числа на 1
	int bit = 0;
	int i = 0;
	do {
		*num = *num ^ (1 << i);
		bit = *num & (1 << i);
		i++;

	} while (bit != 0);
	cout << "number is: " << *num << endl;
}

int func_add(int x, int y) {   //додавання двох чисел
	int c;
	while (y != 0)
	{
		c = x & y;
		x = x ^ y;
		y = c << 1;
	}
	cout << "sum is: " << x;
	return x;
}