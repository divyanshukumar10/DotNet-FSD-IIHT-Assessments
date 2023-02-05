public class Author
{
    
    private String name;
    private String email;
    private char gender;

    public Author(String name, String email, char gender)
    {
        this.name = name;
        this.email = email;
        this.gender = gender;
    }

   
    public String GetName()
    {
        return name;
    }
   
    public char GetGender()
    {
        return gender;
    }
    
    public String GetEmail()
    {
        return email;
    }
    
    public void SetEmail(String email)
    {
        this.email = email;
    }

    
    public String ToString()
    {
        return name + " (" + gender + ") at " + email;
    }
}

public class Book
{

    private String name;
    private Author author;
    private double price;
    private int qty;


    public Book(String name, Author author, double price, int qty)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = qty;
    }

    
    public String getName()
    {
        return name;
    }
    
    public Author getAuthor()
    {
        return author;  
    }
 
    public double getPrice()
    {
        return price;
    }
   
    public void setPrice(double price)
    {
        this.price = price;
    }
    
    public int getQty()
    {
        return qty;
    }
   
    public void setQty(int qty)
    {
        this.qty = qty;
    }


    public String toString()
    {
        return "'" + name + "' by " + author;
    }
}

public class TestBook
{
    public static void Main(String[] args)
    {
        
        Author ahTeck = new Author("Divyanshu Kumar", "Divyanshu.kr10@gmail.com", 'm');
        Console.WriteLine(ahTeck); 
                                   

        
        Book dummyBook = new Book("Books:Divyanshu", ahTeck, 10, 100);
        Console.WriteLine(dummyBook);  
                                        

        // Test Setters and Getters
        dummyBook.setPrice(100);
        dummyBook.setQty(50);
        Console.WriteLine("name is: " + dummyBook.getName());

        Console.WriteLine("price is: " + dummyBook.getPrice());

        Console.WriteLine("qty is: " + dummyBook.getQty());

        Console.WriteLine("author is: " + dummyBook.getAuthor());  
                                                                   
        Console.WriteLine("author's name is: " + dummyBook.getAuthor().GetName());

        Console.WriteLine("author's email is: " + dummyBook.getAuthor().GetEmail());

        Console.WriteLine("author's gender is: " + dummyBook.getAuthor().GetGender());
        

        
        Book moreDummyBook = new Book("Book:Divyanshu Kumar",
              new Author("Divyanshu Kumar", "divyanshu.kr10@gmail.com", 'm'), 
              20, 8);
        Console.WriteLine(moreDummyBook);  
    }
}