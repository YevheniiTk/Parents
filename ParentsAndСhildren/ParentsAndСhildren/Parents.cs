using System;

namespace ParentsAndСhildren
{
    public class Parents
    {
        public string Name { get; private set; }

        public Parents(string name)
        {
            Name = name;
        }

        public void PickUpChild(object sender, EventArgs e)
        {
            Child child = sender as Child;

            Console.WriteLine($"{ Name } raised {child.Name}. " +
                        $"Child {child.Age} years old.");
        }
    }
}
