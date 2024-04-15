namespace StudentSpace
{
    public class Student(string surname, string initials, int groupNumber, int age)
    {
        private readonly string surname = surname;
        private readonly string initials = initials;
        private readonly int groupNumber = groupNumber;
        private readonly int age = age;

        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {surname}, Инициалы: {initials}, Номер группы: {groupNumber}, Возраст: {age}");
        }
    }
}


namespace LibrarySpace
{
    public class Reader(string fullName, string birthDate, string faculty, string phoneNumber)
    {
        private readonly string fullName = fullName;
        private readonly string birthDate = birthDate;
        private readonly string faculty = faculty;
        private readonly string phoneNumber = phoneNumber;

        public void TakeBook(int count)
        {
            Console.WriteLine($"{fullName} взял {count} книг.");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.WriteLine($"{fullName} взял книги: {string.Join(", ", bookNames)}");
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{fullName} вернул {count} книг.");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{fullName} вернул книги: {string.Join(", ", bookNames)}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {

        StudentSpace.Student[] students =
        [
            new StudentSpace.Student("Вацок", "Н.Ч.", 567, 56),
            new StudentSpace.Student("Глебан", "П.П.", 678, 89),
            new StudentSpace.Student("Банан", "Б.Б.", 124, 12),
            new StudentSpace.Student("Добби", "Д.Б.", 424, 92)
        ];

        LibrarySpace.Reader[] readers =
        [
            new LibrarySpace.Reader("Вацок Н. Ч.", "01.01.2000", "Годрик Граффиндор", "+7 621 467 49 01"),
            new LibrarySpace.Reader("Глебан П.П.", "02.02.2001", "Гельга Хаффлпуф", "+7 129 047 24 51"),
            new LibrarySpace.Reader("Банан Б. Б.", "03.03.2002", "Роуэна Равенклау", "+7 900 321 65 47"),
            new LibrarySpace.Reader("Добби Д. Б.", "04.04.2003", "Салазар Слидерин", "+7 678 227 74 23")
        ];

        foreach (var student in students)
        {
            student.PrintInfo();
        }

        readers[3].TakeBook(3);
        readers[3].TakeBook("ААААа ЖЕНЩИНА", "Самураи не плачут", "Европейский тарантул.");
        readers[1].ReturnBook(3);
        readers[1].ReturnBook("Как я переродился в виде камыша", "Я поймал слово не воробья", "Гороскоп для слепых.");
        readers[2].TakeBook("Анчоус не проблема","Закат для слабых","Там где тыл не защищался.");
    }
}
