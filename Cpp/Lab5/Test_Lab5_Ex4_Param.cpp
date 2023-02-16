// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 4
// Передача параметров в программу

#include <iostream>
#include <windows.h>
#include <cstring>
#include <string>


int someOperation(std::string args[]);
std::string inputNumber();



int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int selection;
	int result;

	// Parameter string array for function
	std::string params[4]{};

	// Fill up the array with values
	
	params[0] = "someOperation";
	
	// param[1];
	std::cout << "Выберите 1 - сложение, 2- умножение: ";
	std::cin >> selection;
	if (selection == 1)
		params[1].append("-a");
	else if (selection == 2)
		params[1].append("-m");
	else {
		std::cout << "Неверное значение" << std::endl;
	}

	// Operation definition
	std::string operation;
	if (params[1] == "-a")
		operation.append("сложения");
	else if(params[1] == "-m")
		operation.append("умножения");

	// param[2, 3];
	std::cout << "Введите числа для "<< operation <<std::endl;
	if (params[1] == "-a" || params[1] == "-m") {
		while (params[2].length() == 0) {
			std::cout << "Введите первое число: ";
			params[2].append(inputNumber());
		}
		while (params[3].length() == 0) {
			std::cout << "Введите второе число: ";
			params[3].append(inputNumber());
		}		
	}
	
	// Testing for four parameters
	int counter = 0;
	for (auto el : params) {
		if (el.length() != 0)
			counter++;
	}
	if (counter == 4)
		result = someOperation(params);
	
	// Result output
	std::cout<<"Результат "<<operation<< " чисел " << params[2] <<" и "<<params[3] <<" равен "<< result << std::endl;

	return 0;
}

std::string inputNumber() {
	int result = 0;
	std::string str;
	std::cin >> str;
	for (int i = 0; i < str.length(); i++)
		if (isdigit(str[i])) {
			result++;
		}
		else {
			std::cout << "Nan ";
			break;
		}
	if(result != 0)
		return str;
}


int someOperation(std::string args[])
{	
	if (args[1].compare("-a")) {
		return stoi(args[2]) * stoi(args[3]);
	}
	else if (args[1].compare("-m")) {
		return stoi(args[2]) + stoi(args[3]);
	}	
}
