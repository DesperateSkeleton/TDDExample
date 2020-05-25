#pragma once
class Indexer
{
private:
	double* array1;
	int beg;
	int len;
	bool IndexCheck(int ind);
public:
	int getLength() 
	{
		return len;
	}
	Indexer(double* array, int beg, int end, int len);
	~Indexer() { delete array1; }
	double& operator[](int ind);
};

