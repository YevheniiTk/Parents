using System;

namespace ParentsAndСhildren
{
    public class Child
    {
        private static Random random = new Random();
        public string Name { get; private set; }
        public int Age { get; private set; }

        public event EventHandler HasFallen;

        public Child(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Run()
        {
            int oneOrTwo = random.Next() % 2 == 0 ? 1 : 2;

            if (oneOrTwo == 1)
            {
                Fell();
            }
        }

        private void Fell()
        {
            HasFallen?.Invoke(this, EventArgs.Empty);
        }
    }
}
