// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 7, Exercise 3
// Решение квадратного уравнения Tuple

#include <iostream>
#include <windows.h>
#include <tuple>

using namespace std;

tuple<double, double, int>getResult(double a, double b, double c);

int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	double a, b, c;
	
	std::cout << "\nВведите значения 'a', 'b', 'c' через пробел: ";
	std::cin >> a >> b >> c;

	tuple<double, double, int> tpResult = getResult(a, b, c);
	
	if (get<2>(tpResult) == -1)
		printf("\nКорней уравнения нет");
	else if (get<2>(tpResult) == 1)
		printf("\nКорни квадратного уравнения: %f, %f", get<0>(tpResult), get<1>(tpResult));
	else if (get<2>(tpResult) == 0)
		printf("\nКорень уравнения один: х1 = х2 = %f", get<0>(tpResult));

	return 0;
}


tuple<double, double, int> getResult(double a, double b, double c) {

	int flag;
	double x1, x2;

	double d = b * b - 4 * a * c;
	double q = b >= 0 ? (-b - sqrt(d)) / 2 : (-b + sqrt(d)) / 2;
	if (d > 0) {
		x1 = q / a;
		x2 = c / q;
		flag = 1;		
	}
	else if (d == 0) {
		x1 = x2 = -(b / (2 * a));
		flag = 0;
	}
	else if (d < 0) {
		x1 = x2 = NULL;
		flag = -1;
	}
	
	return make_tuple(x1, x2, flag);
}
