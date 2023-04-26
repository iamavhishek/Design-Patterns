public class InstituteProducer
{
    public static Institute getFaculty(String choice)
    {
        if(string.Equals(choice, "HSEB", StringComparison.OrdinalIgnoreCase))
        {
            return new HSEBFaculty();
        }
        else if (string.Equals(choice, "TU", StringComparison.OrdinalIgnoreCase))
        {
            return new TUFaculty();
        }
        return null;
    }
}