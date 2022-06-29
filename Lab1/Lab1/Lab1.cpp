#include <iostream>

#include "Lab1.h"

//using namespace std;


bool MyClass::BoolFunc() {
	if (!for_errors) {
		if (pow(elem, 2) <= 15) {
			return true;
		}
		return false;
	}
	else {
		if (pow(elem, 2) <= 15) {
			return false;
		}
		return true;
	}
}
bool MyClass::BoolFunc(double d) {
	if (!for_errors) {
		if (pow(elem, 2) <= d) {
			return true;
		}
		return false;
	}
	else {
		return true;
	}
}

double MyClass::DoubleFunc() {
		double d = 5;
		
		if (cos(elem/180.0) > 0) {
			return elem * d;
		}
		return NAN;
		
	}


MyClass2::MyClass2() {
	ad = &my_str;
}

MyClass2::MyClass2(string in) {
	my_str = in;
	ad = &my_str;
}

string MyClass2::Some_strs(string str) {
	if (!for_errors) {
		if (str != *ad) {
			my_str = str;
			
			return my_str;
		}
		my_str = str + my_str;
		
		return my_str;
	}
	else {
		ad = NULL;
		return "NotCorrectStrAHAHHAH";
	}
}

int main() {
	MyClass2 mc2("Hello");
	string str = mc2.Some_strs("Hello");
	cout << mc2.my_str << endl;
	cout << *mc2.ad;
	
	return 0;
}