// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 10, Exercise 1
// Triangle

/* Test_Lab10_Triangle.cpp */

#include <iostream>
#include <cmath>
#include "Test_Lab10_Triangle.h"


double Triangle::getTriangleArea() const
{
	const double p = (dt1->distanceTo(*dt2) + dt2->distanceTo(*dt3) + dt3->distanceTo(*dt1)) / 2;

	return pow(p * (p - dt1->distanceTo(*dt2)) * (p - dt2->distanceTo(*dt3)) * (p - dt3->distanceTo(*dt1)), 0.5);
}

void Triangle::printTriangle()
{
	std::cout << "Triangle area: " << getTriangleArea() << std::endl;
}

