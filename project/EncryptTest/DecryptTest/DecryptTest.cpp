// DecryptTest.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
//#include <windows.h>
#include <string>
#include <iostream>
#include <conio.h>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	string s = "MTIz";
	char byteArray[32];

	strcpy_s(byteArray, s.c_str());

	cout << byteArray;

	_getch();

	return 0;
}

