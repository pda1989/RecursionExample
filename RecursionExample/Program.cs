using System;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Item - это тип твоих объектов, может быть все что угодно
            // Создавать элементы можешь как хочешь, ItemFactory
            // прячет логику создания объектов, ее даже можешь не смотреть 
            Item head = ItemFactory.CreateHead();

            // Запуск рекурсивной функции, передаешь ссылку на голову
            RecursiceFunction(head);

            // Вывод дерева, сделано для удобства, можешь не смотреть это
            head.Show();

            Console.ReadLine();
        }

        public static int RecursiceFunction(Item parent)
        {
            // Создаем рандомное число потомков (группы либо элементы)
            // В твоем случае это может быть запрос в базу и создание объектов - 
            // все спрятано в фабрике
            parent.Childrens = ItemFactory.CreateItems();

            // Если есть потомки, то запускаем для них функцию при этом сумируя 
            // количесво листов, вазвращаемых функцией при обратном проходе
            int leavesCount = 0;
            parent.Childrens.ForEach(item =>
                leavesCount += RecursiceFunction(item)
            );

            // Присваиваем количество листов, возвращенных от всех потомков
            parent.LeavesCount = leavesCount;

            // Если leavesCount=0 это значит что мы в листе, потомков нет.
            // В этом случае возвращаем 1, говоря о том что мы - лист.
            // В противном случае возвращаем количество потомков у данной
            // группы (при leavesCount!=0 элемент является группой, т.к.
            // имеет потомков)
            return leavesCount == 0 ? 1 : leavesCount;
        }
    }
}
