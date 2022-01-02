#include "Head.h"
using namespace std;
int main()
{
	cout << "Olha Pavlushchenko, IS-02" << endl;
	Text text;
	int number = 0;
	do{
		cout << "Enter the number of rows: ";
		cin >> number;
	} while (number < 0);
	string str1;
	cin.ignore();
	for (int i = 0; i < number; i++)
	{
		getline(cin, str1);				//введення рядка
		char* Arr = new char[str1.size() + 1];
		Arr = change(str1, Arr);			//перетворення в масив чарів 
		MyString str = Arr;					
		delete[] Arr;
		text.Add_Row(str);				//додати рядок до тексту

	}
	cout << endl;
	cout << "Your text:" << endl;
	text.Print_Text();				//виведення тексту
	cout << endl;
	cout << "Enter the row to add: ";   
	string str2;						
	getline(cin, str2);
	char* Arr = new char[str2.size() + 1];
	Arr = change(str2, Arr);
	MyString str = Arr;
	delete[] Arr;
	text.Add_Row(str);				//додавання рядка
	text.Print_Text();
	cout << endl;
	int num;
	cout << "Enter the number of row to delete:";
	cin >> num;
	text.Delete_row(num);				//видалення рядка
	text.Print_Text();
	cout << endl;
	cout << "The row of first symbols: " << endl;
	text.RowFirtstSymbols();				// виведення рядка перших символів тексту
	cout << endl;	
	cout << "The shortest row is:";
	text.Find_min_row();						//знаходження найменшого рядка
	cout << endl;
	cout << endl;
	cout << "Enter the symbol to check it's quantity:";
	char s;
	cin >> s;
	double f = text.Symbol_frequency(s) / text.Text_length();			//частота символа
	cout << f * 100 << '%';
	cout << endl;
	text.clear();
	cout << endl;
	text.Print_Text();
	cout << endl;

}


