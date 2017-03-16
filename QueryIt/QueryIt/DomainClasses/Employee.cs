using System;

namespace QueryIt.DomainClasses
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }
    }
}