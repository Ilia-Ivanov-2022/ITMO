// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 1
// Передача массива в функцию


#include <iostream>
#include <windows.h>
#include <vector>

std::vector<int> good;
std::vector<int> wrong;
int testMultiplication(int res[], const int n);


int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
		
	const int n = 10;
	int results[n];

	int k = testMultiplication(results, n);

	std::cout << "\rAll: ";
	for (int i = 0; i < n; i++) {
		std::cout << results[i] << ", " << std::ends;
	}
	std::cout << "Count error: " << k << std::endl;

	std::cout << "\rGood: ";
	for (int i = 0; i < good.size(); i++) {
		std::cout << good[i] << ", " << std::ends;
	}
	std::cout<< std::endl;

	std::cout << "\rWrong: ";
	for (int i = 0; i < wrong.size(); i++) {
		std::cout << wrong[i] << ", " << std::ends;
	}

	return 0;
}

int testMultiplication(int res[], const int n) {

	srand(time(NULL));
	int a, b, c;
	int k = 0;

	for (int i = 0; i < n; i++)
	{
		// инициализация операндов случайными числами от 1 до 101
		a = rand() % 10 + 1;
		b = rand() % 10 + 1;
		std::cout << a << " * " << b << " = ";
		std::cin >> c;
		res[i] = c;
		if (a * b != c) {
			wrong.push_back(c);
			k++; // операция «инкремент», аналогично: k = k + 1
			std::cout << "Error! ";
			std::cout << a << " * " << b << " = " << a * b << std::endl;
		}
		else good.push_back(c);
	}
	return k;
}