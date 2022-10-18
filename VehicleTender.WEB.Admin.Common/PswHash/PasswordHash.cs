using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.Admin.Common.PswHash
{
    public class PasswordHash
    {
        private char[] fullArr = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+', '-', '&', '|', '!', '(', ')', '{', '}', '[', ']', '^', '*', '?', ':' };


        public string Encrypt(string password)
        {
            var randomNumbers = new List<string>();
            StringBuilder sb = new();
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
            var arr = password.Split('.', StringSplitOptions.RemoveEmptyEntries);
            var randomNumberArr = arr[1];
            var randomNumbers = randomNumberArr.Chunk(3).Select(i => new string(i).Replace("x", "")).Select(i => int.Parse(i)).ToList();

            var sb = new StringBuilder();
            var passPart = arr.First();
            var byteArr = passPart.Chunk(4).Select(i => new string(i)).Select(i => i.Substring(0, i.Length - 1)).Select(i => int.Parse(i)).ToList();

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
