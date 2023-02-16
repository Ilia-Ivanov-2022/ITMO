// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 4, Exercise 1
// Вычисление корней квадратного уравнения


#include <iostream>
#include <windows.h>
#include <cmath>

int myRoot(double, double, double, double&, double&);

int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	double a, b, c, d, x1, x2;
	double& refX1 = x1;
	double& refX2 = x2;

	std::cout << "Введите значения 'a', 'b', 'c' через пробел: ";
	std::cin >> a >> b >> c;

	int flag = myRoot(a, b, c, refX1, refX2);

	if (flag == 1)
		std::cout << "Корни уравнения: х1 = " << refX1 << ", x2 = " << refX2 << std::endl;
	else if (flag == 0)
		std::cout << "Корень уравнения один: х1 = х2 = " << refX1 << std::endl;
	else if (flag == -1)
		std::cout << "Корней уравнения нет" << std::endl;

	return 0;
}

int myRoot(double a, double b, double c, double& refX1, double& refX2) {

	double d = b * b - 4 * a * c;
	double q = b >= 0 ? (-b - sqrt(d)) / 2 : (-b + sqrt(d)) / 2;
	if (d > 0) {
		refX1 = q / a;
		refX2 = c / q;
		return 1;
	}
	else if (d == 0) {
		refX1 = refX2 = -(b / (2 * a));
		return 0;
	}
	else if (d < 0)
		return -1;

}