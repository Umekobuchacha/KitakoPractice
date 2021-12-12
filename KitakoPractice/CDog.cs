using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitakoPractice
{
    class CDog
    {
        public CDog(string type) { this.Type = type; }
        public CDog() { this.Type = "Nothing"; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; private set; }
        public void ShowProfile()
        {
            Console.WriteLine("犬種: {2}, 名前: {0}, 年齢: {1}", Name, Age, Type);
        }
    }
}
