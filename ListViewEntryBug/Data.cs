using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewEntryBug
{
    public class Data
    {
        public string name { get; set; }
        public string someText { get; set; }
    }
    public class DataFilled
    {
        public List<Data> ListData { get; set; }
        public DataFilled()
        {
            ListData = new List<Data>();
        }
        public List<Data> FillData(int Q)
        {
            for (int i = 0; i <= Q; i++)
            {
                ListData.Add(new Data() { name = "Name_" + i, someText = (2 + i).ToString() });
            }
            return ListData;
        }
    }
}
