// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 8, Exercise 1
// Class Time ver_02.01

#include <iostream>
#include <windows.h>
#include <tuple>

using namespace std;

class Time
{
public:
	Time():hours(0), minutes(0), seconds(0) {};
	Time(int h, int m, int s) :hours(h), minutes(m), seconds(s) {
		tuple<int, int, int> res = timeTuneup(h, m, s);
		this->hours = get<0>(res);
		this->minutes = get<1>(res);
		this->seconds = get<2>(res);
	}
	void setTime(int h, int m, int s);
	Time& appendTime(const Time& t);
	Time addTime(const Time& t);
	void printTime() const;
	tuple<int, int, int> timeTuneup(int h, int m, int s);

private:
	int hours;
	int minutes;
	int seconds;

};

void Time::setTime(int h, int m, int s) {
	tuple<int, int, int> res = timeTuneup(h, m, s);
	hours = get<0>(res);
	minutes = get<1>(res);
	seconds = get<2>(res);
}

Time& Time::appendTime(const Time& t){
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
	printf("\nThe time is: %d:%d:%d", hours, minutes, seconds);
}

tuple<int, int, int> Time::timeTuneup(int h, int m, int s) {
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
	} while (m>59 || s>59);
	return make_tuple(h, m, s);
}


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int h, m, s;

	Time time;
	Time startWork{ 0,0,6712 };
	const Time workHours{ 8,00,00 };

	startWork.printTime();

	//Time endWork = startWork.appendTime(workHours);
	Time endWork = startWork.addTime(workHours);

	cout << "\nEnter time as 'hh mm ss': ";
	cin >> h >> m >> s;

	time.setTime(h, m, s);

	time.printTime();
	startWork.printTime();
	endWork.printTime();

	return 0;
}