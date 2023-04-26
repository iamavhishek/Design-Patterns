public class TUFaculty : Institute
{
    public override ITeacher viewTeacher(string teacherType)
    {
        if (teacherType == null)
        {
            return null;
        }
        if (string.Equals(teacherType, "PART TIME TEACHER", StringComparison.OrdinalIgnoreCase))
        {
            return new PartTimeTeacher();
        }
        return null;
    }
    public override IStudent viewStudent(string studentType)
    {
        if (studentType == null)
        {
            return null;

        }
        if (string.Equals(studentType, "Bachelor STUDENT", StringComparison.OrdinalIgnoreCase))
        {
            return new BachelorStudent();
        }
        return null;
    }
}