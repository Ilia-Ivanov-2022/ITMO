// ITMO.CppCourse2023LabOneExerciseTwo.cpp : This file contains the 'main' function.Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main(){

	system("chcp 1251");

	cout.precision(3);

	string name;

	cout << "������� ���� ���\n";
	double a, b;
	cout << "������� a � b:\n";
	cin >> a; // ���� � ���������� �������� a
	cin >> name;
	cin >> b; // ���� � ���������� �������� b
	double x = a / b; // ���������� �������� x
	cout << "\nx = " << x << endl; //����� ���������� �� �����
	cout << "������," << name << "!\n";
	cout << (a / b) << ends << sizeof(x) << endl;
	return 0;
}