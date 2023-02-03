// ITMO.CppCourse2023.Lab2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main(){

    system("chcp 1251");

    char op;
    std::cout << "Сделай свой выбор, собери авто свой мечты: ";
    std::cin >> op;

    switch (op)
    {
    case 'R':
        std::cout << "Радио играть должно\n";
    case 'E':
        std::cout << "Мощный двигатель\n";
    case 'V':
        std::cout << "Кондиционер хочу\n";
    default:
        std::cout << "Колеса круглые\n";
    }

}
