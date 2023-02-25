// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 5
// ѕрименение рекурсии дл€ перевода целого числа в двоичный код


#include <iostream>
#include <windows.h>

void decToBin(int num) {

	if (num > 1)
		decToBin(num / 2);
	std::cout << num % 2;
}

int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int num;
	std::cout << "¬ведите число дл€ перевода в двоичный код: ";
	std::cin >> num;
	std::cout << "„исло " << num << " в двоичном коде : ";
	decToBin(num);

	return 0;
}

