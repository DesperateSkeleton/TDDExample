#pragma once
#include <vector>
#include <string>
using namespace std;

class LinearEquation
{
private:
	vector<double> listofcoef;
public:
	LinearEquation(vector<double>);
	vector<string> getSplit(const string&, string);
	LinearEquation(string s);
	LinearEquation(int n);
	int size() 
	{ 
		return listofcoef.size(); 
	}
	~LinearEquation() {};
	bool isEmpty();
	void Initial(double);
	void randomInitial();
	double& operator[](int ind);
	LinearEquation operator+(LinearEquation&);
	LinearEquation operator-(LinearEquation&);
	LinearEquation operator*(const double&);
	LinearEquation operator-();
	operator std::string();
	operator bool();
};

