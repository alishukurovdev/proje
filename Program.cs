
namespace ConsoleApp4
{
    internal class Program
    {
        static string[] name = new string[100];
        static int numberNames = 0; 

        static void Main(string[] args)
        {
            int choose;
            do {
                Console.WriteLine("1. Siyahiya bax");
                Console.WriteLine("2. Siyahiya add elave et");
                Console.WriteLine("3. Siyahida adi yoxla");
                Console.WriteLine("4. Daxil edilmis indexdeki adi goster");
                Console.WriteLine("0. Menudan cix");
                Console.Write("Seciminizi daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    switch (choose)
                    {
                        case 1:
                            SeeTheList();
                            break;
                        case 2:
                            AddName();
                            break;
                        case 3:
                            CheckName();
                            break;
                        case 4:
                            IndexNameSee();
                            break;
                        case 0:
                            Console.WriteLine("the end program");
                            break;
                        default:
                            Console.WriteLine("mistke choose.Please select again");
                            break;
                    }
                }
                Console.WriteLine();
            } while (choose != 0);
        }
        static void SeeTheList()
        {
            if(numberNames == 0)
            {
                Console.WriteLine("name not shown");
            }else
            {
                Console.WriteLine("names on the list");
                for(int i = 0; i < numberNames; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
        static void AddName() {
            Console.WriteLine("New name add");
            string newName=Console.ReadLine();
            if(newName.Length >2  )
            {      //&&!newName[0]
                Console.WriteLine(" add name success");
            }
            else
            {
                Console.WriteLine("add name not success");
            }
        }
        static void CheckName()
        {
            Console.WriteLine(" to chech name");
            string toCheckName=Console.ReadLine();
            if (name[numberNames] == toCheckName)
            {
                Console.WriteLine("there is a name in the list");
            }
            else
            {
                Console.WriteLine("No name on the list");
            }
        }
        static void IndexNameSee()
        {
            Console.WriteLine("Enter the name index to be displayed");
        }
    }
}
