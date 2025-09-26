using L = PracticeDataStructAndALgo.LINQ;
using S = PracticeDataStructAndALgo.SlidingWindow;
using T = PracticeDataStructAndALgo.StackAndQueue;
using P = PracticeDataStructAndALgo.TwoPointers;

namespace PracticeDataStructAndALgo
{
    class Program
    {
        static void Main(string[] args)
        {

            var pairs = P.Q2.Run();
            foreach (var i in pairs) {
                Console.WriteLine($"{i.Item1},{i.Item2}");
            }
        }
    }
}