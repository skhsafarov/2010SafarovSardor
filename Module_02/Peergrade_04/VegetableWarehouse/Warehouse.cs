using System;
using System.Collections.Generic;
using System.Text;

namespace VegetableWarehouse
{
    class Warehouse
    {
        // Допустимое колличество контейнеров.
        public int MaxCount { get; set; }
        // Цена за хранение.
        public int Price { get; set; }
        // Список контейнеров.
        private List<Container> listContainers = new List<Container>();
        public List<Container> GetListContainers { get { return listContainers; } }
        // Добавление контейнера в список.
        public void AddCont(Container a)
        {
            listContainers.Add(a);
        }
        // Удаление контейнера из списка.
        public void DelCont(int id)
        {
            listContainers.RemoveAt(id);
        }
        // Переопределение метода ту стринг.
        public override string ToString()
        {
            string str = null;
            foreach (var i in listContainers)
            {
                str += $"{i}\n";
            }
            return $"{str}";
        }
    }
}
