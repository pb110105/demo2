using System;

namespace InterchangeSort
{
    struct Student
    {
        public string name;
        public double score;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
        }
    }

    class bai2
    {
        static void arrangeStudent10(Student[] student)
        {
            int i, j;
            for (i = 0; i < student.Length - 1; i++)
            {
                for (j = i + 1; j < student.Length; j++)
                    if (student[j].score < student[i].score)
                    {
                        Student temp = student[j];
                        student[j] = student[i];
                        student[i] = temp;
                    }
            }
        }

        static void Main10(string[] args)
        {
            Console.WriteLine("Nhap vao so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            Student[] student = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap ten sinh vien thu {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Nhap diem trung binh cua {name}: ");
                double score = double.Parse(Console.ReadLine());

                student[i] = new Student(name, score);
            }

            arrangeStudent10(student);

            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo diem: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ten: {student[i].name}, Diem trung binh: {student[i].score}");
            }
        }
    }
}