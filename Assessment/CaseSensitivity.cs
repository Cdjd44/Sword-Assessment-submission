namespace Assessment
{
    public class CaseSensitivity
    {
        public bool value { get; set; }

        public CaseSensitivity()
        {
            value = true;
        }

        public CaseSensitivity(string val)
        {
            try
            {
                value = Convert.ToBoolean(val);
            }
            catch (Exception ex)
            {
                Console.WriteLine("value:" + val + " is not a valid input. true or false are the required inputs. Default value of 'true' will be used for analysis.");
                value = true;
            }
            
        }

        public bool getValue()
        {
            return value;
        }
    }
}