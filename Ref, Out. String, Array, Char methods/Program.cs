using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Ref__Out._String__Array__Char_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1

            /* 
            
            ValidatePassword(string password) - methodunuz olur, parameter olaraq qebul etdiyi stringin uzunlugu minimum 8,
            böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı və minimum 1 karakter
            (hərf və ya rəqəm olmayan: misal  ?, !, @) olmalıdır.
            Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır
            
            */

            //Console.WriteLine("Enter a password: ");
            //string password = Console.ReadLine();
            
            //Console.WriteLine(ValidatePassword(password));

            


            #endregion


            #region Task2

            /*
              
            String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq.
            Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir. 
            
            */

            string word = "  salam  pb503  ";



            //Replace(word,' ','b') ;

            //Console.WriteLine(Substring(word, 3, 3));
        
            //Trim(word);

            #endregion
        }

        #region Task1Methods

        static bool ValidatePassword(string password)
        {
            if (password == null || string.IsNullOrEmpty(password.Trim()))
                return false;
            else if (password.Length < 8)
                return false;
            else if (password[0].ToString() != password[0].ToString().ToUpper())
                return false;
            else if (!password.Any(char.IsDigit))
                return false;
            else if (!CheckForSpecialCharacter(password))
                return false;

            
            return true;
        }

        // method 1
        static bool CheckForSpecialCharacter(string password)
        {
            string specialCharacters = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (char character in password)
            {
                if (specialCharacters.Contains(character))
                    return true;


            }
            return false;
        }

        // method 2
        static bool CheckForSpecialCharachter2(string password) 
        {

            string specialCharacters = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            return password.Any(c => specialCharacters.Contains(c));


        }
        
       
        #endregion


        #region Task2Methods

        static void Replace(string word, char oldChar, char newChar) 
        {
            char[] chars = word.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == oldChar)
                    chars[i] = newChar;
            }

            Console.WriteLine(chars);

        }

        static string Substring(string word, int startIndex, int endIndex)
        {

            

            char[] chars = word.ToCharArray();
            if (endIndex >= chars.Length)
            {
                return "The end index is longer than char's length";

            }
            else if (startIndex >= chars.Length)
            {
                return "The start index is longer than char's length";

            }
            else if (startIndex == endIndex)
            {
                return chars[startIndex].ToString();
                
            }


            else
            {
                char[] newChars = new char[endIndex - startIndex + 1];



                for (int i = startIndex; i <= endIndex; i++)
                {

                    newChars[i - startIndex] = chars[i];

                }
                
                
                var result = newChars.ToString();
                return result;

            }
            
            
        }



        static void Trim(string word)
        {
            
            string wordWithoutSpaces = string.Empty;

            

            for (int i = 0; i < word.Length; i++ )
            {
                if (char.IsWhiteSpace(word[i]))
                {
                    continue;
                }
                
                wordWithoutSpaces += word[i];       
            }

            

            char start = wordWithoutSpaces[0]; 
            char end = wordWithoutSpaces[wordWithoutSpaces.Length - 1]; 

            int startIndex = 0;
            int endIndex = word.Length-1;

            while (word[startIndex] == ' ' && word[startIndex] != start)
            {
                startIndex++;
                
            }
            while (word[endIndex] == ' ' && word[endIndex] != end)
            {
                endIndex--;
                
            }

            int length = endIndex - startIndex + 1;

            var result = word.Substring(startIndex, length);
            Console.WriteLine(result);
            

        }

        #endregion

    }
}

