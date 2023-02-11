#pragma once
#include <iostream>
#include <windows.h>
#include <string>


std::string;

std::string& snilsInput(std::string& str);

// Checks if SNILS string contains only digits, space and dash;
bool snilsCooker(std::string str);

// Removes all characters != digits;
std::string snilsCleaner(std::string str);

bool snilsValidator(std::string str);


