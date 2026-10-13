using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create new lists that will be used to store books and members
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        // Create and add new Book objects to the list
        books.Add(new Book("C# for beginners", "Bill Gates", 1234567));
        books.Add(new Book("Ultimate C#", "Microsoft", 2233445));

        members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
        members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

        // Display all items within the Book list
        foreach (Book book in books)
        {
            Console.WriteLine($"Book Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            book.DisplayInfo();
        }

        // Display all members within the members list
        foreach (Member member in members)
        {
            member.DisplayInfo();
        }
    }
}