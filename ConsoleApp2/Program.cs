using Labb2LINQ.Data;
using Labb2LINQ.Models;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Labb2LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDb2Context context = new SchoolDb2Context();

            Student s1 = new Student()
            {
                StudentId = 1,
                Fname = "Jon",
                Lname = "Athan"
            };
            Student s2 = new Student()
            {
                StudentId = 2,
                Fname = "Nah",
                Lname = "Tanoj"
            };            
            Student s3 = new Student()
            {
                StudentId = 3,
                Fname = "See",
                Lname = "Sharp"
            };            
            Student s4 = new Student()
            {
                StudentId = 4,
                Fname = "Ja",
                Lname = "Va"
            };            
            Student s5 = new Student()
            {
                StudentId = 5,
                Fname = "Py",
                Lname = "Thon"
            };

            Course c1 = new Course()
            {
                CourseId = 1,
                Name = "SUT20",
                StartDate = new DateTime(2022, 09, 25),
                EndDate = new DateTime(2024, 06, 12)
            };
            Course c2 = new Course()
            {
                CourseId = 2,
                Name = "SUT21",
                StartDate = new DateTime(2002, 09, 25),
                EndDate = new DateTime(2022, 06, 12)
            };
            Course c3 = new Course()
            {
                CourseId = 3,
                Name = "SUT22",
                StartDate = new DateTime(2022, 10, 25),
                EndDate = new DateTime(2024, 04, 12)
            };
            Course c4 = new Course()
            {
                CourseId = 4,
                Name = "SUT23",
                StartDate = new DateTime(2021, 09, 25),
                EndDate = new DateTime(2022, 06, 12)
            };

            Teacher t1 = new Teacher()
            {
                TeacherId = 1,
                Fname = "Anas",
                Lname = "Qlok"
            };
            Teacher t2 = new Teacher()
            {
                TeacherId = 2,
                Fname = "Reidar",
                Lname = "Qlok"
            };
            Teacher t3 = new Teacher()
            {
                TeacherId = 3,
                Fname = "Tobas",
                Lname = "Qlok"
            };
            Teacher t4 = new Teacher()
            {
                TeacherId = 4,
                Fname = "Albin",
                Lname = "Nibla"
            };

            //context.Teachers.Add(t4);

            Subject su1 = new Subject()
            {
                SubjectId = 1,
                Name = "Programmering",
                Description = "Lär dig programmera"
            };
            Subject su2 = new Subject()
            {
                SubjectId = 2,
                Name = "Matematik",
                Description = "Lär dig programmera"
            };
            Subject su3 = new Subject()
            {
                SubjectId = 3,
                Name = "Kemi",
                Description = "Lär dig programmera"
            };
            Subject su4 = new Subject()
            {
                SubjectId = 4,
                Name = "Köra Bil",
                Description = "Lär dig programmera"
            };

            //context.Courses.Add(c1);
            //context.Courses.Add(c2);
            //context.Courses.Add(c3);
            //context.Courses.Add(c4);

            //context.Subjects.Add(su1);
            //context.Subjects.Add(su2);
            //context.Subjects.Add(su3);
            //context.Subjects.Add(su4);

            TeacherCourse tc1 = new TeacherCourse()
            {
                Id = 1,
                TeacherId = 1,
                CourseId = 1
            };
            TeacherCourse tc2 = new TeacherCourse()
            {
                Id = 2,
                TeacherId = 1,
                CourseId = 2
            };
            TeacherCourse tc3 = new TeacherCourse()
            {
                Id = 3,
                TeacherId = 2,
                CourseId = 3
            };
            TeacherCourse tc4 = new TeacherCourse()
            {
                Id = 4,
                TeacherId = 3,
                CourseId = 3
            };
            TeacherCourse tc5 = new TeacherCourse()
            {
                Id = 5,
                TeacherId = 2,
                CourseId = 1
            };
            TeacherCourse tc6 = new TeacherCourse()
            {
                Id = 6,
                TeacherId = 4,
                CourseId = 3
            };

            //context.TeacherCourses.Add(tc6);

            TeacherSubject ts1 = new TeacherSubject()
            {
                Id = 1,
                TeacherId = 1,
                SubjectId = 2
            };
            TeacherSubject ts2 = new TeacherSubject()
            {
                Id = 2,
                TeacherId = 2,
                SubjectId = 2
            };
            TeacherSubject ts3 = new TeacherSubject()
            {
                Id = 3,
                TeacherId = 1,
                SubjectId = 1
            };
            TeacherSubject ts4 = new TeacherSubject()
            {
                Id = 4,
                TeacherId = 2,
                SubjectId = 3
            };
            TeacherSubject ts5 = new TeacherSubject()
            {
                Id = 5,
                TeacherId = 4,
                SubjectId = 4
            };

            //context.TeacherSubjects.Add(ts5);

            //context.SaveChanges();

            StudentCourse sc1 = new StudentCourse()
            {
                Id = 1,
                StudentId = 1,
                CourseId = 3
            };
            StudentCourse sc2 = new StudentCourse()
            {
                Id = 2,
                StudentId = 2,
                CourseId = 3
            };
            StudentCourse sc3 = new StudentCourse()
            {
                Id = 3,
                StudentId = 3,
                CourseId = 3
            };
            StudentCourse sc4 = new StudentCourse()
            {
                Id = 4,
                StudentId = 4,
                CourseId = 2
            };
            StudentCourse sc5 = new StudentCourse()
            {
                Id = 5,
                StudentId = 5,
                CourseId = 1
            };

            //context.StudentCourses.Add(sc1);
            //context.StudentCourses.Add(sc2);
            //context.StudentCourses.Add(sc3);
            //context.StudentCourses.Add(sc4);
            //context.StudentCourses.Add(sc5);

            //context.SaveChanges();

            //foreach (Student s in context.Students)
            //{
            //    Console.WriteLine(s.Fname);
            //}

            PrintMathematicians(context);

            PrintTeachersAndStudents(context);

            EditSubject(context, 1, "Programmering 2");

            PrintSubjects(context);

            Console.WriteLine("Does subjects contain Programmering? Answer :" + ContainsProgramming(context));

            //DeleteTeacherCourse(context, 5);

            EditTeacherCourse(context, 3, 2);

        }

        static void PrintMathematicians(SchoolDb2Context context)
        {
            var mathematicians = context.Teachers.Join(
                context.TeacherSubjects, 
                teacher => teacher.TeacherId,
                teacherSub => teacherSub.TeacherId,
                (teacher, teacherSub) => new
                {
                    TeacherID = teacher.TeacherId,
                    TeacherName = teacher.Fname,
                    TeacherSub = teacherSub.Subject.Name
                }).Where(x => x.TeacherSub == "Matematik");

            foreach (var v in mathematicians)
            {
                Console.WriteLine(v.TeacherID + " - " + v.TeacherName + " " + v.TeacherSub);
            }
        }

        static void PrintTeachersAndStudents(SchoolDb2Context context)
        {
            var teachersByCourse = context.Teachers.Join(
                context.TeacherCourses,
                teacher => teacher.TeacherId,
                TeacherCourse => TeacherCourse.TeacherId,
                (teacher, teacherCou) => new
                {
                    teacherId = teacher.TeacherId,
                    teacherName = teacher.Fname + " " + teacher.Lname,
                    courseId = teacherCou.CourseId
                });

            var studentsByCourse = context.Students.Join(
                context.StudentCourses,
                student => student.StudentId,
                studentCourse => studentCourse.StudentId,
                (student, studentCourse) => new
                {
                    studentId = student.StudentId,
                    studentName = student.Fname + " " + student.Lname,
                    courseId = studentCourse.CourseId
                });

            var teacherStudents = teachersByCourse.Join(
                studentsByCourse,
                teacher => teacher.courseId,
                student => student.courseId,
                (teacher, student) => new
                {
                    teacherName = teacher.teacherName,
                    studentName = student.studentName,
                    courseId = teacher.courseId
                }).Join(
                context.Courses,
                teachstud => teachstud.courseId,
                course => course.CourseId,
                (teachstud, course) => new
                {
                    teacherName = teachstud.teacherName,
                    studentName = teachstud.studentName,
                    courseId = teachstud.courseId,
                    courseName = course.Name
                });

            foreach (var v in teacherStudents.OrderBy(x => x.courseName))
            {
                Console.WriteLine($"Student = {v.studentName} : Teacher = {v.teacherName} in course {v.courseName}");
            }
        }

        static bool ContainsProgramming(SchoolDb2Context context)
        {
            Subject programmering = context.Subjects.Where(x => x.Name == "Programmering").FirstOrDefault();
            if (context.Subjects.Contains(programmering)){
                return true;
            }
            else
            {
                return false;
            }
        }

        static void EditSubject(SchoolDb2Context context, int id, string newName)
        {
            Subject oldSubject = context.Subjects.Where(x => x.SubjectId == id).FirstOrDefault();

            oldSubject.Name = newName;
            context.SaveChanges();
        }

        static void PrintSubjects(SchoolDb2Context context)
        {
            foreach (Subject s in context.Subjects)
            {
                Console.WriteLine(s.SubjectId + " " + s.Name);
            }
        }

        static void EditTeacherCourse(SchoolDb2Context context, int teacherID, int newCourseID)
        {
            TeacherCourse teacherRelationToChange = context.TeacherCourses.Where(x => x.TeacherId == teacherID).FirstOrDefault();

            if (context.Courses.Any(x => x.CourseId == newCourseID))
            {
                teacherRelationToChange.CourseId = newCourseID;
                context.SaveChanges();
            }
        }

        static void DeleteTeacherCourse(SchoolDb2Context context, int toDelete)
        {
            var tcToDelete = context.TeacherCourses.Where(x => x.Id == toDelete).FirstOrDefault();

            context.TeacherCourses.Remove(tcToDelete);
            context.SaveChanges();
        }
    }
}