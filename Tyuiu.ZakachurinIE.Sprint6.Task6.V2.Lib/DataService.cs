using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    
                    if (words.Length >= 2)
                    {
                        
                        resStr += words[1] + " ";
                    }
                    
                }
            }

           
            return resStr.Trim();
        }
    }
}
