namespace Oppgaver.TestProject
{
    public class Numbers
    {
        private readonly Random _random;
        private readonly int _min;
        private readonly int _max;

        public Numbers(Random random, int max= 1000, int min = 1)
        {
            _random = random;
            _min = min;
            _max = max;
        }
        public void CreateFunction()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = _random.Next(_min, _max);
            }
            PtintResult(numbers);
        }

        private void PtintResult(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}