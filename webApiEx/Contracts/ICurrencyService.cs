namespace webApiEx.Contracts
{
    public interface ICurrencyService
    {
        double Change(double price, string from, string to);

    }
}
