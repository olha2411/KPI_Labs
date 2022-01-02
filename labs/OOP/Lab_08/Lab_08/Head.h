#pragma once
#include <iostream>

class List
{
public:
	List();
	int Number;
	void push_back(short data);
	int GetSize() { return Size; }
	int GetNumber(short data);
	short& operator[](const int index);
	void Change();

private:
	class Node
	{
	public:
		Node* pointerNext;
		short data;
		Node(short data = NULL, Node* pointerNext = nullptr);	
	};

	Node* head;
	int Size;
};