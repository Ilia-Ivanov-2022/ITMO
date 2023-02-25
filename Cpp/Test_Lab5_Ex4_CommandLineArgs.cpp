// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 4
// Передача параметров в программу

#include <iostream>
#include <windows.h>
#include <cstring>
#include <string>

using namespace std;


int main(int argc, char* argv[]) {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int counter;
	printf("Прогамма для сложения и умножения целых чисел: %s", argv[0]);
	if (argc == 4)
	{
		printf("\nКоличество переданных аргументов: %d", argc);
		printf("\n----Переданные аргументы:----");
		for (counter = 0; counter < argc; counter++)
			printf("\nargv[%d]: %s", counter, argv[counter]);
	}

	if (argc < 4) {
		printf("\nНедостаточное количество аргументов");
		printf("\nКоличество переданных аргументов: %d", argc);
		printf("\nВведите 4 аргумента:");
		printf("\n1. Название программы");
		printf("\n2. '-a' для сложения или '-m' для умножения");
		printf("\n3 & 4. Два целых числа в качестве 3 и 4 аргументов");
	}
		
	if (strncmp(argv[1], "-a",2) == 0)
		printf("\nРезультат сложения: %d", (atoi(argv[2]) + atoi(argv[3])));
	else if (strncmp(argv[1], "-m", 2) == 0)
		printf("\nРезультат умножения: %d", (atoi(argv[2])* atoi(argv[3])));

	return 0;
}
