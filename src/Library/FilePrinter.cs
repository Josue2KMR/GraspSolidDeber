using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextPrint textPrint)
        {
            File.WriteAllText("Recipe.txt", textPrint.GetTextToPrint());
        }
    }
}