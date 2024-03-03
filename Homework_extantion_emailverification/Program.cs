


using Homework_extantion_array;


Console.WriteLine("add email");
string email = Console.ReadLine();
Console.WriteLine("add password");
string password = Console.ReadLine();


if (email.ContainsAtSymbol())
{
    Console.WriteLine("Email contains @ symbol.");
}
else
{
    Console.WriteLine("Email does not contain @ symbol.");
}


if (password.IsPasswordLengthValid())
{
    Console.WriteLine("Password length is valid.");
}
else
{
    Console.WriteLine("Password length is not valid.");
}