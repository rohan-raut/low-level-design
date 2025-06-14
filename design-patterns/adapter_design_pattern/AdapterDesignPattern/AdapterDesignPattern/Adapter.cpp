#include "Adapter.h"
#include <iostream>

Adapter::Adapter(XMLData* p_xmlData) {
	xmlData = p_xmlData;
}

void Adapter::analyzeData() {
	cout << "Converting the XML data to JSON format" << endl;
	cout << "Analyzing the data through adapter" << endl;
}


