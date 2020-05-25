#pragma once
#include "LinearEquation.h"
#include <string>

class SystemOLE
{
private:
	vector<LinearEquation> listofcoef;
	int n;
public:
	SystemOLE(int n1) :n(n1) {}
	~SystemOLE() {}
	LinearEquation& operator[](int ind);
	void stepConvert();
	void AddLE(LinearEquation&);
	int size();
	vector<double> gaussMethod();
	operator string();
};

