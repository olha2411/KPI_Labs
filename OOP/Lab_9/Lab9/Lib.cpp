#include "Lab.h"

int HasLetters(std::string row) {
	int counter = 0;						//number of letters
	if (row.size() != NULL) {
		for (int i = 0; i < row.size(); i++)
		{
			if (isalpha(row[i])) {
				counter++;
			}
		}
		return counter;
	}
	else {

		throw new std::exception("The row is empty");
	}

}