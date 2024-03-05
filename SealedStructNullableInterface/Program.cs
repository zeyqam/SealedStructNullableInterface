
using SealedStructNullableInterface;

//Book book= new Book();
//book.Name = "addada";
//Console.WriteLine(book.Name);

//int num = 5;
//Class1 class1 = new Class1();
//class1.MyProperty = 100;
//Console.WriteLine(class1.MyProperty);
string name = null;
//int? num = null;


//Console.WriteLine(book.Id);    
//if(book.Id == null)
//{
//    Console.WriteLine("Book id not found");
//}
Book book1 = new()
{
    Id = 1,
    Name = "Isgendername",
    Author=new Author() { Name="Nizami",Id=2}
};
Book book2 = new()
{
    Id = 2,
    Name = "Xosrov"
};

Console.WriteLine("Book:" + book2.Name +"Author: " + book2.Author?.Name.Substring(1,3));


//Book[] books = {book1, book2};


//void GetBookById(Book[] books,int? id=null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("your id is null");
//        return;
//    }

//    Book result=books.FirstOrDefault(x => x.Id == id);
//    Console.WriteLine(result.Name);
//}

//GetBookById(books,2);

//enum value typdir stackda yerleshir

//Level level = Level.Low;
//Console.WriteLine((int)level==1);


void GetLevel(int levelNum)
{
    switch (levelNum)
    {
        case (int)Level.Low:
            Console.WriteLine("Low");
            break;
        case (int)Level.Medium:
            Console.WriteLine("Medium");
            break;
        case (int)Level.High:
            Console.WriteLine("High");
            break;

        default:
            break;
    }
}
GetLevel(2);
