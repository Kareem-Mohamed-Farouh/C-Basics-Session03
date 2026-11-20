// Start Q1
using System.Text;

//string title = "clean code";

//string upperTitle = title.ToUpper();

//Console.WriteLine(title);
//Console.WriteLine(upperTitle);
////End Q2

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//// Start Q2
//string title1 = "Clean Code";
//string title2 = "Clean Code";

//Console.WriteLine(
//    object.ReferenceEquals(title1, title2)
//);
////End Q2
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// Start Q3


//StringBuilder bookList = new StringBuilder();

//bookList.Append("Book List");
//bookList.Append(" - Updated");

//Console.WriteLine(bookList);
////End Q3
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine(); 
//// Start Q4
//bookList.Replace("Book List", "Library");

//Console.WriteLine(bookList);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

////End Q4


string title = "Clean Code";
int pages = 464;


// Start Q5

//string sentence = "Book: " + title + ", Pages: " + pages;

//Console.WriteLine(sentence); //Book: Clean Code, Pages: 464
//End Q5




// Start Q5

//string sentence = $"Book: {title}, Pages: {pages}";

//Console.WriteLine(sentence);
//End Q5


// Start Q6

//string sentence = $"Book: {title}, Pages: {pages}";

//Console.WriteLine(sentence);   //Book: Clean Code, Pages: 464
//End Q6


// Start Q7
string sentence = string.Format(
    "Book: {0}, Pages: {1}",
    title,
    pages
);

Console.WriteLine(sentence);

//End Q7


/////////  ///// Start Q8

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}
//End Q8
 /////////////////////////// Start Q9 

bool isAvailable = true;

if (pages > 300 && isAvailable == true)
{
    Console.WriteLine("You can borrow this book");
}



/////////  ///// Start Q9


string titlee = "Refactoring";

switch (titlee)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!"); //here we fint the resulte
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}