namespace Oppgaver.TestProject
{
    internal class ArrayCount
    {
        public int BiggestNumber(int[] array)
        {
            var max = array.Max();
            return max;
        }

        // private int[] SortArray(int[] array)
        // {
        //     var numbers = array;
        //     Array.Sort(numbers);
        //     return numbers;
        // }

        public int SmallesrNumber(int[] array)
        {
            var min = array.Min();
            return min;
        }

        public IEnumerable<int> ReverseNumber(int[] array)
        {
            return array.Reverse();
        }

        public int Sum(int[] array)
        {
            var allNumber = array.Sum();
            return allNumber;
        }
    }
}