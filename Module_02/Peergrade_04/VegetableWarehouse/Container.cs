using System.Collections.Generic;

namespace VegetableWarehouse
{
    class Container
    {
        // Сумарная стоимость содержимого контейнера.
        public double Price { get; set; }
        // Сумарная масса содержимого контейнера.
        public double SumWeight { get; set; }
        // Допустимая масса содержимого контейнера.
        public int MaxWeight { get; set; }
        // Уровень повреждения контейнера.
        public double Damage { get; set; }
        // Айди.
        public int Id { get; set; }
        // Список ящиков.
        public List<Box> GetListBoxes { get { return listBoxes; } }
        private List<Box> listBoxes = new List<Box>();
        // Добавление ящика в список.
        public void AddBox(Box a) { listBoxes.Add(a); }
        // Переопределение метода ту стринг.
        public override string ToString()
        {
            string str = null;
            foreach (var i in listBoxes)
            {
                str += $"{i}\n\n";
            }
            return $"Id: {Id}\n{str}";
        }
    }
}
