using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    public class Item
    {
        string _nameOfItem;
        public string NameOfItem { get => _nameOfItem; }
        public enum Type { sword, shield, gun, amulet, ring, };
        int _cost;
        int _weight;
        Type _type;
        public Item(string name, Type type, int price, int weight)
        {
            _nameOfItem = name;
            _type = type;
            _cost = price;
            _weight = weight;
        }
        public override string ToString()
        {
            return $"наименование:\t{NameOfItem}\nтип:\t\t{_type}\nцена:\t\t{_cost}\nвес:\t\t{_weight}\n";
        }
    }
}
