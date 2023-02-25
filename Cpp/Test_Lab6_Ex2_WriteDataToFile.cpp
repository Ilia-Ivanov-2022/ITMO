// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 6, Exercise 2
// ���������� ������ � ��������� ����

#include <iostream>
#include <windows.h>
#include <vector>
#include <fstream>



int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	const int N = 10;
	int a[N] = { 1, 25, 6, 32, 43, 5, 96, 23, 4, 55 };
	int min = 0; // ��� ������ ������������ ��������
	int buf = 0; // ��� ������ ����������

	std::string file = "Lab6Ex2.txt";

	// open file for writing
	std::ofstream out(file);
	if (!out) {
		std::cout << "���� ������� ����������\n";
		return 1;
	}
	out << "�� ���������� \n";
	for (int el : a) {
		out<<el<<"\t";
	}
	out << std::endl;
	out.close();


	for (int i = 0; i < N; i++)
	{
		min = i; // ����� ������� ������, ��� ������ � ����������� ���������
		// � ����� ������ �������� ����� ������ � ����������� ���������
		for (int j = i + 1; j < N; j++)
			min = (a[j] < a[min]) ? j : min;
		// ������������ ����� ��������, ������� ��� ������� � �������
		if (i != min)
		{
			buf = a[i];
			a[i] = a[min];
			a[min] = buf;
		}
	}

	out.open(file, std::ios::app); // Open for writing
	out << "����� ���������� \n";
	for (int el : a)
		out << el << '\t';
	out.close();


	return 0;
}

