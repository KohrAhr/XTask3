using Prototype.Types;
using System;

namespace Prototype
{
    // Прототип (Prototype) обычно используется для клонирования объектов, но его применение может быть более широким.
    // Основное назначение шаблона "Прототип" - создание копий объектов, включая их состояние и структуру.

    // В данном пример представлены две различные реализации.
    // Оба подхода имеют свои преимущества и могут быть использованы в зависимости от контекста:
    // Первый подход (класс Student) более прямолинеен и удобен, когда у вас есть небольшое количество конкретных классов, которые вы хотите клонировать.
    // Второй подход (классы Prototype и ConcretePrototype) более абстрактен и подходит, когда у вас есть несколько классов, которые должны поддерживать общий интерфейс для клонирования.
    // Это может быть полезно в более крупных проектах, где требуется более гибкое управление прототипами.

    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample 1

            Student originalStudent = new Student { Name = "Andrew", Age = 35 };
            Student clonedStudent = (Student)originalStudent.Clone();

            clonedStudent.Age++;

            originalStudent.DisplayInfo();
            clonedStudent.DisplayInfo();

            // Sample 2

            Manager originalManager = new Manager { Name = "John", Age = 44 };
            Manager clonedManager = originalManager.Clone();

            clonedManager.Age++;

            originalManager.DisplayInfo();
            clonedManager.DisplayInfo();

            //

            Console.ReadKey();
        }
    }
}
