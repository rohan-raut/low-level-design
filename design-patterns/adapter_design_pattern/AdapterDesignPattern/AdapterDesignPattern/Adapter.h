#pragma once
#include "DataAnalyzer.h"
#include "XMLData.h"


class Adapter : public DataAnalyzer
{
	XMLData* xmlData;
public:
	Adapter(XMLData* p_xmlData);

	void analyzeData() override;
};

