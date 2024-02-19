using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace KodlamaIO
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("**************************************************************");
                Console.WriteLine("1.Course Listele");
                Console.WriteLine("2.Category Listele");
                Console.WriteLine("3.Instructor Listele");
                Console.WriteLine("4.Çıkış");
                Console.WriteLine("Seçim yapın...");
                Console.WriteLine("**************************************************************");
                string selection =Console.ReadLine();

                switch (selection) 
                {
                    case "1":
                        ListCourses();
                        break;
                    case "2":
                        ListCategories();
                        break;
                    case "3":
                        ListInstructors();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    default:
                        Console.WriteLine("Geçersiz Seçim");
                        break;
                }
            }
        }
        static void ListCourses()
        {
            CourseService courseManager = new CourseService(new CourseDal());
            var courses = courseManager.GetAll();
            if (courses != null && courses.Count > 0)
            {
                Console.WriteLine("Courses:");
                foreach (var course in courses)
                {
                    Console.WriteLine($"Course Id: {course.Id}, Name: {course.Name}, Description: {course.Description}, Category ID: {course.CategoryId}, Instructor ID: {course.InstructorId}");
                }
            }
            else
            {
                Console.WriteLine("Hiç kurs bulunamadı.");
            }
        }

        static void ListCategories()
        {
            CategoryService categoryManager = new CategoryService(new CategoryDal());
            var categories = categoryManager.GetAll();
            if (categories != null && categories.Count > 0)
            {
                Console.WriteLine("Categories:");
                foreach (var category in categories)
                {
                    Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}");
                }
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }
        }
        static void ListInstructors()
        {
            InstructorService instructorService = new InstructorService(new InstructorDal());
            var instructors = instructorService.GetAll();
            if(instructors != null && instructors.Count > 0)
            {
                Console.WriteLine("Instructors:");
                foreach(var instructor in instructors)
                {
                    Console.WriteLine($"Instructor Id: {instructor.Id}, Name: {instructor.FirstName} {instructor.LastName}");
                }
            }
            else 
            { 
                Console.WriteLine("Eğitmen Bulunamadı.");
            }
        }

    }
}