// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 7, Exercise 2
// Решение квадратного уравнения Struct

#include <iostream>
#include <windows.h>

using namespace std;

struct squareRoots
{
	double x1;
	double x2;
};

squareRoots myRoot(double, double, double, squareRoots);

int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	double a, b, c;
	squareRoots sR{};

	std::cout << "\nВведите значения 'a', 'b', 'c' через пробел: ";
	std::cin >> a >> b >> c;

	sR = myRoot(a, b, c, sR);

	if (sR.x1 == NULL && sR.x2 == NULL)
		printf("\nКорней уравнения нет");
	else if (sR.x1 != sR.x2)
		printf("\nКорни квадратного уравнения: %f, %f", sR.x1, sR.x2);
	else if (sR.x1 == sR.x2)
		printf("\nКорень уравнения один: х1 = х2 = %f", sR.x1);

	return 0;
}

squareRoots myRoot(double a, double b, double c, squareRoots sqR) {

	double d = b * b - 4 * a * c;
	double q = b >= 0 ? (-b - sqrt(d)) / 2 : (-b + sqrt(d)) / 2;
	if (d > 0) {
		sqR.x1 = q / a;
		sqR.x2 = c / q;
	}
	else if (d == 0)
		sqR.x1 = sqR.x2 = -(b / (2 * a));
	else if (d < 0)
		sqR.x1 = sqR.x2 = NULL;
	return sqR;
}