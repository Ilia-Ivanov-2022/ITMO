// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 7, Exercise 1
// Struct Time

#include <iostream>
#include <windows.h>

using namespace std;


struct Time
{
	int hours;
	int minutes;
	int seconds;
};

Time inputTime(Time t);
Time addTime(Time t1, Time t2);
Time subsrtTime(Time t1, Time t2);
void printTime(Time time);
void printTimeInSeconds(Time time);


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	
	Time myTime{};
	Time anotherTime{1,56,107};
	
	// Data input
	myTime = inputTime(myTime);
	
	printTime(myTime); // hh:mm:ss
	printTimeInSeconds(myTime); // seconds

	printTime(anotherTime);

	printTime(subsrtTime(myTime, anotherTime));

	printTime(addTime(myTime, anotherTime));

	return 0;
}

Time inputTime(Time t) {
	cout << "Введите время - часы, минуты, секудны через пробел" << endl;
	cin >> t.hours >> t.minutes >> t.seconds;

	t.hours = t.hours;

	if (t.minutes >= 0 || t.minutes < 60) t.minutes = t.minutes;
	if (t.minutes > 59) {
		t.hours += t.minutes/60;
		t.minutes = t.minutes%60;
	}

	if (t.seconds >= 0 || t.seconds < 60) t.seconds = t.seconds;
	if (t.seconds > 59) {
		t.minutes += t.seconds/60;
		t.seconds = t.seconds%60;
	}

	return t;
}

Time addTime(Time t1, Time t2) {

	Time t;
	t.hours = t1.hours + t2.hours;

	t.minutes = t1.minutes + t2.minutes;
	if (t.minutes > 59) {
		t.hours++;
		t.minutes -= 60;
	}

	t.seconds = t1.seconds + t2.seconds;
	if (t.seconds > 59) {
		t.minutes++;
		t.seconds -= 60;
	}

	return t;
}

Time subsrtTime(Time t1, Time t2) {

	Time t;

	t.seconds = t1.seconds - t2.seconds;
	if (t.seconds < 0) {
		t.minutes--;
		t.seconds += 60;
	}
	
	t.minutes = t1.minutes - t2.minutes;
	if (t.minutes < 0) {
		t.hours--;
		t.minutes += 60;
	}

	t.hours = t1.hours - t2.hours;
	if (t.hours < 0) {
		t.hours = 0;
		t.seconds = 0;
	}

	return t;
}


void printTime(Time time) {
	printf("\nВремя: %d:%d:%d", time.hours, time.minutes, time.seconds);
}
void printTimeInSeconds(Time time) {
	printf("\nВремя в секундах: %d", (time.hours * 3600 + time.minutes * 60 + time.seconds));
}
