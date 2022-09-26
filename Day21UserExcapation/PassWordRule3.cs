﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day21UserExcapation
{
    internal class PassWordRule3
    {
        public static void ValidatePassword()
        {
            try
            {
                Console.WriteLine("Enter a password");
                string password = Console.ReadLine();
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasNumber = new Regex(@"[0-9]+");
                var hasMiniChars = new Regex(@".{8,}");
                var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$");
                if (pattern.IsMatch(password))
                {
                    Console.WriteLine("Password is " + password);
                }
                else if (!hasMiniChars.IsMatch(password))
                {
                    throw (new CustomException("Password should have minimum 8 characters"));
                }
                else if (!hasLowerChar.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least 1 lower char"));
                }
                else if (!hasUpperChar.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least one upper character"));
                }
                else if (!hasNumber.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least one numeric number"));
                }
                else
                {
                    throw (new CustomException("Invalid Password"));
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
