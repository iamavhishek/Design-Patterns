public class Program
{
    public static void Main(String[] args)
    {
        Institute tuInstitute = InstituteProducer.getFaculty("TU");
        ITeacher tuTeacher = tuInstitute.viewTeacher("PART TIME TEACHER");
        tuTeacher.shift();
        tuTeacher.salary();

        IStudent student = tuInstitute.viewStudent("BACHELOR STUDENT");
        student.shift();
        student.fee();

        Institute hsebInstitute = InstituteProducer.getFaculty("HSEB");
        ITeacher hsebTeacher = hsebInstitute.viewTeacher("FULL TIME TEACHER");
        hsebTeacher.shift();
        hsebTeacher.salary();

        IStudent hsebStudent = hsebInstitute.viewStudent("PLUS TWO STUDENT");
        hsebStudent.shift();
        hsebStudent.fee();
    }
}