using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.EndUser.Common.PswHash
{
    public class PasswordHash
    {
        private char[] fullArr = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+', '-', '&', '|', '!', '(', ')', '{', '}', '[', ']', '^', '*', '?', ':' };


        public string Encrypt(string password)
        {
            var randomNumbers = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                var r = new Random().Next(fullArr.Length);
                randomNumbers.Add(r.ToString().PadLeft(3, 'x'));
                var ch = password[i];
                var b = (byte)ch + r;
                var value = b.ToString().PadLeft(3, '0');

                var randomChar = fullArr[r];
                sb.Append(value);
                sb.Append(randomChar);
            }
            sb.Append($".{string.Join("", randomNumbers)}");
            return sb.ToString();
        }
        public string Decrypt(string password)
        {
            var arr = password.Split('.');
            var randomNumberArr = arr[1];

            List<int> liste = new List<int>();
            int a = 0;
            string sonuc = "";
            for (int i = 0; i < ((randomNumberArr.Length) / 3); i++)
            {
                sonuc = $"{randomNumberArr[a]}{randomNumberArr[a + 1]}{randomNumberArr[a + 2]}";

                liste.Add(int.Parse(sonuc.Replace("x", "")));
                a = a + 3;
            }
            var randomNumbers = liste;

            var sb = new StringBuilder();
            var passPart = arr.First();

            List<int> liste1 = new List<int>();
            int a1 = 0;
            string sonuc1 = "";
            var random = arr.First();
            for (int i = 0; i < ((random.Length) / 4); i++)
            {
                sonuc1 = $"{random[a1]}{random[a1 + 1]}{random[a1 + 2]}{random[a1 + 3]}";

                liste1.Add(int.Parse(sonuc1.Substring(0, sonuc1.Length - 1)));
                a1 = a1 + 4;
            }
            var byteArr = liste1;

            for (int i = 0; i < byteArr.Count; i++)
            {
                var randomNumber = randomNumbers[i];
                var ch = byteArr[i] - randomNumber;
                sb.Append((char)ch);
            }

            return sb.ToString();
        }
    }
}
