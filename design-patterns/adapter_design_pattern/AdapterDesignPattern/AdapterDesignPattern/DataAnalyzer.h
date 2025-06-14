#pragma once
#include<string>

using namespace std;

class DataAnalyzer
{
	string jsonData;
public:
	DataAnalyzer();

	DataAnalyzer(string p_jsonData);

	virtual void analyzeData();
};

