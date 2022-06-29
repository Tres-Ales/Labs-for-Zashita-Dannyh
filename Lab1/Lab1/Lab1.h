#pragma once

#define for_errors 1

using namespace std;

class MyClass {
public:
	double elem;
	MyClass() { elem = 0; }
	MyClass(double d) { elem = d; }
	bool BoolFunc();
	bool BoolFunc(double d);
	double DoubleFunc();
};

class MyClass2 {
public:
	string my_str;
	string* ad;

	MyClass2();
	MyClass2(string in);
	string Some_strs(string str);
	~MyClass2() { my_str = ""; ad = NULL; }
};