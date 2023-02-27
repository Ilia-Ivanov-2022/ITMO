// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 11, Exercise 1
// Class Time Reloading operators

#include <iostream>
#include <windows.h>

using namespace std;

class InvalidTimeEx
{
public:
	InvalidTimeEx(const char* ch) : message(ch) {}
	void printMessage() const { cout << message; }

private:
	const char* message;
};
class InvalidTimeMSEx
{
public:
	InvalidTimeMSEx(const char* ch) : message(ch) {}
	void printMessage() const { cout << message; }

private:
	const char* message;
};

class Time
{
public:
	Time() : hours(0), minutes(0), seconds(0) {};
	Time(int h, int m, int s) : hours(h), minutes(m), seconds(s) {
		if (h > 23)
			throw InvalidTimeEx("Ошибка ввода времени. Введите не более 23:59:59");
		if (m > 59 || s > 59)
			throw InvalidTimeMSEx("Ошибка ввода времени. Минуты и/ или секунды не могут превышать 59");
		timeAdjust(h, m, s);
	}
	Time(double num) {
		hours = static_cast<int>(num);
		minutes = static_cast<int>((num - hours) * 60);
		seconds = static_cast<int>(((num - hours) * 60 - minutes) * 60);
	}
	void setTime();
	Time& appendTime(const Time& t);
	Time addTime(const Time& t);
	void printTime() const;
	void timeAdjust(int h, int m, int s);
	long convertToSec()const;

	Time operator+(const Time& t) const;
	Time operator-(const Time& t) const;
	bool operator>(const Time& t) const;
	Time operator+(double d) const;


private:
	int hours;
	int minutes;
	int seconds;
};

void Time::setTime() {
	try
	{
		int h = 0, m = 0, s = 0;
		do {
			cout << "\nВведите часы, минуты, секунды через пробел: ";
			cin >> h >> m >> s;
			if (h > 23)
				cout<<"Ошибка ввода времени. Введите не более 23:59:59\n";
			if (m > 59 || s > 59)
				cout<<"Ошибка ввода времени. Минуты и/ или секунды не могут превышать 59\n";
		} while (h > 23 || m > 59 || s > 59);
		timeAdjust(h, m, s);
		hours = h;
		minutes = m;
		seconds = s;
	}
	catch (const InvalidTimeEx& error)
	{
		cout << "ERROR: ";
		error.printMessage();
	}
	catch (const InvalidTimeMSEx& error) {
		cout << "ERROR: ";
		error.printMessage();
	}
}

Time& Time::appendTime(const Time& t) {
	hours += t.hours;
	minutes += t.minutes;
	seconds += t.seconds;
	return*this;
}

Time Time::addTime(const Time& t) {
	Time temp;
	temp.hours = hours + t.hours;
	temp.minutes = minutes + t.minutes;
	temp.seconds = seconds + t.seconds;
	return temp;
}

void Time::printTime() const {
	cout<< hours << ":" << minutes << ":" << seconds << endl;
}

void Time::timeAdjust(int h, int m, int s) {
	do
	{
		if (s > 59) {
			m += s / 60;
			s = s % 60;
		}
		if (m > 59) {
			h += m / 60;
			m = m % 60;
		}
	} while (m > 59 || s > 59);
}

long Time::convertToSec() const
{
	return seconds + (minutes + hours * 60) * 60;
}

Time Time::operator+(const Time& t) const
{
	Time sum;
	sum.hours = hours + t.hours;
	sum.minutes = minutes + t.minutes;
	sum.seconds = seconds + t.seconds;
	sum.timeAdjust(sum.hours, sum.minutes, sum.seconds);
	return sum;
}

Time Time::operator-(const Time& t) const
{
	long res = convertToSec() - t.convertToSec();
	Time result;
	result.hours = res / 3600;
	result.minutes = res % 3600 / 60;
	result.seconds = res % 3600 % 60;
	return result;
}

bool Time::operator>(const Time& t) const
{
	return hours > t.hours ? true : false;
}

Time Time::operator+(double d) const
{
	Time time(d);
	return operator+(time);
}


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	Time startWork;
	startWork.setTime();

	
	const Time workHours(8, 0, 0);

	Time endWork; // = startWork.addTime(workHours);
	endWork = startWork + workHours;

	cout << "\nWork start: ";
	startWork.printTime();
	cout << "\nWorking day: ";
	workHours.printTime();
	cout << "\nWork ends: ";
	endWork.printTime();

	Time timeSome;
	timeSome.setTime();

	Time minus = endWork - timeSome;
	
	timeSome.printTime();
	cout << "Результат вычитания: ";
	minus.printTime();
	cout << endl;

	cout << "Больше? " << (endWork > timeSome);
	cout << endl;

	Time timeDouble(10.5486);
	cout << "Результат ctor Time с double: ";
	timeDouble.printTime();
	cout << endl;

	cout << "Результат сложения Time с double: ";
	Time timeSum = timeDouble + 10.5486;
	timeSum.printTime();
	cout << endl;

	return 0;
}