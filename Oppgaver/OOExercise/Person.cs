namespace Oppgaver.OOExercise
{
    public class Person
    {
        public int LegalDrinkingAge { get; } = 18;
        public int DiscountAge { get; } = 78;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string CheckAge()
        {
            if (CanBuyBeer())
            {
                string discountMessage = HasDiscount() ? " You have 5% discount!" : "";
                return $"Your age is {Age}. You are old enough!{discountMessage} Enjoy your beer, {Name}!";
            }

            return $"{Name}, you are too young!";
        }


        public bool CanBuyBeer()
        {
            if (Age > LegalDrinkingAge)
            {
                return true;
            }

            return false;
        }

        public bool HasDiscount()
        {
            if (Age >= DiscountAge)
            {
                return true;
            }

            return false;
        }
    }
}