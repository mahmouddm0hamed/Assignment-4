



#region Q1
Book book = new Book();
//Console.WriteLine(book.password);  // cant access password because its Access Modifier is private 
#endregion

#region Q2
Console.WriteLine(book.copiesInStock); // yes compiles because its Access Modifier internal can access in the project 
#endregion
#region Q3
book.Title = "mahmoud ";
Console.WriteLine(book.Title);
#endregion
#region Q4

book.Genre = Genre.Science;

Console.WriteLine(book.Genre);

#endregion
#region Q5

Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
Console.WriteLine((int)Genre.Science);

#endregion
#region Q6
int genreNumber = 1;
Console.WriteLine((Genre)genreNumber);

#endregion
#region Q7
Genre genre = Genre.Fiction;
Console.WriteLine(genre.ToString());
#endregion
#region Q8
string genreText = "Science";
Console.WriteLine(Enum.Parse(typeof(Genre), genreText));
#endregion
#region Q9
genreText = "Mystery";
if (Enum.TryParse(genreText, out Genre result))
{

    Console.WriteLine( result);

}
else Console.WriteLine("Unknown genre");
#endregion

enum Genre { Fiction, NonFiction, Science }
class Book
{


    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;
    public Genre Genre;

}
