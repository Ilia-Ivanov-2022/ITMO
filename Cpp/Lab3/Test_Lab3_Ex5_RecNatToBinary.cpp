// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 5
// ���������� �������� ��� �������� ������ ����� � �������� ���


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
	std::cout << "������� ����� ��� �������� � �������� ���: ";
	std::cin >> num;
	std::cout << "����� " << num << " � �������� ���� : ";
	decToBin(num);

	return 0;
}

