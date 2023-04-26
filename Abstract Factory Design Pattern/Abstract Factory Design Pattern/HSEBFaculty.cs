public class HSEBFaculty : Institute
{
    public override ITeacher viewTeacher(string teacherType)
    {
        if (teacherType == null)
        {
            return null;
        }
        if (string.Equals(teacherType, "FULL TIME TEACHER", StringComparison.OrdinalIgnoreCase))
        {
            return new FullTimeTeacher();
        }
        return null;
    }
    public override IStudent viewStudent(string studentType)
    {
        if (studentType == null)
        {
            return null;

        }
        if (string.Equals(studentType, "PLUS TWO STUDENT", StringComparison.OrdinalIgnoreCase))
        {
            return new PlusTwoStudent();
        }
        return null;
    }
}