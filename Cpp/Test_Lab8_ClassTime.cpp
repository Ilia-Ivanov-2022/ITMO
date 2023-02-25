// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 8, Exercise 1
// Class Time

#include <iostream>
#include <windows.h>

using namespace std;

class Time
{
public:
	Time() {
		hours = 0;
		minutes = 0;
		seconds = 0;
	};
	Time(int h, int m, int s) {
		this->hours = h;
		this->minutes = m;
		this->seconds = s;
		do
		{
			if (this->minutes > 59) {
				this->hours += m / 60;
				this->minutes = m % 60;
			}
			if (this->seconds > 59) {
				this->minutes += s / 60;
				this->seconds = s % 60;
			}
		} while (this->minutes > 59 || this->seconds > 59);
		
	}
	Time setTime(int h, int m, int s);
	Time addTime(Time t1);
	void printTime() const;

private:
	int hours;
	int minutes;
	int seconds;

};

Time Time::setTime(int h, int m, int s) {
	hours = h;
	minutes = m;
	seconds = s;
	do {
		if (minutes > 59) {
			hours += minutes / 60;
			minutes = minutes % 60;
		}
		if (seconds > 59) {
			minutes += seconds / 60;
			seconds = seconds % 60;
		}
	} while (minutes > 59 || seconds > 59);
	return { hours, minutes, seconds };
}

Time Time::addTime(Time t1) {
	hours += t1.hours;
	minutes += t1.minutes;
	seconds += t1.seconds;
	return*this; //{ hours, minutes, seconds };
}

void Time::printTime() const {
	printf("\nThe time is: %d:%d:%d", hours, minutes, seconds);
}


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int h, m, s;

	Time time;
	Time startWork{ 06,45,67 };
	const Time workHours{ 8,00,00 };
	//const Time& workHours = workHours;

	startWork.printTime();

	Time endWork = startWork.addTime(workHours);

	cout << "\nEnter time as 'hh mm ss': ";
	cin >> h >> m >> s;

	time.setTime(h, m, s);

	time.printTime();
	endWork.printTime();

	return 0;
}