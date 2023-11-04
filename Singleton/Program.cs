﻿namespace Singleton
{
    internal class Program
    {
        // можно реализовать "Одиночку" (Singleton) и без метода GetInstance().
        // Однако использование GetInstance() является стандартным и рекомендуемым подходом для реализации Singleton, так как он обеспечивает контролируемый и ленивый способ создания и доступа к единственному экземпляру класса.
        // Метод GetInstance() позволяет вам управлять моментом создания Singleton, исключая возможные гонки данных и обеспечивая ленивую инициализацию, то есть создание экземпляра только при первом обращении.

        // Но да, вы можете реализовать "Одиночку" без GetInstance(), просто сделав поле instance публичным статическим полем.
        // Однако это не рекомендуется, так как это может уменьшить контроль над процессом создания и доступа к Singleton и повысить вероятность несанкционированного изменения его состояния.
        // Такой способ реализации может привести к нежелательным побочным эффектам и сложностям в управлении экземпляром Singleton.
        // Именно поэтому рекомендуется использовать метод GetInstance() для создания и доступа к Singleton.

        static void Main(string[] args)
        {
            IResult result = new ConsoleWrite();

            ControlClass singleton = ControlClass.GetInstance(result);

            singleton.FunctionXXX();

            //

            result.ReadKey();
        }
    }
}