using System.Net.Mime;

namespace RandomBoxes
{
    class Text : Shape
    {
        private readonly string _text;
       

        public Text(int x, int y, string text, Random random) : base(random)
        {
            _text = text;
           
            X = x;
            Y = y;
            
        }

        public override string GetCharacter(int row, int col)
        {
            if (row != Y || col < X || col >= X + _text.Length) return null;
            var index = col - X;
            return _text[index].ToString();
        }
    }
}