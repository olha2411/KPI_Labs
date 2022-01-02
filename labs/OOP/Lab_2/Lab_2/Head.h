#pragma once
#include <iostream>
#include <iomanip>
#include <string>

class MyString
{
private:
	char* str;
	int length;

public:
	MyString();										//конструктор
	MyString(char* str);							//конструктор
	MyString(const MyString& other);				//копіювання
	char operator[](int index);						//перевантаження оператора індексації
	MyString& operator =(const MyString& other);	//перевантаження оператора присвоєння
	char FindFirsrsSymbol();						//знаходження першого символа рядка
	void print_row();								//вивдення рядка
	int find_length();								//довжина рядка
	~MyString();									//деструктор
};

class Text
{

private:
	MyString* text;
	int num;
public:
	Text();										//конструктор
	Text(MyString* text, int num);				//конструктор
	Text(Text& other);							//копіювання
	MyString operator[](int index);				//перевантаження оператора індексації
	void Add_Row(MyString& s);					//додавання рядка
	void Delete_row(int num_to_delete);			//видалення рядка
	char* FirtstSymbols();						//знаходження перших символів кожного рядка
	void RowFirtstSymbols();					//формування рядка з перших символів кожного рядка тексту
	MyString Find_min_row();					//знаходження мінімального рядка
	double Text_length();						//знаходження довжини рядка
	double Symbol_frequency(char s);			//знаходження частоти певного символу в тексті
	void Print_Text();
	void clear();								//очищення тексту
	~Text();									//деструктор
};
char* change(std::string str1, char* Arr);		