// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 6, Exercise 3
// Сохранение данных в json-файл

#include <iostream>
#include <windows.h>
#include <fstream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);


	int min = 0; // для записи минимального значения
	int buf = 0; // для обмена значениями

	std::string file = "Lab6Ex3.txt";

	// json objects
	json j = json::array({ 1, 25, 6, 32, 43, 5, 96, 23, 4, 55 });
	json js = json::array({});

	// write json object 'j' to file
	std::ofstream outJ(file);
	if (!outJ) {
		std::cout << "Файл открыть невозможно\n";
		return 1;
	}
	outJ << j << std::endl;
	outJ.close();

	// read data from file to js
	std::ifstream in(file);
	if (!in) {
		std::cout << "Файл открыть невозможно\n";
		return 1;
	}
	in >> js;	
	in.close();
	std::cout << js << std::endl;
	
	// sort data
	for (int i = 0; i < js.size(); i++) {
		min = i;
		for (int j = i + 1; j < js.size(); j++)
			min = (js[j] < js[min]) ? j : min;
		if (i != min) {
			buf = js[i];
			js[i] = js[min];
			js[min] = buf;
		}
	}

	std::cout << js << std::endl;

	// write json object 'js' to file
	std::ofstream outJs(file, std::ios::app);
	if (!outJs) {
		std::cout << "Файл открыть невозможно\n";
		return 1;
	}
	outJs << js << std::endl;
	outJs.close();
	
	return 0;
}

