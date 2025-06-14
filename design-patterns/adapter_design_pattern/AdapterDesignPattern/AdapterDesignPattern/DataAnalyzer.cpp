#include "DataAnalyzer.h"
#include <iostream>


DataAnalyzer::DataAnalyzer() {

}

DataAnalyzer::DataAnalyzer(string p_jsonData) {
	jsonData = p_jsonData;
}

void DataAnalyzer::analyzeData() {
	cout << "Analyzing JSON data: " << jsonData << endl;
}
