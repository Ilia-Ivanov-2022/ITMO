// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 4
// ����������� ������� ����� ����


#include <iostream>
#include <windows.h>

int recSum(int n) {

	int sum = n * 5;
	if ((n -1) > 0) {
		sum += recSum(n - 1);
	}		
	return sum;
}


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int n = 0;
	int S = 0;

	std::cout << "������� �������� ����� n: ";
	std::cin >> n;
	std::cout << "���������: " << recSum(n) << std::endl;


	return 0;
}