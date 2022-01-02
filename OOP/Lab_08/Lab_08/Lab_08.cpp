

#include <iostream>
#include <ctime>
#include "Head.h"
using namespace std;



int main()
{
	cout << "Olha Pavlushchenko, IS - 02" << endl;
	srand(time(NULL));
	List list;
	int NumberList;
	cout << "Enter the number of elements in List:" << endl;
	cin >> NumberList;
	for (int i = 0; i < NumberList; i++)
	{
		list.push_back(rand()%100);
	}
	cout << "List:" << endl;
	for (int i = 0; i < NumberList; i++)
	{
		cout << list[i] << ' ';
	}
	int Num = 0;
	cout << endl;
	for (int i = 0; i < NumberList; i++)
	{
		Num += list.GetNumber(list[i]);
	}
	cout << endl;
	cout << "Number of elements multiply of 4: " << Num << endl;
	cout << endl;
	cout << "Change the numbers on even positions to 0" << endl;
	list.Change();
	for (int i = 0; i < NumberList; i++)
	{		
		 cout << list[i] << ' ';
	}
	cout << endl;

	
	
}
 
