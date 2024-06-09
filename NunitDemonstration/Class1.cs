namespace NunitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180) 
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "Avani's triangle is NOT valid.";
            }
            return result;
        }
    }
}
