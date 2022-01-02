#include "Header.h"
using namespace std;

int main()
{
	cout << "Olha Pavlushchenko, IS-02" << endl;
	int A;
	cout << "Enter the number you want to decrease: ";
	cin >> A;
	func_decrease(&A);		//зменшення числа на 1

	int x, y;
	cout << "Enter the first operand: ";
	cin >> x;
	cout << "Enter the second operand: ";
	cin >> y;
	func_add(x, y); //додавання двох чисел
}

