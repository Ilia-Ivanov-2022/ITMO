#include <iostream>
#include <cmath>
#include "Header.h"

// Test a number for prime number
bool isPrime(int num){
	if (num >= 0 && num <= 10)
		switch (num) {
		case 2:
		case 3:
		case 5:
		case 7:
			return true;
			break;
		default:
			return false;
			break;
		}
	else if (num > 10 && (num % 2 && num % 3 && num % 5 && num % 7))
		return true;
	else
		return false;
}

// Test a prime for super prime
void isSuperPrime(int n) {
	int counter = 0;
	for (int i = 0; i <= n; i++) {
		if (isPrime(i))
			counter++;
	}
	if (isPrime(counter))
		std::cout << "Number " << numToCheck << " is a super prime number" << std::endl;
	else
		std::cout << "Number " << numToCheck << " is NOT super a prime number" << std::endl;
	
}


int main() {
	std::cout << "Check if your number is a super prime number" << std::endl;
	std::cout << "Pick a number: " << std::endl;
	std::cin >> numToCheck;

	isSuperPrime(numToCheck);

	return 0;
}

