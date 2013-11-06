using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace EncryptTest
{
    public partial class Form1 : Form
    {
        private String filePath = "c:\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Encrypt_Binary();
            //MD5();
            //RSA(); 
            Encrypt_DES();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Decrypt_Binary();
            Decrypt_DES();
        }

        byte[] key;
        byte[] iv;

        private void Encrypt_DES()
        {
            DESCryptoServiceProvider DesCSP = new DESCryptoServiceProvider();
            key = DesCSP.Key;
            iv = DesCSP.IV;

            MemoryStream ms = new MemoryStream();//先创建一个内存流
            CryptoStream cryStream = new CryptoStream(ms, DesCSP.CreateEncryptor(), CryptoStreamMode.Write);//将内存流连接到加密转换流
            StreamWriter sw = new StreamWriter(cryStream);
            sw.WriteLine(textBox_Source.Text);//将要加密的字符串写入加密转换流
            sw.Close();
            cryStream.Close();
            byte[] buffer = ms.ToArray();//将加密后的流转换为字节数组
            textBox_Encrypt.Text = Convert.ToBase64String(buffer);//将加密后的字节数组转换为字符串
        }

        private void Decrypt_DES()
        { 
            DESCryptoServiceProvider DesCSP = new DESCryptoServiceProvider();
            DesCSP.Key = key;
            DesCSP.IV = iv;

            byte[] buffer = Convert.FromBase64String(textBox_Encrypt.Text);
            MemoryStream ms = new MemoryStream(buffer);//将加密后的字节数据加入内存流中
            CryptoStream cryStream = new CryptoStream(ms, DesCSP.CreateDecryptor(), CryptoStreamMode.Read);//内存流连接到解密流中
            StreamReader sr = new StreamReader(cryStream);
            textBox_Decrypt.Text = sr.ReadToEnd();//将解密流读取为字符串
            sr.Close();
            cryStream.Close();
            ms.Close();
        }

        private void RSA()
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = "Olive";//密匙容器的名称，保持加密解密一致才能解密成功

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] plaindata = Encoding.Default.GetBytes(textBox_Source.Text);//将要加密的字符串转换为字节数组
                byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                textBox_Encrypt.Text = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
            }
        }

        private void MD5()
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] palindata = Encoding.Default.GetBytes(textBox_Source.Text);//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            textBox_Encrypt.Text = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
        }

        private void Encrypt_Binary()
        {
            byte[] palindata = Encoding.Default.GetBytes(textBox_Source.Text);
            textBox_Encrypt.Text = Convert.ToBase64String(palindata);
        }

        private void Decrypt_Binary()
        {
            byte[] palindata = Convert.FromBase64String(textBox_Encrypt.Text);
            textBox_Decrypt.Text = Encoding.Default.GetString(palindata);
        }
    }
}
