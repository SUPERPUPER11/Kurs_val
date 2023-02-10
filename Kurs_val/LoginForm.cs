using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_val
{

    public partial class LoginForm : Form
    {
        public string loginP = "val";
        public byte[] passwordP = Encoding.UTF8.GetBytes("val1");
        public byte[] saltP = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString("N"));
        public string login;
        public byte[] password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text != string.Empty & textBox2.Text != string.Empty)
            {
                login = textLogin.Text;
                password = Encoding.UTF8.GetBytes(textBox2.Text);

                if (login == loginP & CompareByteArrays(GenerateSaltedHash(password, saltP), GenerateSaltedHash(passwordP, saltP)))
                {
                    MessageBox.Show("Вход выполнен успешно", "Вход выполнен успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (panel1.Parent as Form1)!.SetContent(new KursForm().panel1);
                }
                else
                {
                    errorMessage.Visible = true;
                    errorMessage.Text = "Неправаильный логин или пароль";
                }
            }
        }
        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes = new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void textLogin_Validating(object sender, CancelEventArgs e)
        {
                if (string.IsNullOrWhiteSpace(textLogin.Text))
                {
                    e.Cancel = true;
                    textLogin.Focus();
                    errorProvider1.SetError(textLogin, "Обязательное поле!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textLogin, "");
                }     
        }
    }
 }

