// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 9, Exercise 1
// Безопасная реализация класса Triangle

#include <iostream>
#include <windows.h>
#include <cmath>

using namespace std;

class WrongSideLengthsEx
{
public:
	WrongSideLengthsEx(): message ("Неправильное соотношение длин сторон треугольника") {}
	void printMessage() const { cout << message; }

private:
	const char *message;
};


class Triangle
{
public:
	Triangle();
	~Triangle();
	Triangle(int arr[3]);
	void setTriangle(int arr[3]);
	double getTrArea() const;
	void showTrArea() const;

private:
	int trSides[3]{};
};

Triangle::Triangle(){}

Triangle::~Triangle(){}

Triangle::Triangle(int arr[3]) {
	memcpy(trSides, arr, sizeof(arr));
	if (trSides[0] >= trSides[1] + trSides[2] ||
		trSides[1] >= trSides[0] + trSides[2] ||
		trSides[2] >= trSides[1] + trSides[0])
		throw WrongSideLengthsEx();
}

void Triangle::setTriangle(int arr[3]) {
	memcpy(trSides, arr, sizeof(arr));
	if (trSides[0] >= trSides[1] + trSides[2] ||
		trSides[1] >= trSides[0] + trSides[2] ||
		trSides[2] >= trSides[1] + trSides[0])
		throw WrongSideLengthsEx();
}

double Triangle::getTrArea() const
{
	const double p = (trSides[0] + trSides[1] + trSides[2]) / 2;
	return pow((p * (p - trSides[0]) * (p - trSides[1]) * (p - trSides[2])), 0.5);
}


void Triangle::showTrArea() const {
	cout << "Triangle area: " << getTrArea() << endl;
}



int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int trS[3]{};

	Triangle myTriangle;

	cout << "Введите значения длин сторон через пробел"<< endl;
	cin >> trS[0] >> trS[1] >> trS[2];
	cout << endl;

	try
	{
		myTriangle.setTriangle(trS);
	}
	catch (class WrongSideLengthsEx& error)
	{
		cout << "ERROR: ";
		error.printMessage();
		cout << endl;
		return 1;
	}
	myTriangle.showTrArea();
	


	int arr[3]{ 7, 8, 20 };
	Triangle anotherTriangle;

	try
	{
		anotherTriangle = { arr };
	}
	catch (class WrongSideLengthsEx& error)
	{
		cout << "ERROR: ";
		error.printMessage();
		cout << endl;
		return 1;
	}	
	anotherTriangle.showTrArea();

	return 0;
}