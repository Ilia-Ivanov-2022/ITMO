// ITMO.CppCourse2023 TestExerciseLab1.cpp : This file contains the 'main' function.Program execution begins and ends there.
//

#include <iostream>
#include <windows.h>
#include <iomanip>
#include <cmath>

int main() {

	system("chcp 1251");

	int n, x, y, x1, x2, y1, y2;
	double sum = 0.0;

	std::cout << "������� ����� ������ ��������������: " << std::endl;
	std::cin >> n;
	std::cout << "������� ���������� ������ �������, x � y: " << std::endl;
	std::cin >> x;
	std::cin >> y;
	x1 = x;
	y1 = y;
	std::cout << "������� ���������� ��������� ������ �������������" << std::endl;

	for (int i = 1; i < n; i++) {
		
		std::cout << "x: " << std::endl;
		std::cin >> x2;
		std::cout << "y: " << std::endl;
		std::cin >> y2;

		sum += x1 * y2 - x2 * y1;

		x1 = x2;
		y1 = y2;
	}

	sum = sum + x2 * y - x + y2;
	std::cout << "������� ��������������: " << abs(sum) / 2 << std::endl;

	return 0;


}
