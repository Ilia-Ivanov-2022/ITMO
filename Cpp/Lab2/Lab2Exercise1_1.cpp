// ITMO.CppCourse2023.Lab2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main(){

    system("chcp 1251");

    double x, y;
    

    std::string flag = "n";

    do
    {
        std::cout << "Введите координаты точки (x, y): \n";
        std::cin >> x;
        std::cin >> y;
        std::string result;

        if ((x * x + y * y < 9) && (y > 0))
            result = "Внутри";
        else if ((x * x + y * y > 9) && (y > 0))
            result = "Снаружи";
        else
            result = "На границе";

        std::cout << result << std::endl;

        std::cout << "Введите \"д\" для повтора или любой другой символ перкратить: " << std::endl;
        std::cin >> flag;

    } while (flag == "д");


}
