// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 3, Exercise 2
// Применение итерации реализации функции


#include <iostream>
#include <windows.h>


double cR(double&);

double cR(double& a) {
	return pow(a, 1.0 / 3);
}

double cR(double& a, double& rD) {

	double increment = 0.000001;
	double rootInitial = a / rD;
	double rt = rootInitial;
	double rslt = a;

	while (rslt - rt >= increment)
	{
		for (int i = 0; i < rootInitial; i++) {
			rslt = (a / pow(rt, 2) + rt * 2) / 3;
		}
		rt = rslt;
		
	}
	
	return rslt;
	//return (a/pow((x-1),2)+a*2* (x - 1)) / 3;
}



int main(){

	system("chcp 1251");

	double a = 0;
	double rtDgree = 0;
	std::cout << "Введите число: ";
	std::cin >> a;
	std::cout << "Введите корень числа: ";
	std::cin >> rtDgree;

	double& refA = a;
	double& refX = rtDgree;

	std::cout << "Результат функции pow(a, 1.0 / 3): " << cR(a) << std::endl;
	std::cout << "Результат итерационной формулы: " << cR(a, rtDgree) << std::endl;

	return 0;
}
