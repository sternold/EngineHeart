using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Controller
{
    public class IOController
    {

        public IEnumerable<string[]> ReadFromCSV(string LocationPath)
        {
            IEnumerable<string> CSVoutput = Read(LocationPath);
            foreach (string S in CSVoutput)
            {
                yield return S.Split(';');
            }
            yield break;
        }

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
