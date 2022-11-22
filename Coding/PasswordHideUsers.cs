using System;
using System.Text;
using System.Security.Cryptography;

class PasswordHideUsers{
    public static string PasswordUsers()
    {
        Console.Clear();
        //password
        Console.Write("Please input a password (input characters will be hidden): ");
        string password = GetHiddenConsoleInput();
        byte[] passwordByteArray = Encoding.ASCII.GetBytes(password);

        SHA256 sha256 = SHA256.Create();
        byte[] passwordHash = sha256.ComputeHash(passwordByteArray);


        //password confirme
        Console.Write("Please input a password (input characters will be hidden): ");
        string confirmedPassword = GetHiddenConsoleInput();

        byte[] confirmedPasswordByteArray = Encoding.ASCII.GetBytes(confirmedPassword);
        byte[] confirmedPasswordHash = sha256.ComputeHash(confirmedPasswordByteArray);

        if(MatchByteArray(ref passwordHash, ref confirmedPasswordHash))
        {
            Console.WriteLine("Your password matches.");
            Console.WriteLine("===================================================================");
            return password;
        }
        else
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("Your passwords do not match.");
            Console.WriteLine("Please try again. (Enter for next)");
            Console.ReadKey();
            BackToReturn();
            return null;
        } 
        
    }
    static string GetHiddenConsoleInput()
    {
        StringBuilder input = new StringBuilder();

        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) break;
            if (key.Key == ConsoleKey.Backspace && input.Length > 0) input.Remove(input.Length - 1, 1);
            else if (key.Key != ConsoleKey.Backspace) input.Append(key.KeyChar);
        }
        Console.WriteLine();

        return input.ToString();
    }

    static bool MatchByteArray(ref byte[] arr1, ref byte[] arr2)
    {
        if(arr1.Length != arr2.Length)
        {
            return false;
        }
        for(int i=0; i < arr1.Length; i++)
        {
            if(arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }
    static void BackToReturn()
    {
        PasswordUsers();
    }
}