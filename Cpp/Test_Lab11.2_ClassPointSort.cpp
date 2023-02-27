// ITMO C++ Course 2023
// Ilia Ivanov Group 124-16
// Lab 11, Exercise 2
// Class Point Sort

#include <iostream>
#include <string>
#include <vector>
#include <algorithm> // для алгоритма сортировки

class Point
{
public:
	Point(): x(0), y(0){}
	Point(int x, int y): x(x), y(y){}
	~Point() {}

	int distToCenter() const;
	bool operator<(const Point& p) const;
	friend std::ostream& operator<<(std::ostream&, const Point&);
	

private:
	int x = 0, y = 0;
};

int Point::distToCenter() const // Center(0, 0)
{
	return sqrt(pow(x, 2) + pow(y, 2));
}

bool Point::operator<(const Point& p) const
{
	return distToCenter() > p.distToCenter() ? true : false;
}

std::ostream& operator<<(std::ostream &out, const Point &p) {
	out << "Point(" << p.x << ", " << p.y << ")";
	return out;
}


int main()
{
	std::vector<Point> v;
	v.push_back(Point(1, 2));
	v.push_back(Point(10, 12));
	v.push_back(Point(21, 7));
	v.push_back(Point(4, 8));
	std::sort(v.begin(), v.end()); // требуется перегрузка оператора < для // класса Point
	for (auto& point : v)
		std::cout << point << '\n'; // требуется перегрузка оператора << для // класса Point
	return 0;
}

