namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLDataAnalyzer xmlDataAnalyzer =  new XMLDataAnalyzer();
            xmlDataAnalyzer.AnalyzeData("<XMLData>");

            
            JSONDataAnalyzer jsonDataAnalyzer = new JSONDataAnalyzer();
            JSONDataAnalyzerAdapter jsonDataAnalyzerAdapter = new JSONDataAnalyzerAdapter(jsonDataAnalyzer);
            jsonDataAnalyzerAdapter.AnalyzeData("<XMLData>");

        }
    }
}

/*
 * Scenario: First the client was using the XMLDataAnalyzer, but later he found the a new library JSONDataAnalyzer which is much cheaper and wants to 
 * migrate to that. But the new library allows data only in JSON format.
 * 
 * So we can create an Adapter class which follows the existing interface of XMLDataAnalyzer and will hold the object of the external library. The Adapter
 * will contain all the logic of conversion of data from XML to JSON and will then call the methods of the JSONDataAnalyzer.
 * 
 * Use this Design pattern when you need some kind of conversion or want to migrate to new service but the interfaces are not matching. Here the Adapter 
 * Design pattern helps so the client doesn't need to do much changes or no changes.
 * 
 */
