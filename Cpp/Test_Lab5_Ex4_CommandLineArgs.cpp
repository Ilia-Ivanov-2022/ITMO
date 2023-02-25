// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 5, Exercise 4
// �������� ���������� � ���������

#include <iostream>
#include <windows.h>
#include <cstring>
#include <string>

using namespace std;


int main(int argc, char* argv[]) {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int counter;
	printf("�������� ��� �������� � ��������� ����� �����: %s", argv[0]);
	if (argc == 4)
	{
		printf("\n���������� ���������� ����������: %d", argc);
		printf("\n----���������� ���������:----");
		for (counter = 0; counter < argc; counter++)
			printf("\nargv[%d]: %s", counter, argv[counter]);
	}

	if (argc < 4) {
		printf("\n������������� ���������� ����������");
		printf("\n���������� ���������� ����������: %d", argc);
		printf("\n������� 4 ���������:");
		printf("\n1. �������� ���������");
		printf("\n2. '-a' ��� �������� ��� '-m' ��� ���������");
		printf("\n3 & 4. ��� ����� ����� � �������� 3 � 4 ����������");
	}
		
	if (strncmp(argv[1], "-a",2) == 0)
		printf("\n��������� ��������: %d", (atoi(argv[2]) + atoi(argv[3])));
	else if (strncmp(argv[1], "-m", 2) == 0)
		printf("\n��������� ���������: %d", (atoi(argv[2])* atoi(argv[3])));

	return 0;
}
