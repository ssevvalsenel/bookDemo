using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book() {Id=1, Title="Kitap1", Price=75},
                new Book() {Id=2, Title="Kitap2", Price=100},
                new Book() {Id=3, Title="Kitap3", Price=125}
            };
        }
    }
}
