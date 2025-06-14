#include "XMLData.h"
#include<string>

XMLData::XMLData(string p_xmlData) {
	xmlData = p_xmlData;
}

string XMLData::getXMLData() {
	return xmlData;
}



