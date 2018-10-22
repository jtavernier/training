using System;
using System.Collections;

namespace _01_CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
         
  
            MyCircularQueue obj = new MyCircularQueue(6);
            bool param_1 = obj.EnQueue(6);
            var param_2 = obj.Rear();
            var param_3 = obj.Rear();
            var param_4 = obj.DeQueue();
            var param_5 = obj.EnQueue(5);
            var param_6 = obj.Rear();
            var param_12 = obj.DeQueue();
            var par7 = obj.Front();
            var par8 = obj.DeQueue();
            var par9 = obj.DeQueue();
            var par10 = obj.DeQueue();


            var q = new Queue();
            q.Enqueue(2);
            q.Dequeue();
            q.
        }
    }
}
