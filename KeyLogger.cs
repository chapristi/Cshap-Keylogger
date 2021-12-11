using System;
using System.IO;

namespace testc_
{
    
    public class KeyLogger
    {
        private string _file;

        public KeyLogger(string file)
        {
            this._file = file;
        }
        private static ConsoleKey GetKeysEntered()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            return input.Key;
        }

        public void SetFile(string value)
        {
            _file = value;
        }

        public string GetFile()
        {
            return _file;
        }

        public void StaticMethod()
        {
            TextWriter tsw = new StreamWriter(_file);

            while (true)
            {

                ConsoleKey key = GetKeysEntered();
                if (key == ConsoleKey.Enter)
                {
                    tsw.Close();
                    break;
                }
                tsw.WriteLineAsync((char) key);
            }
            
            // ReSharper disable once FunctionNeverReturns
        }
        
          
    }

}
