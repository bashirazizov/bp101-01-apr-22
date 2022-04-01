using System;
using System.Net.Mail;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Start:
            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(n1 / n2);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Ikinci daxil etdiyiniz eded sifir ola bilmez!");
            //    goto Start;
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Daxil edilen sitring deyildi. Sennen kusdum.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Mail Daxil et:");
            //string input = Console.ReadLine();
            //try
            //{
            //    MailAddress ma = new MailAddress(input);
            //    Console.WriteLine("Mail Validdir");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Enter person's name:");
            //string nameToBe = Console.ReadLine();

            //Console.WriteLine("Enter person's surname:");
            //string surnameToBe = Console.ReadLine();

            //Console.WriteLine("Enter person's email:");
            //string emailToBe = Console.ReadLine();

            //Console.WriteLine("Enter person's age:");
            //int ageToBe = int.Parse(Console.ReadLine());

            //try
            //{
            //    Person p = new Person(nameToBe, surnameToBe, emailToBe, ageToBe);
            //    Console.WriteLine("Xos geldin,"+p.Name);
            //}
            //catch (UserNameInvalidException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //string name = "Mamed";
            ////name[2] = 'a';
            //Console.WriteLine(name[2]);


            //int[] nums = new int[100];

            //Book b1 = new Book("Homosapiens", "Harrari");
            //Book b2 = new Book("Bulanti", "Sartre");
            //Book b3 = new Book("Yad", "Camus");

            //Library libraff = new Library(10);


            //libraff[0] = b1;
            //libraff[1] = b2;
            //libraff[2] = b3;


            //Console.WriteLine(libraff[0]);

            //Car c1 = new Car("Mustang","Ford");
            //Car c2 = new Car("Supra","Toyota");
            //Car c3 = new Car("Skyline", "Nissan");

            //Garage g1 = new Garage(10);


            //g1[0] = c1;

            //Console.WriteLine(g1[0]);

            //Coordinate c1 = new Coordinate();

            //Console.WriteLine(c1.x);

            //User user = new User();

            //user.Status = UserStatus.Active;
            //user.Status = UserStatus.NotnotVerified;

            //if (user.Status == UserStatus.Active)
            //{
            //    Console.WriteLine("Xos gelmisen");
            //}


            //Console.WriteLine("1-Istifadecilere bax, 2-Istifadeci elave et, 3-Istifadeci sil, 4-Istifadeciye duzelis et");

            //int selection = int.Parse(Console.ReadLine());

            //switch (selection)
            //{
            //    case (int)MenuOptions.view:
            //        Console.WriteLine("Istifadecilere bax funsiyasi");
            //        break;
            //    case (int)MenuOptions.add:
            //        Console.WriteLine("Istifadecilere elave et funsiyasi");
            //        break;
            //    case (int)MenuOptions.remove:
            //        Console.WriteLine("Istifadecilere sil funsiyasi");
            //        break;
            //    case (int)MenuOptions.edit:
            //        Console.WriteLine("Istifadecilere duzelis funsiyasi");
            //        break;
            //    default:
            //        break;
            //}



            Currency azn = new Currency();
            azn.Amount = 100;
            azn.ToEurRate = 0.53;
            azn.ToUsdRate = 0.59;


            Currency usd = new Currency();
            usd.Amount = 100;
            usd.ToEurRate = 0.9;
            usd.ToAznRate = 1.70;

            usd.PrintConversion();


            Currency eur = new Currency();
            eur.Amount = 100;
            eur.ToUsdRate = 1.1;
            eur.ToAznRate = 1.88;
        }

        enum MenuOptions:byte{
            view,add,remove,edit
        }

        //struct Coordinate : IComparable
        //{
        //    public int x;
        //    public int y;

        //    public Coordinate(int a, int b)
        //    {
        //        x = a;
        //        y = b;
        //    }

        //    public int CompareTo(object obj)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //struct Square
        //{
        //    public int side;

        //    public int getArea()
        //    {
        //        return side * side;
        //    }
        //}
    }
}
