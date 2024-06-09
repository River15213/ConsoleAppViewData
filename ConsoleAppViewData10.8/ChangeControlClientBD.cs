using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8
{
    internal class ChangeControlClientBD
    {
        public DateTime DateChange { get; set; }
        public string DataChange { get; set; }
        public string DataType { get; set; }
        public string WhoChange { get; set; }

        public ChangeControlClientBD(string dataChange, string dataType, string whoChange)
        {
            DateChange = DateTime.Now;
            DataChange = dataChange;
            DataType = dataType;
            WhoChange = whoChange;
        }

        public override string ToString()
        {
            return $"Время изменение: {DateChange} Изменненое поле: {DataChange} Тип изменений: {DataType} Изменил: {WhoChange}";
        }
    }
}
