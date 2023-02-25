// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 6, Exercise 1
// Запись текста в файл

#include <iostream>
#include <windows.h>
#include <fstream>

void writeToFile(const char* filename);

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	writeToFile("poetry.txt");
	
	return 0;
}

void writeToFile(const char* filename) {

	const int MAX = 500;
	char str[MAX];

	std::cout << "Введите текст стихотворения" << std::endl;

	std::ofstream fout("poetry.txt");

	if (fout.is_open()) {
		std::cin.get(str, MAX, '#');
		fout << str << std::endl;
	}

	fout.close();

}