using System;

namespace EncryptXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "My secret message";
            string key = "12345";

            string answer = EncryptXOR(testString, key);

            Console.WriteLine("testString before xor = " + testString);
            Console.WriteLine("testString after xor = " + answer);

            answer = EncryptXOR(answer, key);

            Console.WriteLine("testString after 2nd xor = " + answer);
        }

        public static string EncryptXOR( string message, string key )
        {
            string newString = "";
            int keyPos = 0;

            for( int messagePos = 0; messagePos < message.Length; messagePos++ )
            {
                int value = message[messagePos] ^ key[keyPos % key.Length];
                newString += (char)value;
            }
            return newString;
        }
    }
}
