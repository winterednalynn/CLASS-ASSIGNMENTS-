using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassLecture5
{//EDNA LYNN LAXA 
 //FEBRUARY 27, 2023 
 // CSI PROGRAMMING II 
 // CLASS 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            Customer();

            Studentexample(); 


        }
        public void Customer()
        {
            Customer Kitana = new Customer("Kitana", "Emory", "5555556464","143 Lush St. Affection,WA 98545");

        Kitana.FirstName = "Emery";

            MessageBox.Show(Kitana.FirstName);
        }

        public void Studentexample()
        {
            List<Student> students = new List<Student>();

            Student student = new Student("EdnaLynn", "Rose", 80, 95);
            Student student2 = new Student("Kitana", "Emory");
            //student.FirstName = "EdnaLynn";
            //student.LastName = "Rose";
            //student.CSIGrade = 80;
            //student.GenEdGrade = 95;

            students.Add(student);
            students.Add(student2);

           
        }
        public string FormattedStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName +  "-" + student.CSIGrade + " - " + student.GenEdGrade;

            return studentInformation;
        }
    }
}
