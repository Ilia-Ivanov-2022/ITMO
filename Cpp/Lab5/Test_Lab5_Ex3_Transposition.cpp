// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 3
// ���������� ���������� ������ ������� ������������

#include <iostream>
#include <windows.h>
#include <iterator>

int transpoSearch(int arg[], int a);



int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int myArray[8]{ 1, 2, 3, 4, 5, 6, 7, 5 };

	int num = 0;

	std::cout << "������� ����� �� 1 �� 7 ��� ������ � ������� ��� �������."<<std::endl;
	std::cin >> num;

	std::cout << "��������� ������: ";
	for (int a : myArray)
		std::cout << a << " ";
	std::cout << std::endl;

	int idx = transpoSearch(myArray, num);

	std::cout << "������� ����� " << num<<" ����� ������ "<< idx << std::endl;
	std::cout << "������ ����� ������������: ";
	for (int a : myArray)
		std::cout << a << " ";

	return 0;
}


int transpoSearch(int arg[], int a) {
	int temp = 0;
	for (int i = 0; i < 8; i++) {
		if (arg[i] == a && i > 0) {
			std::cout << "arg[" << i << "] = " << arg[i] << std::endl;
			temp = arg[i];
			arg[i] = arg[i - 1];
			arg[i - 1] = temp;
			std::cout << "new arg[" << i << "] = " << arg[i] << std::endl;
			std::cout << "new arg[" << i - 1 << "] = " << arg[i - 1] << std::endl;
			return i;
		}
	}
}