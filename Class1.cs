using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1
{
    [Table("Employees")]
    public class Emp
    {
        [Key]
        public int Empid { get; set; }

        public string Empname { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="Not valid email id")]
        public string Email { get; set; }
    }

    public class Dept
    {
        [Key]
        public int Deptno { get; set; }
        //1 Dept- M Emp
        public ICollection<Emp> EmpList { get; set; }

    }





    [Table("StudentInfo")]
    public class Student
    {
        [Key]
        [Column(Order =1,TypeName="int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DisplayColumn("RollNo")]
        //[Display(Description ="thsi is for Rollno",Prompt ="Enter RollNo",ShortName ="RollNo")
        public int StudentID { get; set; }

        [DataType(DataType.Text,ErrorMessage ="thsi is not valid value")]
        [MaxLength(15,ErrorMessage ="greater than allowed length 15chars")]
        [MinLength(1,ErrorMessage ="It is required field min 1 char")]

        [Column(Order =2,TypeName ="varchar")]
        [ScaffoldColumn(false)]
        public string StudentName { get; set; }

        [Column(Order = 3, TypeName = "Date")]
        public DateTime BirthDate { get; set; }
        [Column(Order = 4, TypeName = "float")]
        public float Height { get; set; }
        [Column(Order = 5, TypeName = "int")]
        public int Weight { get; set; }
        //[ForeignKey("fk-teacher")]
        //public int TeacherID { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherRefID { get; set; }
        public Teacher Teacher { get; set; }
    }


    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        [NotMapped]
        public string TeacherQual { get; set; }
    }


    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        
        public string Section { get; set; }
        public string Location { get; set; }
        public List<Student> Students { get; set; }
    }



    public class SchoolContext:DbContext
    {
        public SchoolContext() :base("schoolDB")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());

            //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());

            

            //Database.SetInitializer<SchoolContext>(null);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Emp> Employees { get; set; }
        public DbSet<Dept> Depts { get; set; }

    }
    
}
