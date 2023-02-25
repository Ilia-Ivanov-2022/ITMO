// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 1
// SNILS Test


#include <iostream>
#include <windows.h>
#include <string>
#include "Tets_Lab3_SNILS.h"


// Input SNILS and invokes snilsCooker() to test for permitted characters;
std::string& snilsInput(std::string& str) {
	std::cout << "Введите СНИЛС: ";
	std::getline(std::cin, str);
	while (true)
	{
		if (snilsCooker(str)) {
			if (snilsValidator(str))
				return str;
			else {
				snilsInput(str);
			}
		}
		else {
			std::cout << "Некорректный номер. Используйте цифры, пробер, дефис." << std::endl;
			snilsInput(str);
		}
	}
	
}

bool snilsCooker(std::string str) {

	std::string snilsCooked;

	for (int i = 0; i < str.length(); ++i) {
		if (str[i] - '0' >= 0 && str[i] - '0' <= 9 || str[i] == ' ' || str[i] == '-')
		{
			continue;
		}
		else snilsCooked += str[i];
	}
	if (snilsCooked.length() == 0)
		return true;
	else return false;	
}

// Removes all non digit characters.
std::string snilsCleaner(std::string str) {

	std::string cleanStr;
	cleanStr.reserve(str.length()); // reserves memory for the length of initial string
	/*for (auto c : str) {
		if (isdigit(c))*/
	for (int i = 0; i < str.length(); ++i) {	// another version
		if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
		{
			//cleanStr += c;
			cleanStr += str[i];
		}
	}

	return cleanStr;
}


bool snilsValidator(std::string str) {

	std::string cleanStr = snilsCleaner(str);
	bool flag = false;
	int snils[9];
	int ctrNumber = 0;

	// Test SNILS for triplicates
	for (int i = 0; i < 9; i++) {
		int count = 0;
		for (int j = 0; j < 9; j++) {
			if (cleanStr[j] == cleanStr[i])
				count++;
			if (count > 2) {
				std::cout << "Неправильный номер СНИЛС. Цифры могут повторяться не более двух раз" << std::endl;
				flag = false;
				break;
			}
			else
				flag = true;
		}
	}

	// SNILS convert string to array
	for (int i = 0; i < 9; i++) {
		snils[i] = cleanStr[i] - 48;
	}
	// Control Number string to int
	ctrNumber = stoi(cleanStr.substr(9, 10));

	// Control Sum
	int ctrSum = 0;
	for (int i = 0; i < 9; i++) {
		ctrSum += snils[i] * (sizeof(snils) / sizeof(int) - i);
	}

	// Control Sum vs Control Number
	if (flag) {
		flag = false;
		if (ctrSum < 100 && ctrSum == ctrNumber) {
			flag = true;
			std::cout << "case 1: <100, ctrSum == ctrNubmer" << std::endl;
		}
		else if ((ctrSum == 100 || ctrSum == 101) && ctrNumber == 0) {
			flag = true;
			std::cout << "case 2: ==100, ctrNubmer == 0" << std::endl;
		}
		else if (ctrSum > 101) {
			if (ctrSum % 101 < 100 && ctrSum % 101 == ctrNumber) {
				flag = true;
				std::cout << "case 3.1: >100" << ctrSum % 101 << std::endl;
			}
			else if (ctrSum % 101 > 100 && ctrNumber == 0) {
				flag = true;
				std::cout << "case 3.2: >100" << ctrSum % 101 << std::endl;
			}
		}
		else
			flag = false;
	}

	return flag;
}


int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	std::string snilsStr;
	std::string& refSnilsStr = snilsStr;
	std::string* pSnStr;
	std::string snlsClr;

	snilsStr = snilsInput(refSnilsStr);

	pSnStr = &snilsStr;

	
	std::cout << snilsStr << std::endl;
	std::cout << *pSnStr << std::endl;
	std::cout << &refSnilsStr << std::endl;

	/*snlsClr = snilsCleaner(snilsStr);

	std::cout << snlsClr << std::endl;*/

	//std::cout << snilsValidator(snlsClr) << std::endl;

	// return flag;

	return 0;
}