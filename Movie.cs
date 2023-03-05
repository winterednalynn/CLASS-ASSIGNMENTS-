using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture5
{
    public class Movie
    {
        //FIELDS: 
        public string MovieName;
        public double Rating;
        public string Director;
        public int Year;

        //CONSTRUCTORS: 
        public Movie(string movieName, double rating, string director, int year)
        {
            MovieName = movieName;
            Rating = rating;
            Director = director;
            Year = year;
        }
    }



    //QUESTIONS: 

    // How do you add a class to your project?
    // ANSWER: On the right, there is a solution title. Underneath solution there is a green "C#", Right click that green c# area
    // Select Add, Select Class, A window prompts on the screen, Focusing on the name area (bottom of the window), Title the topic 
    // of your project, Titling your project consist of one word and when naming a class - the title must start with a capital letter, 
    // After titling your project then select add (located on the right bottom of the window), The window that once prompted
    // will disappear and visual studio will auto generate a class tab with the desire label. 


    //When naming your class, it has to start with a what?
    //ANSWER: When naming your class it must start with a capitilize letter (i.e: Movies , Flowers, Radio, Bubbles) 

    //When you create a class, what do you have to do to make it public?
    //ANSWER: When the tab prompts for the new class that's created, it is generated with "internal class title" the word "internal" is a access modifier, if we keep it as it is, we may get things redlining when producing a coding structure that correlates what is in this particular tab. To transition the access modifier, changed "internal" to "public". 

    //What are the 4 components of a class?
    // ANSWER: Fields, Constructors, Properties, Methods - These are also called members. A member is anything that partakes in a class.

    //FIELDS - Variables. 
    //CONSTRUCTORS - Letting you create an object 
    //PROPERTIES - Access to the fields. 
    //METHODS - Behaviors 


    //What is a name for something that is a part of the class?
    //ANSWER: MEMBERS 


    //What is an instance?
    //ANSWER: An instance is a variable of any type that consist of a class. This is used to store object inforamtion. 

    //How do we make one?
    //ANSWER: THE STRUCTURE:   Student student = new Student(); 

    //What does the new keyword do?
    //ANSWER: The "NEW" keyword defines that a creation of an object into memory. 

    //How do you access members of an object?
    //ANSWER: use the dot. 


    //What does a Constructor do?
    //ANSWER: 

    //How do you create a constructor?
    //ANSWER: A constructor possesses an ACCESS MODIFIER, CLASSNAME, PARENTHESES 

    //What happens to the default constructor when I make a new constructor?
    //ANSWER: Default Constructor takes no arguments. When a new constructor is created, the default constructor is discarded. 

    //How do you define a property
    //ANSWER: By the ACCESS MODIFIER , TYPE OF FIELD , & NAME OF THE FIELD (Upper Case for the start of the word.) NO PARENTHESES 

    //What are properties used for?
    //ANSWER: Properties are used to limit user to Read a value / write the value 

    //What does a Get allow?
    //ANSWER : GET Allows to READ THE VALUE 

    //What does a Set allow?
    //ANSWER: Set allows the user to WRITE THE VALUES 
}
