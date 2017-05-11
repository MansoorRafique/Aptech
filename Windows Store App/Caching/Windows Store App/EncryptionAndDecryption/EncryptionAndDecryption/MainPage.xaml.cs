using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EncryptionAndDecryption
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public static byte[] Encrypt(string plainText, string pw, string salt) {
            IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8); 
            IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE); 
            IBuffer plainBuffer = CryptographicBuffer.ConvertStringToBinary(plainText, BinaryStringEncoding.Utf16LE); 
            KeyDerivationAlgorithmProvider keyDerivationProvider = Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_ SHA1"); 
            KeyDerivationParameters pbkdf2Parms = KeyDerivationParameters.BuildForPbkdf2(saltBuffer, 1000); 	
            CryptographicKey keyOriginal = keyDerivationProvider.CreateKey(pwBuffer);
            IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(keyOriginal, pbkdf2Parms, 32); 
            CryptographicKey derivedPwKey = keyDerivationProvider.CreateKey(pwBuffer); 
            IBuffer saltMaterial = CryptographicEngine.DeriveKeyMaterial(derivedPwKey, pbkdf2Parms, 16); 
            string keyMaterialString = CryptographicBuffer. EncodeToBase64String(keyMaterial); 
            string saltMaterialString = CryptographicBuffer. EncodeToBase64String(saltMaterial); 
            SymmetricKeyAlgorithmProvider symProvider = SymmetricKeyAlgorithmProvider. OpenAlgorithm("AES_CBC_PKCS7"); 
            CryptographicKey symmKey = symProvider.CreateSymmetricKey(keyMaterial); 
            IBuffer resultBuffer = CryptographicEngine.Encrypt(symmKey, plainBuffer, saltMaterial); 	
            byte[] result; 
            CryptographicBuffer.CopyToByteArray(resultBuffer, out result); 
            return result; 
        }	

        public static string Decrypt(byte[] encryptedData, string pw, string salt) {
            IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8); 
            IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE); 
            IBuffer cipherBuffer=CryptographicBuffer.CreateFromByteArray(encryptedData); 
            KeyDerivationAlgorithmProvider keyDerivationProvider = Windows.Security. Cryptography.Core.KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_ SHA1");
            KeyDerivationParameters pbkdf2Parms = KeyDerivationParameters. BuildForPbkdf2(saltBuffer, 1000); 
            CryptographicKey keyOriginal=keyDerivationProvider.CreateKey(pwBuffer); 
            IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(keyOriginal, pbkdf2Parms, 32);
            CryptographicKey derivedPwKey=keyDerivationProvider.CreateKey(pwBuffer); 
            IBuffer saltMaterial=CryptographicEngine.DeriveKeyMaterial(derivedPwKey, pbkdf2Parms, 16); 
            string keyMaterialString=CryptographicBuffer. EncodeToBase64String(keyMaterial); 
            string saltMaterialString=CryptographicBuffer. EncodeToBase64String(saltMaterial); 
            SymmetricKeyAlgorithmProvider symProvider = SymmetricKeyAlgorithmProvider. OpenAlgorithm("AES_CBC_PKCS7"); 
            CryptographicKey symmKey = symProvider.CreateSymmetricKey(keyMaterial); 
            IBuffer resultBuffer = CryptographicEngine.Decrypt(symmKey, cipherBuffer, saltMaterial); 
            string result=CryptographicBuffer. ConvertBinaryToString(BinaryStringEncoding.Utf16LE, resultBuffer); 
            return result; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Array of bytes is created 
            byte[] EncryptedValue; 	
            string encr = "";
            //Encrypted value is created by passing password and salt value 
            EncryptedValue = EncryptionHelper.Encrypt(txtText.Text, "pw", "salt"); 
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding(); 
            encr = encoding.GetString(EncryptedValue, 0, EncryptedValue.Count()); 
            txtEncryted.Text = encr.ToString(); 
            txtDecrypted.Text = EncryptionHelper.Decrypt(EncryptedValue, "pw", "salt"); 
        }	
    }
}

public static class EncryptionHelper 
{
    public static byte[] Encrypt(string plainText, string pw, string salt) 
    {
        //password buffer is created 
        IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8); 
        //salt buffer is created 
        IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE);
        IBuffer plainBuffer = CryptographicBuffer.ConvertStringToBinary(plainText, BinaryStringEncoding.Utf16LE); 
        KeyDerivationAlgorithmProvider keyDerivationProvider = Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_SHA1"); 
        //key parameters are passed 
        KeyDerivationParameters pbkdf2Parms = KeyDerivationParameters. BuildForPbkdf2(saltBuffer, 1000); 
        //original key is created and stored 
        CryptographicKey keyOriginal=keyDerivationProvider.CreateKey(pwBuffer); 
        IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(keyOriginal, pbkdf2Parms, 32); 
        CryptographicKey derivedPwKey=keyDerivationProvider.CreateKey(pwBuffer); 
        IBuffer saltMaterial = CryptographicEngine.DeriveKeyMaterial(derivedPwKey, pbkdf2Parms, 16); string keyMaterialString=CryptographicBuffer. EncodeToBase64String(keyMaterial); 
        string saltMaterialString = 
        CryptographicBuffer.EncodeToBase64String(saltMaterial); 
        //A variable that holds symmetric key provider 
        SymmetricKeyAlgorithmProvider symProvider = SymmetricKeyAlgorithmProvider. OpenAlgorithm("AES_CBC_PKCS7"); 
        //Symmetric key is created and stored in symKey 
        CryptographicKey symmKey = symProvider.CreateSymmetricKey(keyMaterial); 
        IBuffer resultBuffer = CryptographicEngine.Encrypt(symmKey, plainBuffer, saltMaterial);byte[]result; CryptographicBuffer.CopyToByteArray(resultBuffer, out result); 
        return result;
    }

    public static string Decrypt(byte[] encryptedData, string pw, string salt) {
        IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8); 
        IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE); 
        IBuffer cipherBuffer = CryptographicBuffer. CreateFromByteArray(encryptedData); 
        KeyDerivationAlgorithmProvider keyDerivationProvider = Windows.Security. Cryptography.Core.KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_SHA1"); 	
        KeyDerivationParameters pbkdf2Parms = KeyDerivationParameters. BuildForPbkdf2(saltBuffer, 1000); 
        CryptographicKey keyOriginal = keyDerivationProvider.CreateKey(pwBuffer); 
        IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(keyOriginal, pbkdf2Parms, 32);CryptographicKey derivedPwKey = keyDerivationProvider.CreateKey(pwBuffer); 
        IBuffer saltMaterial = CryptographicEngine.DeriveKeyMaterial(derivedPwKey, pbkdf2Parms, 16); 
        string keyMaterialString = CryptographicBuffer. EncodeToBase64String( keyMaterial); 
        string saltMaterialString = CryptographicBuffer. EncodeToBase64String( saltMaterial); 
        SymmetricKeyAlgorithmProvider symProvider = SymmetricKeyAlgorithmProvider. OpenAlgorithm("AES_CBC_PKCS7"); 	
        CryptographicKey symmKey = symProvider.CreateSymmetricKey(keyMaterial); 
        IBuffer resultBuffer = CryptographicEngine.Decrypt (symmKey, cipherBuffer, saltMaterial); 
        string result = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16LE, resultBuffer); return result;
    }
}