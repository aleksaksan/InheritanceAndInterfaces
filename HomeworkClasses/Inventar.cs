using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    public class Inventar
    {
        LinkedList<Item> _items;
        
        public Creature _owner; // не понял зачем здесь это поле 
        
        static int _size = 0;
        int _capacity;
        public Inventar(Creature holder, int capacity)
        {
            _items = new();     //инициализация LinkedList<Item>
            _owner = holder;
            _capacity = capacity;
        }
        
        public void AddItem(Item item) //добавить шмотку в инвентарь
        {
            if (_size < _capacity)
            {
                _items.AddLast(item);
                _size++;
            }
            else
                throw new ArgumentException("инвентарь переполнен"); // нужен метод для отображения пользователю "инвентарь переполнен"
        } 
        public Item GetOutItem() // достать "выбранный" предмет из инвентаря (при этом он уберается из инвентаря)
        {
            if (IsEmpty)
                throw new ArgumentNullException("нет предметов в инвентаре");
            Item temp = _items.First.Value;
            _items.RemoveFirst();
            _size--;
            return temp;
        }
        public Item ScrollForwardItem()  // я бы добавил два следующих метода в событие нажатия кнопок
        {
            if (IsEmpty)
                throw new ArgumentNullException("нет предметов в инвентаре");
            _items.AddLast(_items.First);
            _items.RemoveFirst();
            return _items.First.Value;
        }
        public Item ScrollBackwardItem() // возврат предмета нужен для отображения пользователю
        {
            if (IsEmpty)
                throw new ArgumentNullException("нет предметов в инвентаре");
            _items.AddFirst(_items.Last);
            _items.RemoveLast();
            return _items.First.Value;
        }
        public void RemoveItem() // удалить предмет (можно добавить пару методов для продажи или выброса предмета)
        {
            if (!IsEmpty)
            {
                _items.RemoveFirst();
                _size--;
            }
            else
                return;
        }
        public bool IsEmpty
        {
            get => _size <= 0 ? true : false;
        }

        //////////////////////////
        public void ShowContents()
        {
            Console.WriteLine("__________________________________________________________\nинвентарь:\n");
            Console.WriteLine($"вместимость инвентаря:\t\t{_capacity}\n" +
                $"предметов в инвентаре:\t\t{_size}\n");
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("__________________________________________________________");
        }
    }
}
