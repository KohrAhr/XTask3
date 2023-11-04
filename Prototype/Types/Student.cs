using System;
using Prototype.Types.Base;

namespace Prototype.Types
{
    // пример простой реализации "Прототипа".
    // Класс Student является конкретным классом, который имеет метод Clone(), который создает новый объект Student и копирует значения свойств из текущего объекта.
    // Этот подход удобен, когда у вас есть конкретные классы, которые вы хотите клонировать, и вы хотите, чтобы каждый класс определял свой собственный метод Clone().

    /// <summary>
    ///     Way #1
    /// </summary>
    public class Student : PrototypeBase
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        ///     for Debug purpose
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
