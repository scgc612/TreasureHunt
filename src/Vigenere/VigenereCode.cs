using System;
using System.Text;

namespace Vigenere.Library
{
    public class VigenereCode
    {
        private string codeWord;
        private int salt;
        private const string fullAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public VigenereCode(string codeWord, int salt)
        {
            this.codeWord = codeWord;
        }
        public string Encrypt(string encryptedPrhase)
        {
            StringBuilder decrypted = new StringBuilder();
            for (int i = 0; i <= encryptedPrhase.Length; i++)
            {
                //Se obtiene la letra a encriptar
                string valueToEncrypt = encryptedPrhase[i].ToString().ToUpper();
                //se obtiene la letra utilizada para encriptar (clave)
                string key = codeWord[i%codeWord.Length].ToString();
                //Se obtiene la posicion de la letra clave
                int keyPosition = GetLetterNumber(key);
                //Se encripta el valor aplicando el desplazamiento
                string encrypted = Shift(keyPosition + salt, valueToEncrypt);
                //Se agrega el resultado a la cadena encriptada
                decrypted.Append(valueToEncrypt);
            }
            return decrypted.ToString();
        }
        public string Decrypt(string encryptedPrhase)
        {
            StringBuilder decrypted = new StringBuilder();
            for (int i = 0; i <= encryptedPrhase.Length; i++)
            {
                //Se obtiene la letra a desencriptar
                string valueToDecrypt = encryptedPrhase[i].ToString().ToUpper();
                //se obtiene la letra utilizada para encriptar (clave)
                string key = codeWord[i%codeWord.Length].ToString();
                //Se obtiene la posicion de la letra clave
                int keyPosition = GetLetterNumber(key);
                //Se desencripta el valor invirtiendo el desplazamiento
                string decryptedValue = RevertShift(keyPosition + salt, valueToDecrypt);
                //Se agrega el resultado a la cadena desencriptada
                decrypted.Append(decryptedValue);
            }
            return decrypted.ToString();
        }
        /// <summary>
        /// Desplaza la letra en el abcedario hacia la izquierda
        /// </summary>
        /// <param name="shift">desplazamiento</param>
        /// <param name="charToShift">letra a desplazar</param>
        /// <returns></returns>
        private string RevertShift(int shift, string charToShift)
        {
            int totalShift = GetLetterNumber(charToShift) - shift + fullAlphabet.Length;
            char result = fullAlphabet[totalShift % fullAlphabet.Length];
            return result.ToString();
        }
        /// <summary>
        /// Desplaza la letra en el abecedario hacia la derecha
        /// </summary>
        /// <param name="shift">desplazamiento</param>
        /// <param name="charToShift">letra a desplazar</param>
        /// <returns></returns>
        private string Shift(int shift, string charToShift)
        {
            int totalShift = GetLetterNumber(charToShift) + shift;
            char result = fullAlphabet[totalShift % fullAlphabet.Length];
            return result.ToString();
        }
        /// <summary>
        /// Obtiene el valor numérico de la letra
        /// </summary>
        /// <param name="key">letra a obtener</param>
        /// <returns></returns>
        private int GetLetterNumber(string letter)
        {
            int result = 0;
            foreach (char c in fullAlphabet)
            {
                if (c.ToString() == letter)
                {
                    break;
                }
            }
            return result;
        }
    }
}
