#include "Head.h"

List::List()
{
	Size = 0;
	head = nullptr;

}

List::Node::Node(short data, Node* pointerNext) {
	this->data = data;
	this->pointerNext = pointerNext;
}

void List::push_back(short data)                 //включення в кінець списку
{
	if (head == nullptr) {
		head = new Node(data);
	}
	else
	{
		Node* current = this->head;

		while (current->pointerNext != nullptr) {
			current = current->pointerNext;
		}
		current->pointerNext = new Node(data);
	}
}
int List::GetNumber(short data) {                //кількість чисел кратних 4

	if (data % 4 == 0) {
		Number++;
	}
	else {
		Number = 0;
	}

	return Number;
}

void List::Change() {                             //заміна чисел на парній позиції на 0
	int counter = 0;
	Node* current = this->head;
	while (current != nullptr) {

		if (counter % 2 != 0) {
			current->data = 0;
		}
		current = current->pointerNext;
		counter++;
	}

}

short& List::operator[](const int index)
{
	int counter = 0;
	Node* current = this->head;
	while (current != nullptr) {
		if (counter == index) {
			return current->data;
		}
		current = current->pointerNext;
		counter++;
	}
}
