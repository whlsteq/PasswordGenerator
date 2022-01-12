// See https://aka.ms/new-console-template for more information
String chars= "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
String password = "";
for (int i = 0; i < 12; i++)
{
    Random random = new Random();
    random.Next(0, chars.Length);
    int num = random.Next(0, chars.Length);
    password += chars[num].ToString();
}
Console.WriteLine(password);