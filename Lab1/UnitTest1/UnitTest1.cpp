#include "pch.h"
#include "CppUnitTest.h"
#include "../Lab1/Lab1.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(TretyakovaAV_UT1)
	{
	public:
		TEST_CLASS_INITIALIZE(ClassInitialize)
		{
			Logger::WriteMessage("Test class");
		}
		TEST_METHOD(Test1) //должен быть правильным до изменения флага
		{
			MyClass mc1;
			Assert::IsTrue(mc1.BoolFunc());
			mc1.elem = 5;
			Assert::IsFalse(mc1.BoolFunc());
		}

		TEST_METHOD(Test2)
		{
			MyClass mc1(5);
			MyClass mc2(2);
			Assert::AreEqual(25.0, mc1.DoubleFunc());
			Assert::AreNotEqual(25.0, mc2.DoubleFunc());
		}

		TEST_METHOD(Test3)
		{
			MyClass mc1(2);
			Assert::IsTrue(mc1.BoolFunc(5));
			mc1.elem = 5;
			Assert::IsFalse(mc1.BoolFunc(5));
		}
		TEST_METHOD(Test4)
		{
			MyClass mc(0);
			const char* err = "";
			try
			{
				mc.DoubleFunc();
			}	
			catch (std::invalid_argument& ex)
			{
				err = ex.what();
				Logger::WriteMessage(err);
			}
			Assert::IsNotNull(err);
		}
		TEST_METHOD(Test5)
		{
			MyClass2 mc2("Hello");
			string str = mc2.Some_strs("Hello");
			Assert::AreSame(mc2.my_str, *mc2.ad);

			str = mc2.Some_strs("new");
			Assert::AreSame(mc2.my_str, *mc2.ad);
		}

		TEST_CLASS_CLEANUP(ClassFinalize)
		{
			Logger::WriteMessage("Cleaned");
		}
	};
}
