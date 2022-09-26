﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day21UserExcapation
{
    internal class ValidateEmail1
    {
        public static void ValidateEmail()
        {
            try
            {
                Console.WriteLine("Enter a email");
                string email = Console.ReadLine();

                string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";
                if (Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine("Email is " + email);
                }
                else
                {
                    throw (new CustomException("Email is not valid "));
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
