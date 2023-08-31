using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace MyProject1.Prorigo
{
    class Validation
    {
        static bool ValidateMobileNumber(string mobileNumber)
        {
            Regex mobileNumberRegex = new Regex(@"^[0-9]{10}$");

            return mobileNumberRegex.IsMatch(mobileNumber);

        }



        static bool ValidateEmail(string email)

        {

            Regex emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

            return emailRegex.IsMatch(email);

        }



        static void Main(string[] args)

        {

          //  string mobileNumber = "9876543210";

            string email = "example@email.com";
              string mobileNumber = "12345";

            // string email = "hj@qwre.com";



            if (ValidateMobileNumber(mobileNumber))

            {

                Console.WriteLine("Mobile number is valid");

            }

            else

            {

                Console.WriteLine("Mobile number is not valid");

            }



            if (ValidateEmail(email))

            {

                Console.WriteLine("Email ID is valid");

            }

            else

            {

                Console.WriteLine("Email ID is not valid");

            }
        }
    }
}

        //
        // }

        // }
        //class  Validation
        //{  static bool ValidateMobileNumber(string mobileNumber)
        //    {
        //        return (mobileNumber);
        //    }
        //    static void Main(string[] args)
        //    {

        //        for(int j=0; j<=9;j++)
        //        {
        //            if(j==10)
        //            {
        //                Console.WriteLine("Mobilenumber is Valid"  );
        //            }
        //            else
        //            {
        //                Console.WriteLine("Mobilenumber is not Valid");
        //            }
        //        }    


        //    }  }

        /*^	Begin the match at the start of the string.
        [^@\s]+	Match one or more occurrences of any character other than the @ character or whitespace.
        @	Match the @ character.
        [^@\s]+	Match one or more occurrences of any character other than the @ character or whitespace.
        \.	Match a single period character.
        [^@\s]+	Match one or more occurrences of any character other than the @ character or whitespace.
        $	End the match at the end of the string.*/





    

