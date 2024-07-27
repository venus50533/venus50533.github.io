﻿using CSharp_Middle_Exam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml.Linq;

namespace CSharp_Middle_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new List<Course>()
            {
              new Course() { CourseId = "A001", Name = "C#", Teacher = "Bill", Classroom = "L107", Credit = 3 },
              new Course() { CourseId = "A002", Name = "HTML/CSS", Teacher = "Amos", Classroom = "L104", Credit = 2 },
              new Course() { CourseId = "A003", Name = "JavaScript/jQuery", Teacher = "奚江華", Classroom = "L104", Credit = 3 },
              new Course() { CourseId = "A004", Name = "MSSQL", Teacher = "Jimmy", Classroom = "L202", Credit = 3 },
              new Course() { CourseId = "A005", Name = "MVC5/CoreMVC", Teacher = "奚江華", Classroom = "L107", Credit = 6 },
              new Course() { CourseId = "B001", Name = "VueJS", Teacher = "Jimmy", Classroom = "L104", Credit = 2 },
              new Course() { CourseId = "B002", Name = "DevOps", Teacher = "David", Classroom = "L107", Credit = 3 },
              new Course() { CourseId = "B003", Name = "MongoDB", Teacher = "Ben", Classroom = "L202", Credit = 2 },
              new Course() { CourseId = "B004", Name = "Redis", Teacher = "Ben", Classroom = "L202", Credit = 2 },
              new Course() { CourseId = "B005", Name = "Git", Teacher = "Andy", Classroom = "L107", Credit = 1 },
              new Course() { CourseId = "B006", Name = "Git", Teacher = "Jimmy", Classroom = "L107", Credit = 1 }
            };

            List<Student> studentList = new List<Student>()
            {
              new Student() { StudentId = "S0001", Name = "小新", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A004", "B002", "B003", "B004", "B005" } },
              new Student() { StudentId = "S0002", Name = "妮妮", Gender = GenderOption.Female, CourseList = new List<string>() { "A002", "A003", "B001", "B002", "B005" } },
              new Student() { StudentId = "S0003", Name = "風間", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A002", "A003", "A004", "A005", "B001", "B002", "B003", "B004", "B005"  } },
              new Student() { StudentId = "S0004", Name = "阿呆", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A002", "A003", "A004", "A005" } },
              new Student() { StudentId = "S0005", Name = "正男", Gender = GenderOption.Male, CourseList = new List<string>() { "B001", "B002", "B003", "B004", "B005" } },
              new Student() { StudentId = "S0006", Name = "小丸子", Gender = GenderOption.Female, CourseList = new List<string>() { "A005" } },
              new Student() { StudentId = "S0007", Name = "小玉", Gender = GenderOption.Female, CourseList = new List<string>() { "A005", "B002", "B003", "B004" } },
            };

            #region 第1題
            // 1. 列出所有課程的名稱
            Console.WriteLine("1. 列出所有課程的名稱");
            {
                Console.WriteLine(string.Join(Environment.NewLine, courseList.Select(x => x.Name)));
            }
            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第2題
            // 2. 列出所有在"L107"教室上課的課程ID
            Console.WriteLine("2. 列出所有在'L107'教室上課的課程ID");
            {
                Console.WriteLine(string.Join(Environment.NewLine, courseList.Where(x => x.Classroom == "L107").Select(x => x.CourseId)));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第3題
            // 3. 列出所有在'L107'教室上課，並且學分為3的課程ID
            Console.WriteLine("3. 列出所有在'L107'教室上課，並且學分為3的課程ID");
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    courseList.Where(x => x.Classroom == "L107" && x.Credit == 3).Select(x => x.CourseId)));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第4題
            // 4. 列出所有老師的名字(名字不能重複出現)
            Console.WriteLine("4. 列出所有老師的名字(名字不能重複出現)");
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    courseList.Select(x => x.Teacher).Distinct()));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第5題
            // 5. 列出所有有在'L202'上課的老師名字(名字不能重複出現)
            Console.WriteLine("5. 列出所有有在'L202'上課的老師名字(名字不能重複出現)");
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    courseList.Where(x => x.Classroom == "L202").Select(x => x.Teacher).Distinct()));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第6題
            // 6. 列出所有女性學生的名字
            Console.WriteLine("6. 列出所有女性學生的名字");
            {
                Console.WriteLine(string.Join(",",
                    studentList.Where(x => x.Gender == GenderOption.Female).Select(x => x.Name)));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第7題***
            // 7. 列出有上'Git'這門課的學員名字
            Console.WriteLine("7. 列出有上'Git'這門課的學員名字");
            {
                var total = studentList.Where(
                    student => student.CourseList.Any((id) => id == "B005" || id == "b006")).
                    Select(student => student.Name);


                Console.WriteLine(string.Join(",", total));
                //-------------------------------------------------
                //    var total =
                //        from student in studentList
                //        from courseId in student.CourseList
                //        where courseId == "B005" || courseId == "B006"
                //        select student.Name;

                //    Console.WriteLine(string.Join(Environment.NewLine, total.Distinct()));
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第8題
            // 8. 列出每個學員上的每一堂課
            // ex:
            /*
                       小玉: 
                            MVC5/CoreMVC
                            DevOps
                            MongoDB
                            Redis
                    */
            Console.WriteLine("8. 列出每個學員上的每一堂課");
            {
                //var studentCourses = studentList
                //   .Select(s => new
                //   {
                //       s.Name,
                //       crouse = s.CourseList
                //                    .SelectMany(id => courseList.Where(c => c.CourseId == id)
                //                    .Select(course => course.Name))
                //   });

                //var result = string.Join(Environment.NewLine,
                //            studentCourses.Select(student =>
                //            {
                //                var courses = string.Join(Environment.NewLine,
                //                        student.crouse.Select(course => $"\t{course}"));
                //                return $"{student.Name}:{Environment.NewLine}{courses}";
                //            }));
                //Console.WriteLine(string.Join(Environment.NewLine, result));
                //----------------------------------------------------------------------------
                ////對 studentList 進行選取操作，為每個學生創建一個包含 Name 和 Courses 的匿名對象。
                //var studentCourse = studentList.Select(s => new
                //{
                //    s.Name,
                //    //對學生的 CourseList 進行選取操作，通過課程 ID 從 courseList 中查找課程名稱。
                //    Courses = s.CourseList
                //                .Select(courseId => courseList.First(course => course.CourseId == courseId).Name)
                //});

                //var result = string.Join(Environment.NewLine,studentCourse.Select(s =>
                //    {
                //        //\t縮排
                //        var courses = string.Join(Environment.NewLine, s.Courses
                //                    .Select(course => $"\t{course}"));
                //        return $"{s.Name}:{Environment.NewLine}{courses}";

                //    }));

                //Console.WriteLine($"{result}");
                //---------------------------------------------------
                var studentCourses = from student in studentList
                                     select new
                                     {
                                         student.Name,
                                         courses = from courseId in student.CourseList
                                                   join course in courseList on courseId equals course.CourseId
                                                   select course.Name
                                     };
                var result = string.Join(Environment.NewLine, studentCourses.Select(student =>
                                      {
                                          var courses = string.Join(Environment.NewLine,
                                             student.courses.Select(course => $"   {course}"));
                                          return $"{student.Name}:{Environment.NewLine}{courses}";
                                      }
                ));
                Console.WriteLine(result);
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第9題****
            // 9. 找出誰上的課數量最少
            Console.WriteLine("9. 找出誰上的課數量最少");
            {
                var lessOne = studentList.OrderBy(s => s.CourseList.Count).FirstOrDefault().Name;
                Console.WriteLine("上課最少的是：" + $"{lessOne}");
            }
            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第10題
            // 10. 找出誰修的學分總和小於10
            Console.WriteLine("10. 找出誰修的學分總和小於10");
            {
                var sumLessThenTen = studentList.Select(s => new
                {
                    s.Name,
                    score = s.CourseList.Select(
                            courseId => courseList.First((x) => x.CourseId == courseId).Credit).Sum()
                });

                var sumLessThenTener = sumLessThenTen.Where(x => x.score < 10).Select(x => x.Name);
                Console.WriteLine(string.Join(Environment.NewLine, sumLessThenTener));

            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第11題****
            // 11. 找出誰最後獲得學分數最高
            Console.WriteLine("11. 找出誰最後獲得學分數最高");
            {
                var scoreOfStudent = studentList.Select(s => new
                {
                    s.Name,
                    score = s.CourseList.Select(
                        coursId => courseList.First(x => x.CourseId == coursId).Credit).Sum()
                });
                var mostHigher = scoreOfStudent
                    .OrderByDescending(x => x.score).FirstOrDefault().Name;
                Console.WriteLine(mostHigher);
            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第12題(加分題)
            // 12. 十二生肖自定義排序
            Console.WriteLine("12. 十二生肖自定義排序");
            {

                List<string> animalOrder = new List<string>
                 {"鼠","牛","虎","兔","龍","蛇","馬","羊","猴","雞","狗","豬"};
                var zoo = new List<string> { "龍", "鼠", "馬", "豬", "羊" }; //答案: 鼠、龍、馬、羊、豬
                Console.WriteLine($"排序前: {string.Join("、", zoo)}{Environment.NewLine}");
                //如果去查生肖idx，根據idx大小判斷位置
                var sortedZoo = zoo.OrderBy(animal=>animalOrder.IndexOf(animal)).ToList();
                Console.Write($"排序後:{string.Join(",",sortedZoo)}");

            }

            #endregion

            Console.ReadLine();
        }
    }
}
