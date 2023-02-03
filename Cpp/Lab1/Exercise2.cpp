// ITMO.CppCourse2023LabOneExerciseTwo.cpp : This file contains the 'main' function.Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main(){

	system("chcp 1251");

	cout.precision(3);

	string name;

	cout << "Введите свое имя\n";
	double a, b;
	cout << "Введите a и b:\n";
	cin >> a; // ввод с клавиатуры значения a
	cin >> name;
	cin >> b; // ввод с клавиатуры значения b
	double x = a / b; // вычисление значения x
	cout << "\nx = " << x << endl; //вывод результата на экран
	cout << "Привет," << name << "!\n";
	cout << (a / b) << ends << sizeof(x) << endl;
	return 0;
}