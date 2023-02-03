// ITMO.CppCourse2023.LabOneExerciseOne.cpp : This file contains the 'main' function.Program execution begins and ends there.
//

#include <iostream>
#include <windows.h>
#include <string>

int main(){
    
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    std::string name;
    std::cout << "What is your name? ";
    //cin >> name;
    getline(std::cin, name);
    std::cout << "Hello, " << name << "!\n";
	  return 0;
}