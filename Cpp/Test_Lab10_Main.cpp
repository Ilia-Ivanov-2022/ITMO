// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 10, Exercise 1
// Triangle

/* Test_Lab1_Main.cpp */

#include <iostream>
#include <windows.h>
#include "Test_Lab10_Triangle.h"

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	

	Dot dot1(5, 1);
	Dot dot2(7, 10);
	Dot dot3(15, 2);
	

	Triangle tr1(dot1, dot2, dot3); // Композиция
	tr1.printTriangle();

	Triangle tr2(&dot1, &dot2, &dot3); // Агрегация
	tr2.printTriangle();

	return 0;
}