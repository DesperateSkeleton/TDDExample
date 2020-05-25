#include "pch.h"
#include <cassert>
#include "CppUnitTest.h"
#include "../Week4-6Robert/LinearEquation.h"
#include "../Week4-6Robert/LinearEquation.cpp"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;
using namespace std;
namespace UnitTest1
{
	TEST_CLASS(LinTest)
	{
	public:
		TEST_METHOD(FailWithWrongIndexing1)
		{
			auto test1 = []() {
				LinearEquation a("1,3,5.5,7,9.8");
				double value = a[-1];
			};
			Assert::ExpectException<invalid_argument>(test1);
		}
		TEST_METHOD(FailWithWrongIndexing2)
		{
			auto test2 = []() {
				LinearEquation a("1,3,5.5,7,9.8");
				double value = a[7];
			};
			Assert::ExpectException<invalid_argument>(test2);
		}

		TEST_METHOD(IndexingChecking)
		{
			LinearEquation a("1,3,5.5,7,9.8");
			Assert::AreEqual(7.0, a[3]);
		}
		TEST_METHOD(InitializationCheching)
		{
			LinearEquation a(4);
			a.Initial(4.5);
			Assert::AreEqual(4.5, a[3]);
		}
		TEST_METHOD(OperatorChecking1)
		{
			string listofcoef1 = "1,2,3,4,-6,8.5";
			LinearEquation a(listofcoef1);
			string listofcoef2 = "5,6,7,8,3.3,-6.7";
			LinearEquation b(listofcoef2);
			LinearEquation res("6,8,10,12,-3.3,1.8");
			Assert::AreEqual(res == (a + b), true);
		}
		TEST_METHOD(OperatorChecking2)
		{
			string listofcoef1 = "1,2,3,5.6,12,9,0.8";
			LinearEquation a(listofcoef1);
			string listofcoef2 = "2,-4,6.9,8.9,11,13.8,15.5";
			LinearEquation b(listofcoef2);
			string result = "-1,6,-3.9,-3.3,1,-4.8,-14.7";
			LinearEquation res(result);
			Assert::AreEqual(res == (a - b), true);
		}
		TEST_METHOD(WrongEquationCheching)
		{
			string listofcoef1 = "0,0,0,0,0,0,0.8";
			LinearEquation a(listofcoef1);
			bool pp;
			if (a) pp = true;
			else pp = false;
			Assert::AreEqual(false, pp);
		}
		TEST_METHOD(CorrectlyEquationCheching)
		{
			string listofcoef1 = "1,2,3,5.6,12,9,0.8";
			LinearEquation a(listofcoef1);
			bool pp;
			if (a) pp = true;
			else pp = false;
			Assert::AreEqual(true, pp);
		}
	};
}