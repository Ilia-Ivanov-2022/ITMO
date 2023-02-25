// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 9, Exercise 2
// Class Time Exception

#include <iostream>
#include <windows.h>

using namespace std;

class InvalidTimeEx
{
public:
	InvalidTimeEx() : message("ќшибка ввода времени. ¬ведите не более 23:59:59") {}
	void printMessage() const { cout << message; }

private:
	const char* message;
};

class Time
{
public:
	Time() : time() {};
	Time(int arr[3]) {
		timeAdjust(arr);
		if (arr[0] > 23)
			throw InvalidTimeEx();
		memcpy(time, arr, sizeof(arr));
	}
	void setTime(int arr[]);
	Time& appendTime(const Time& t);
	Time addTime(const Time& t);
	void printTime() const;
	void timeAdjust(int arr[]);

private:
	int time[3]{};
};

void Time::setTime(int arr[3]) {
	timeAdjust(arr);
	if (arr[0] > 23)
		throw InvalidTimeEx();
	memcpy(time, arr, sizeof(arr));
}

Time& Time::appendTime(const Time& t) {
	for (int i = 0; i < 3; i++)
		time[i] += t.time[i];
	return*this;
}

Time Time::addTime(const Time& t) {
	Time temp;
	for (int i = 0; i < 3; i++)
		temp.time[i] += t.time[i];
	return temp;
}

void Time::printTime() const {
	printf("\nThe time is: %d:%d:%d", time[0], time[1], time[2]);
}

void Time::timeAdjust(int arr[]) {
	do
	{
		if (arr[2] > 59) {
			arr[1] += arr[2] / 60;
			arr[2] = arr[2] % 60;
		}
		if (arr[1] > 59) {
			arr[0] += arr[1] / 60;
			arr[1] = arr[1] % 60;
		}
	} while (arr[1] > 59 || arr[2] > 59);
}


int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int time[3]{};
	

	Time startWork;

	int timeNew[3]{ 0, 0, 159551 };
	
	try
	{
		startWork.setTime(timeNew);
	}
	catch (const InvalidTimeEx& error)
	{
		cout << "ERROR: ";
		error.printMessage();
		return 1;
	}
	

	int workDayHours[3]{ 8,0,0 };
	const Time workHours(workDayHours);

	startWork.printTime();

	//Time endWork = startWork.appendTime(workHours);
	Time endWork = startWork.addTime(workHours);

	cout << "\nEnter time as 'hh mm ss': ";
	cin >> time[0] >> time[1] >> time[2];

	Time timeSome;

	timeSome.setTime(time);

	timeSome.printTime();
	startWork.printTime();
	endWork.printTime();

	return 0;
}