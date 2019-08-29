namespace PasswordVerifier
{
    public interface IPasswordVerifier
    {
        bool Verify(string password);
    }
}
