namespace ex1;
class Program
{
    static void Main(string[] args)
    {
        MobilePhone phone1 = new MobilePhone("Apple", "iPhone 13", 128, 6, 6.1, 799.99m);
        MobilePhone.PrintDetails(phone1);

        MobilePhone phone2 = new MobilePhone("Samsung", "Galaxy S22", 256, 8, 6.2, 999.99m);
        MobilePhone.PrintDetails(phone2);

        MobilePhone phone3 = new MobilePhone("Google", "Pixel 7", 128, 8, 6.4, 699.99m);
        MobilePhone.PrintDetails(phone3);
    }
}