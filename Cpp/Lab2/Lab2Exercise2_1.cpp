// ITMO.CppCourse2023.Lab2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main(){

    system("chcp 1251");

    int a, b, temp;

    std::cout << "a = " << std::endl; 
    std::cin >> a;
    std::cout << "b = " << std::endl; 
    std::cin >> b;

    while (a!=b){
        if (a > b)
        a -= b; // аналогично выражению a = a - b
        else
        b -= a;
    }
    std::cout << "НОД = " << a << std::endl;

}
