#include "Indexer.h"
#include <iostream>
#include <stdexcept>
using namespace std;

Indexer::Indexer(double* array1, int beg, int len, int n) 
{
    if (beg + len > n || beg < 0 || len <= 0) throw invalid_argument("ArgumentException");
    else
    {
        this->array1 = array1;
        this->beg = beg;
        this->len = len;
    }
}
double& Indexer::operator[](int ind) 
{
    if (!IndexCheck(ind)) throw invalid_argument("IndexOutOfRangeException");
    else return array1[ind + beg];
}
bool Indexer::IndexCheck(int ind)
{
    if (ind < 0 || ind + beg > len) return false;
    return true;
}

int main()
{
    double* array1 = new double[5]{ 1,2,3,4,5 };
    Indexer indexer1(array1, 1, 2, 5);
    Indexer indexer2(array1, 0, 2, 5);
    indexer1[0] = 100500;
    for (int i = 0; i < 5; i++) cout << indexer2[i] << " ";
}
