using System;

namespace LazyInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем лениво инициализируемый объект типа string
            Lazy<string> lazyString = new Lazy<string>(() => "This is a lazily initialized string.");

            // Проверяем, инициализирован ли объект
            if (!lazyString.IsValueCreated)
            {
                Console.WriteLine("Initializing the lazy string...");
                _ = lazyString.Value;
            }

            // Теперь объект инициализирован и можно его использовать
            // Инициализация происходит здесь при первом доступе
            Console.WriteLine(lazyString.Value);

            Console.ReadKey();
        }
    }
}
