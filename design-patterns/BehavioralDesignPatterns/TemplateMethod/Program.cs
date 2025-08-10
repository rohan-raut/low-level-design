namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVParser cSVParser = new CSVParser();
            JSONParser jsonParser = new JSONParser();

            cSVParser.Parse();
            jsonParser.Parse();
        }
    }
}

/*
 * Consider a scenario where you have different data parsers (eg. CSV, XML and JSON). Each parser follows the same steps:
 * 1. Open File
 * 2. Parse Data
 * 3. Close File
 * 
 * Without the Template Method Pattern, you might end up duplicating the common steps in each parser class.
 * 
 * Problem: Different parts of an algorithm may need to vary in subclasses, but the overall structure should remain consistent.
 * Solution: The template method pattern defines the skeleton of an algorithm in a blase class and lets subclasses override specific steps.
 * 
 */
