//shrikant
 partial class Student
{
public void PrintDetails()
    {
        System.Console.WriteLine($"{RollNumber}-{Name}");
    }
   partial void print();
    //partial void print()
    // {
    //     System.Console.WriteLine("Print");
    // }
    public Student()
    {
        print();
    }
}
interface IA
{
    void print();
}
class A
{

}
class B
{

}