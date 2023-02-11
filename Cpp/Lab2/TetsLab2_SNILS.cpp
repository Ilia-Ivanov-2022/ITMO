// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 2, Exercise 4
// SNILS Test


#include <iostream>
#include <windows.h>
#include <string>


int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	bool flag = false;

	std::string snilsStr;
	int snils[9];
	int ctrNumber = 0;

	// SNILS input
	std::cout << "Введите 11 цифр СНИЛС: ";
	std::cin >> snilsStr;
	std::cout << std::endl;

	// Test SNILS for triplicates
	for (int i = 0; i < 9; i++) {
		int count = 0;
		for (int j = 0; j < 9; j++) {
			if (snilsStr[j] == snilsStr[i])
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
		snils[i] = snilsStr[i] - 48;
	}
	// Control Number string to int
	ctrNumber = stoi(snilsStr.substr(9,10));

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
	
	
	std::cout << "Control Sum: " << ctrSum << std::endl;
	std::cout << "ctrSum % 101: " << ctrSum % 101 << std::endl;
	std::cout << "Control Num: " << ctrNumber << std::endl;
	
	// return flag;
	std::cout << "flag: " << flag << std::endl;


	return 0;
}