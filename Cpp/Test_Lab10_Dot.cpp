// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 10, Exercise 1
// Triangle

/* Test_Lab1_Dot.cpp */

#include <math.h>
#include "Test_Lab10_Dot.h"

Dot::Dot()
{
	x = 0; y = 0;
}
Dot::Dot(double x, double y)
{
	this->x = x;
	this->y = y;
}
double Dot::distanceTo(Dot point)
{
	return sqrt(pow(point.x - x, 2) + pow(point.y - y, 2));
}