//Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.
class validtime
{
    static void Main()
    {
        Console.WriteLine("enter a time value (eg:19:00, 23:59)");
        var input = Console.ReadLine();
        try
        {
            var hour = Convert.ToInt32(input.Split(':').First());
            var minute = Convert.ToInt32(input.Split(':').Last());

            Console.WriteLine("hour " + hour + " min: " + minute);
            if (hour >= 00 && hour <= 23 && minute >= 00 && minute <= 59)
            {
                Console.WriteLine("ok");
            }
            else
                Console.WriteLine("Invalid Time");

        }
        catch (Exception ex)
        {
            Console.WriteLine("INVALID INPUT");
        }

        
        
    }
}