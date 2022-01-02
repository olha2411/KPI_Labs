#include "Head.h"

MyString::MyString() {
	str = new char[1];	
	length = 0;
}

MyString::MyString(char* str) {
	length = 0;
	if (str != nullptr)
	{
		while (str[length] != '\0') {  
			length++;					
		}
		this->str = new char[length + 1];  
		for (int i = 0; i < length; i++)
		{
			this->str[i] = str[i];
		}
		this->str[length] = '\0';
	}
	else {
		this->str = new char[1];
		this->str[0] = '\0';
	}
}
MyString::MyString(const MyString& other) {
	length = strlen(other.str);
	str = new char[length + 1];
	for (int i = 0; i < length; i++)
	{
		str[i] = other.str[i];
	}
	str[length] = '\0';

}

char MyString:: operator[](int index) {
	return this->str[index];
}
MyString& MyString::operator =(const MyString& other) {		//перевантаження оператора присвоєння
	if (str != nullptr) {
		delete[] str;
	}
	length = strlen(other.str);			//копіювання довжини масива
	str = new char[length + 1];			
	for (int i = 0; i < length; i++)
	{
		str[i] = other.str[i];			//присвоєння елементу масива іншому 
	}
	str[length] = '\0';
	return *this;
}
char MyString::FindFirsrsSymbol() {
	char first = str[0];				//знаходження першого символу рядка
	return first;
}
void MyString::print_row() {
	std::cout << str;
}
/*MyString& operator +(const MyString& other) {			//оператор додавання
	MyString new_str;
	int thisLength = strlen(this->str);
	int otherLenght = strlen(other.str);
	int i = 0;

	new_str.str = new char[thisLength + otherLenght + 1];
	for (; i < thisLength; i++) {
		new_str.str[i] = this->str[i];
	}
	for (int j = 0; j < otherLenght; j++, i++) {

		new_str.str[i] = other.str[j];
	}
	new_str.str[thisLength + otherLenght] = '\0';
	return new_str;
}*/
int MyString::find_length() {			//довжина рядка
	return length;
}

MyString::~MyString() {
	delete[] str;
}
Text::Text() {
	text = nullptr;
	num = 0;
}

Text::Text(MyString* text, int num) {  //конструктор
	if (text != nullptr) {
		this->num = num;
		this->text = new MyString[num];
		for (int i = 0; i < num; i++)
		{
			this->text[i] = text[i];

		}
	}
	else {
		this->text = nullptr;
		this->num = 0;
	}
}

Text::Text(Text& other) {        //копіювання
	num = other.num;
	if (num > 0) {
		text = new MyString[num];
		for (int i = 0; i < num; i++)
			text[i] = other.text[i];
	}
	else {
		text = nullptr;
	}
}

MyString Text::operator[](int index) {		 //перевантаження оператора індексації
	return this->text[index];
}

void Text::Add_Row(MyString& s) {
	if (num > 0) {
		num++;								//збільшення розміру масива рядків
		MyString* text1 = new MyString[num];  //створення масиву на 1 елемент більший за розмір 
		for (int i = 0; i < (num - 1); i++)
		{
			text1[i] = text[i];					//копіюєм елементи з початкового масиву в новостворений
		}
		text1[num - 1] = s;						//останньому елементу присвоюєм новий рядок
		delete[] text;							//видаляєм початковий масив 
		text = new MyString[num];				//створюєм новий масив рядків
		for (int i = 0; i < num; i++)
		{
			text[i] = text1[i];					//копіюєм з тимчасового масиву елементи
		}
		delete[] text1;							//видаляєм тимчасовий масив
	}
	else {
		num++;
		text = new MyString[num];
		text[0] = s;
	}

}
void Text::Delete_row(int num_to_delete) {				//видалення рядка

	for (int i = num_to_delete - 1; i < num - 1; i++)   //копіювання елементів крім рядка, що потрібно видалити
	{
		text[i] = text[i + 1];
	}

	MyString* text1 = new MyString[num - 1];		//створення масиву розміром на 1 менше
	for (int i = 0; i < num - 1; i++)
	{
		text1[i] = text[i];							//копіювання елементів з попереднього масиву в тимчасовий
	}
	delete[] text;						//видалення масиву
	num--;							//зменшення розміру масива рядків
	text = new MyString[num];		//створення масиву рядків нового розміру
	for (int i = 0; i < num; i++)
	{
		text[i] = text1[i];				//копіювання елементів
	}
	delete[] text1;
}
char* Text::FirtstSymbols() {					//створення рядка з перших символів всіх рядків тексту
	char* first = new char[num];
	for (int i = 0; i < num; i++)
	{
		first[i] = text[i].FindFirsrsSymbol();
	}
	return first;
}
void Text::RowFirtstSymbols() {
	char* first = FirtstSymbols();
	for (int i = 0; i < num; i++)
	{
		std::cout << first[i];
	}
}

MyString Text::Find_min_row() {					//знаходження найменшого рядка
	MyString temp = text[0];
	for (int i = 0; i < num - 1; i++)
	{
		if (temp.find_length() > text[i + 1].find_length())
		{
			temp = text[i + 1];
		}
	}
	temp.print_row();
	return temp;
}

double Text::Text_length() {					//визначення довжини тексту
	double length = 0;
	for (int i = 0; i < num; i++)
	{
		length += text[i].find_length();

	}
	return length;
}

double Text::Symbol_frequency(char s) {				//визначення кількості певних символів в тексті
	double count = 0;
	for (int i = 0; i < num; i++)
	{
		for (int j = 0; j < text[i].find_length(); j++)
		{
			if (text[i][j] == s) {
				count++;
			}
		}
	}
	return count;
}

void Text::Print_Text() {
	if (text != nullptr) {
		for (int i = 0; i < num; i++)
		{
			text[i].print_row();
			std::cout << std::endl;
		}
	}
	else {
		std::cout << "You deleted your text";
	}
}
void Text::clear() {				//очищення тексту
	delete[] text;
	text = nullptr;
}


Text::~Text() {
	delete[] text;
}

char* change(std::string str1, char* Arr) {
	for (int i = 0; i < str1.size(); i++)
	{
		Arr[i] = str1[i];
	}
	Arr[str1.size()] = '\0';
	return Arr;
}