// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 10, Exercise 1
// Triangle

/* Test_Lab1_Dot.h */

using namespace std;

#pragma once

class Dot
{
public:
	Dot();
	Dot(double x, double y);
	double distanceTo(Dot point);

private:
	double x;
	double y;
};
