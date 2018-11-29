using System;


namespace StringingAlong
{
    class Program
    {
        static void Main()
        {
            string s1 = "This is from the book: ";
            string s2 = "god bless you, mr. rosewater";
            string s3 = ". By Kurt Vonnegut.";

            Console.WriteLine(s1 + s2.ToUpper() + s3);
            System.Text.StringBuilder para = new System.Text.StringBuilder();
            para.Append("Hello babies.");
            para.Append(" Welcome to Earth.");
            para.Append(" It's hot in the summer and cold in the winter.");
            para.Append(" It's round and wet and crowded.");
            para.Append(" On the outside, babies, you've got a hundred years here.");
            para.Append(" There's only one rule that I know of, babies -\"God damn it, you've got to be kind.\"");
            Console.WriteLine(para);
            Console.ReadLine();
        }
    }
}
