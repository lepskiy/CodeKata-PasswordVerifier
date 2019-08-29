using System;

namespace PasswordVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = args[0];
            IPasswordVerifier verifier = null; // assign with correct implementation

            bool isValid;
            string reason = null;

            try
            {
                isValid = verifier.Verify(password);
            }
            catch (Exception ex)
            {
                isValid = false;
                reason = ex.Message;
            }

            Console.WriteLine(isValid
                ? $"Password '{password}' is valid."
                : $"Password '{password}' is invalid: {reason}");
        }
    }
}
