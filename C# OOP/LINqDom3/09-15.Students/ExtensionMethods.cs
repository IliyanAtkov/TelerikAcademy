namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public static class ExtensionMethods
    {
        public static void GroupNumberTwoLinqOrderExtensionMethod(this List<Student> students)
        {
            var result =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

           // Test.Print(result);
        }
    }
}
