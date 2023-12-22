var student = new Student();
student.name = Console.ReadLine();
student.age = Convert.ToInt32(Console.ReadLine());
student.averageGrade = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(student.Getinfo());

System.Console.WriteLine(student.IsExcellentStudent());

class Student
{
    public string name;
    public int age;
    public double averageGrade;

    public string Getinfo()
    {
        return $"Name : {name}\nAge : {age}\nAverageGrade : { averageGrade}";
    }
    public string IsExcellentStudent()
    {
        if( averageGrade > 4.0)
        {
            return $"true";
        }
        else 
        {
            return $"false";
        }
    }
}