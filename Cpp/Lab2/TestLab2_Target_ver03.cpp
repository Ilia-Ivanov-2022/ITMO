// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 2, Exercise 4
// Target.ver03



#include <iostream>
#include <Windows.h>

int main() {

	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int numberOfShoots;
	int shootNumber = 0;
	int hitScore = 0;
	int hitTotalScore = 0;
	int step = 2; // target size step
	double x = 0, y = 0;
	double hit; // radius
	double avgScore;

	int targetOffsetX;
	int targetOffsetY;
	
	/*std::cout << "Введите кол-во выстрелов: ";
	std::cin >> numberOfShoots;
	std::cout << std::endl;*/
	
	
	
	// Randomly shifted target
	// Shooting until hitTotalScore == N;
	while (hitTotalScore <= 20) {

		srand((unsigned)time(NULL)); // time stamp as a seed value;
		targetOffsetX = (rand() % 5);
		targetOffsetY = (rand() % 5);

		std::cout << "Введите кординаты выстрела x, y: \n";
		std::cin >> x >> y;
		x += targetOffsetX;
		y += targetOffsetY;
		hit = sqrt(pow(x, 2) + pow(y, 2));

		if (hit <= step) {
			hitScore = 10;
			hitTotalScore += hitScore;
			shootNumber++;
			std::cout << "Результат выстрела " << shootNumber << ": " << hitScore << std::endl;
		}
		else if (hit > step && hit <= step * 2) {
			hitScore = 5;
			hitTotalScore += hitScore;
			shootNumber++;
			std::cout << "Результат выстрела " << shootNumber << ": " << hitScore << std::endl;
		}
		else if (hit > step * 2 && hit <= step * 3) {
			hitScore = 1;
			hitTotalScore += hitScore;
			shootNumber++;
			std::cout << "Результат выстрела " << shootNumber << ": " << hitScore << std::endl;
		}
		else {
			hitScore = 0;
			hitTotalScore += hitScore;
			shootNumber++;
			std::cout << "Результат выстрела " << shootNumber << ": Молоко" << std::endl;
		}
		
	}

	

	avgScore = hitTotalScore / shootNumber;

	if(avgScore >= 9)
		std::cout << "Вы снайпер. Выстрелов: " << shootNumber << " Средний бал: " << avgScore << std::endl;
	else if(avgScore < 9 && avgScore  >= 4)
		std::cout << "Вы стрелок. Выстрелов: " << shootNumber << " Средний бал: " << avgScore << std::endl;
	else if (avgScore < 4 && avgScore > 0)
		std::cout << "Вы новичок. Выстрелов: " << shootNumber << " Средний бал: " << avgScore << std::endl;
	

	return 0;
}