using System;

namespace Prototype.Types
{
    // более абстрактная реализация "Прототипа".
    // Здесь есть абстрактный класс Prototype, представляющий общий интерфейс для создания прототипов. Этот класс имеет абстрактный метод Clone().
    // Класс ConcretePrototype наследует от Prototype и реализует метод Clone() с использованием MemberwiseClone(), который копирует все члены текущего объекта.
    // Этот подход полезен, когда у вас есть несколько классов, которые могут быть клонированы, и вы хотите предоставить общий интерфейс для клонирования объектов.
    // Такой интерфейс позволяет клиентскому коду работать с прототипами, не зная их конкретных типов.

    /// <summary>
    ///     Way #2
    /// </summary>
    public class Manager
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Manager Clone()
        {
            return new Manager
            { 
                Name = Name, 
                Age = Age 
            };
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
