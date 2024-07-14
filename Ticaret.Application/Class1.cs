namespace Ticaret.Application
{
    public class Class1
    {
        public class Class1
        {
            // Sınıf özellikleri
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime CreatedDate { get; set; }

            // Sınıfın bir constructor'ı
            public Class1(int id, string name, DateTime createdDate)
            {
                Id = id;
                Name = name;
                CreatedDate = createdDate;
            }

            // Sınıfın bir metodu
            public void DisplayInfo()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Created Date: {CreatedDate.ToShortDateString()}");
            }

            // Sınıfın başka bir metodu
            public string GetFormattedInfo()
            {
                return $"Class1 - Id: {Id}, Name: {Name}, Created Date: {CreatedDate.ToShortDateString()}";
            }
        }
    }
}
