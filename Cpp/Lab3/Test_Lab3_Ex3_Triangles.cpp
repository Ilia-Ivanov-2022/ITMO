// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 3
// ������ � ���������� ��������������


#include <iostream>
#include <windows.h>
#include <cmath>

int triangleArea(int);
int triangleArea(int, int, int);

int main() {

	system("chcp 1251");

	int a = 0, b = 0, c = 0;
	int choise;

	int& aRef = a;
	int& bRef = b;
	int& cRef = c;

	std::cout << "���������� ������� ������������" << std::endl;
	std::cout << "����� ���� ������������:" << std::endl;
	std::cout << "'1' - ��������������;\n'2' - ��������������." << std::endl;
	std::cin >> choise;
	std::cout << "�� �������: ";

	switch (choise)
	{
	case 1:
		std::cout << "�������������� �����������" << std::endl;
		std::cout << "������� ����� ������ ������������ ����� ������: ";
		std::cin >> a >> b >> c;
		std::cout << "������� ������������ = " << triangleArea(a, b, c) << std::endl;
		break;

	case 2:
		std::cout << "������������ �����������" << std::endl;
		std::cout << "������� ����� ������� ������������: ";
		std::cin >> a;
		std::cout << "������� ������������ = " << triangleArea(a) << std::endl;
		break;
	default:
		std::cout << "�� ����� �������� �����" << std::endl;
		break;
	}

	return 0;
}

int triangleArea(int a)
{
	int p = pow(a, 3) / 2;

	return pow((p * pow((p - a), 3)), 0.5);
}

int triangleArea(int a, int b, int c)
{
	double p = (a + b + c) / 2;

	return pow((p * (p - a) * (p - b) * (p - c)), 0.5);
}
