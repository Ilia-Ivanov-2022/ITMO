// ITMO.CppCourse2023LabOneExerciseThree.cpp : This file contains the 'main' function.Program execution begins and ends there.
//

#include <iostream>
#include <windows.h>
#include <cmath>

int main(){

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	double tP;
	std::cout << "Введите значение периметра треугольника: \n";
	std::cin >> tP;
	double Square = tP / 2;
	double SQR = sqrt(tP / 2 * (tP / 2 - tP / 3) * 3);
	std::cout << "\tСторона\tПлощадь" << std::endl;
	std:: cout << "\t" << tP << "\t" << Square << std::endl;
	std::cout << "\t" << tP << "\t" << SQR << std::endl;
  return 0;

}