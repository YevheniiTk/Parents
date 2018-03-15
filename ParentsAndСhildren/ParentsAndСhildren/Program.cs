using System.Threading;

namespace ParentsAndСhildren
{
    class Program
    {
        static void Main(string[] args)
        {
            Parents parents = new Parents("Irina");
            Child child1 = new Child("Anton", 5);
            Child child2 = new Child("Jim", 3);

            child1.HasFallen += parents.PickUpChild;
            child2.HasFallen += parents.PickUpChild;

            while (true)
            {
                child2.Run();
                child1.Run();
                Thread.Sleep(300);
            }

        }
    }
}
