namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welecom to the Stack And Queue Problem");

            Console.WriteLine("#####################");

            StackWithLinkedList obj = new StackWithLinkedList();
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();
            obj.Display();
            //obj.Peek();
            Console.WriteLine("After pop operation:");
            //obj.Pop();
             
            obj.Display();
        }
    }
}
