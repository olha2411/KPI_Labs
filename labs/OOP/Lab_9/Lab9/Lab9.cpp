
#include "Lab.h"

using namespace std;


int main()
{
	cout << "Olha Pavlushchenko, IS-02," << endl;
	string row1;
	cout << "Enter the row: ";
	cin >> row1;
	string row2;
	cout << "Enter the row: ";
	cin >> row2;
	int(*operation)(string str);
	operation = HasLetters;
	int count1 = operation(row1);
	cout << "Number of letters in row: " << count1;
	cout << endl;
	int count2 = operation(row2);
	cout << "Number of letters in row: " << count2;
	cout << endl;

}


