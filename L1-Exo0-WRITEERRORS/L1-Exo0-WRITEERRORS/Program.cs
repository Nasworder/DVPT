namespace L1_Exo0_WRITEERRORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Catch all exceptions
            try
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", createText);

                // Open the file to read from.
                string readText = File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
                Console.WriteLine(readText);
            }
            catch (Exception e)
            {
                // Write excepetions to a file with the user name, the date, the time , the line number and the exception message
                string path = "../../../Exceptions.txt";
                string appendText = Environment.UserName + " " + DateTime.Now + " " + e.Message + " " + e.StackTrace + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
        }
    }
}