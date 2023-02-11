// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 2, Exercise 4
// Coins Change


#include <iostream>
#include <Windows.h>


int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	double moneyToSplit = 0;
	int splitBalance;
	int change[9] = {};
	int coins[9] = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };

	std::cout << "¬ведите сумму дл€ размена: ";
	std::cin >> moneyToSplit;

	splitBalance = ceil(moneyToSplit * 100);

	for (int i = 0; i < 9; i++) {
		if (splitBalance / coins[i] > 0) {
			change[i] = splitBalance / coins[i];
			splitBalance = splitBalance % coins[i];
		}
	}

	std::string nom;
	for (int i = 0; i < 9; i++) {
		if (coins[i] / 100 > 0) {
			nom = " рублевых монет: ";
			std::cout << coins[i] / 100 << nom << change[i] << std::endl;
		}			
		else {
			nom = " копеечных монет: ";
			std::cout << coins[i] << nom << change[i] << std::endl;
		}
	}


}