using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EngineHeart.Controller
{
    public class IOController
    {
        /// <summary>
        /// Returns strings from CSV file. 
        /// </summary>
        public IEnumerable<string[]> ReadFromCSV(string LocationPath)
        {
            foreach (string S in Read(LocationPath))
            {
                yield return S.Split(';');
            }
            yield break;
        }

        /// <summary>
        /// Reads all from specified file.
        /// </summary>
        private IEnumerable<string> Read(string LocationPath)
        {
            using(StreamReader str = new StreamReader(LocationPath))
            {
                while (!str.EndOfStream)
                {
                    yield return str.ReadLine();
                }
                yield break;
            }
        }
    }
}
