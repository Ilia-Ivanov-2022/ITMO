// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 2
// ������� ������� �� �������

#include <iostream>
#include <windows.h>
#include <vector>

int* max_vect(int kc, int a[], int b[]);

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int a[] = { 1,2,3,4,5,6,7,2 };
	int b[] = { 7,6,5,4,3,2,1,3 };
	int kc = sizeof(a) / sizeof(a[0]); //���������� ��������� �������
	int* c{}; //��������� �� �������������� ������
	c = max_vect(kc, a, b); //����� ������� ��� �������� �������
	for (int i = 0; i < kc; i++) //����� ����������.
		std::cout << c[i] << " ";
	std::cout << std::endl;
	delete[]c; //������� ������.

	return 0;
}

int* max_vect(int kc, int a[], int b[]) {
	int* res = new int[kc];
	
	for (int i = 0; i < kc; i++) {
		if (a[i] >= b[i])
			res[i] = a[i];
		else res[i] = b[i];
	}

	return res;
	delete res;
}
