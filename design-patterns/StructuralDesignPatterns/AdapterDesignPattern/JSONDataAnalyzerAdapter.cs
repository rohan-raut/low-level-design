using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class JSONDataAnalyzerAdapter : IDataAnalyzer
    {
        private JSONDataAnalyzer jsonDataAnalyzer;

        public JSONDataAnalyzerAdapter(JSONDataAnalyzer jsonDataAnalyzer)
        {
            this.jsonDataAnalyzer = jsonDataAnalyzer;
        }

        public void AnalyzeData(string xmlData)
        {
            // add logic to convert xmlData to JSON format.
            string jsonData = "This is converted JSON Data";

            jsonDataAnalyzer.AnalyzeJSONData(jsonData);
        }
    }
}
