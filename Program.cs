internal class Program
{
    static void Main(string[] args)
    {
       int month = DateTime.Now.Month;
       
       //Expression
       switch (month)
       {
            case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
            case 2:
                Console.WriteLine("Şubat Ayındasınız");
                break;
            case 3:
                Console.WriteLine("Mart Ayındasınız");
                break;
        
            default:
            break;
        }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;

                default:
                break;
            }
    }
}