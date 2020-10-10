using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Szyfrowanie
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Control>> Cont = new Dictionary<string, List<Control>>();
        IList<char> alphabet = new List<char> { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' };

        public Form1()
        {
            InitializeComponent();
            Init();

            ShowMenu();
        }
        //init
        void Init()
        {
            InitMainMenu();
            InitSideMenu();
            InitEncryptCaesar();
            InitDecryptCaesar();
            InitEncryptVigener();
            InitDecryptVigener();
            InitEncryptPlayfair();
            InitDecryptPlayfair();
        }

        void InitMainMenu()
        {
            List<Control> mainMenu = new List<Control>();
            Button button;
            //szyfr 1
            button = new Button();
            button.Name = "Cezara";
            button.Text = "Szyfr Cezara";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            //szyfr 2
            button = new Button();
            button.Name = "Vigenera";
            button.Text = "Szyfr Vigenère’a";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 80);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            //szyfr 3
            button = new Button();
            button.Name = "Playfair";
            button.Text = "Szyfr Playfair";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 145);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            //wyjdz
            button = new Button();
            button.Name = "Wyjdz";
            button.Text = "Wyjdz";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 210);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += CloseForm;
            mainMenu.Add(button);

            Cont.Add("MainMenu", mainMenu);
        }

        void InitSideMenu()
        {
            List<Control> sideMenu = new List<Control>();
            Button button;
            //szyfruj
            button = new Button();
            button.Name = "Szyfruj";
            button.Text = "Szyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += Switch;
            sideMenu.Add(button);
            //deszyfruj
            button = new Button();
            button.Name = "Deszyfruj";
            button.Text = "Deszyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 80);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += Switch;
            sideMenu.Add(button);
            //cofnij
            button = new Button();
            button.Name = "Cofnij";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 145);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += BackToMainMenu;
            sideMenu.Add(button);

            Cont.Add("SideMenu", sideMenu);
        }

        void InitEncryptCaesar()
        {
            List<Control> caesar = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zaszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            caesar.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            caesar.Add(textBox);
            //label
            label = new Label();
            label.Text = "Przesuniecie";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            caesar.Add(label);
            //textbox
            NumericUpDown numericUpDown;
            numericUpDown = new NumericUpDown();
            numericUpDown.Name = "Przesuniecie";
            numericUpDown.Maximum = 34;
            numericUpDown.Minimum = 1;
            numericUpDown.Size = new Size(200, 20);
            numericUpDown.Location = new Point(15, 110);
            numericUpDown.TabIndex = 0;
            caesar.Add(numericUpDown);
            //button
            Button button;
            button = new Button();
            button.Text = "Szyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += EncryptCaesar;
            caesar.Add(button);
            //button
            button = new Button();
            button.Name = "Cezara";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            caesar.Add(button);

            Cont.Add("Caesar Encrypt", caesar);
        }

        void InitDecryptCaesar()
        {
            List<Control> caesar = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zdeszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            caesar.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            caesar.Add(textBox);
            //label
            label = new Label();
            label.Text = "Przesuniecie";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            caesar.Add(label);
            //textbox
            NumericUpDown numericUpDown;
            numericUpDown = new NumericUpDown();
            numericUpDown.Name = "Przesuniecie";
            numericUpDown.Maximum = 34;
            numericUpDown.Minimum = 1;
            numericUpDown.Size = new Size(200, 20);
            numericUpDown.Location = new Point(15, 110);
            numericUpDown.TabIndex = 0;
            caesar.Add(numericUpDown);
            //button
            Button button;
            button = new Button();
            button.Text = "Zdeszyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += DecryptCaesar;
            caesar.Add(button);
            //button
            button = new Button();
            button.Name = "Cezara";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            caesar.Add(button);

            Cont.Add("Caesar Decrypt", caesar);
        }

        void InitEncryptVigener()
        {
            List<Control> vigener = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zaszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            vigener.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            vigener.Add(textBox);
            //label
            label = new Label();
            label.Text = "Słowo kluczowe";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            vigener.Add(label);
            //textbox
            textBox = new TextBox();
            textBox.Name = "Przesuniecie";
            textBox.Size = new Size(200, 20);
            textBox.Location = new Point(15, 110);
            textBox.TabIndex = 0;
            vigener.Add(textBox);
            //button
            Button button;
            button = new Button();
            button.Text = "Szyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += EncryptVigener;
            vigener.Add(button);
            //button
            button = new Button();
            button.Name = "Vigenera";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            vigener.Add(button);

            Cont.Add("Vigener Encrypt", vigener);
        }

        void InitDecryptVigener()
        {
            List<Control> vigener = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zdeszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            vigener.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            vigener.Add(textBox);
            //label
            label = new Label();
            label.Text = "Słowo kluczowe";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            vigener.Add(label);
            //textbox
            textBox = new TextBox();
            textBox.Name = "Przesuniecie";
            textBox.Size = new Size(200, 20);
            textBox.Location = new Point(15, 110);
            textBox.TabIndex = 0;
            vigener.Add(textBox);
            //button
            Button button;
            button = new Button();
            button.Text = "Zdeszyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += DecryptVigener;
            vigener.Add(button);
            //button
            button = new Button();
            button.Name = "Vigenera";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            vigener.Add(button);

            Cont.Add("Vigener Decrypt", vigener);
        }

        void InitEncryptPlayfair()
        {
            List<Control> playfair = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zaszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            playfair.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            playfair.Add(textBox);
            //label
            label = new Label();
            label.Text = "Słowo kluczowe";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            playfair.Add(label);
            //textbox
            textBox = new TextBox();
            textBox.Name = "Przesuniecie";
            textBox.Size = new Size(200, 20);
            textBox.Location = new Point(15, 110);
            textBox.TabIndex = 0;
            playfair.Add(textBox);
            //button
            Button button;
            button = new Button();
            button.Text = "Szyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += EncryptPlayfair;
            playfair.Add(button);
            //button
            button = new Button();
            button.Name = "Playfair";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            playfair.Add(button);

            Cont.Add("Playfair Encrypt", playfair);
        }

        void InitDecryptPlayfair()
        {
            List<Control> playfair = new List<Control>();
            //label
            Label label;
            label = new Label();
            label.Text = "Text do zdeszyfrowania";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 15);
            label.TabIndex = 0;
            playfair.Add(label);
            //textbox
            TextBox textBox;
            textBox = new TextBox();
            textBox.Name = "Text";
            textBox.Multiline = true;
            textBox.Size = new Size(200, 50);
            textBox.Location = new Point(15, 35);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Vertical;
            playfair.Add(textBox);
            //label
            label = new Label();
            label.Text = "Słowo kluczowe";
            label.Size = new Size(200, 20);
            label.Location = new Point(15, 90);
            label.TabIndex = 0;
            playfair.Add(label);
            //textbox
            textBox = new TextBox();
            textBox.Name = "Przesuniecie";
            textBox.Size = new Size(200, 20);
            textBox.Location = new Point(15, 110);
            textBox.TabIndex = 0;
            playfair.Add(textBox);
            //button
            Button button;
            button = new Button();
            button.Text = "Zdeszyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 150);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += DecryptPlayfair;
            playfair.Add(button);
            //button
            button = new Button();
            button.Name = "Playfair";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 215);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            playfair.Add(button);

            Cont.Add("Playfair Decrypt", playfair);
        }
        //events
        void CloseForm(object o, EventArgs e)
        {
            this.Close();
        }

        void MainMenuCiperClick(object o, EventArgs e)
        {
            ShowMenu("SideMenu", "Szyfr " + ((Control)o).Name, 215);
        }

        void BackToMainMenu(object o, EventArgs e)
        {
            ShowMenu();
        }

        void Switch(object o, EventArgs e)
        {
            bool crypt;
            if (((Control)o).Name == "Szyfruj")
                crypt = true;
            else
                crypt = false;
            switch (this.Text)
            {
                case "Szyfr Cezara":
                    if (crypt)
                        ShowMenu("Caesar Encrypt", "Szyfrowanie Cezara", 280);
                    else
                        ShowMenu("Caesar Decrypt", "Deszyfrowanie Cezara", 280);
                    break;
                case "Szyfr Vigenera":
                    if (crypt)
                        ShowMenu("Vigener Encrypt", "Szyfrowanie Vigenera", 280);
                    else
                        ShowMenu("Vigener Decrypt", "Deszyfrowanie Vigenera", 280);
                    break;
                case "Szyfr Playfair":
                    if (crypt)
                        ShowMenu("Playfair Encrypt", "Szyfrowanie Playfaira", 280);
                    else
                        ShowMenu("Playfair Decrypt", "Deszyfrowanie Playfaira", 280);
                    break;
            }
        }
        //encrypt
        void EncryptCaesar(object o, EventArgs e)
        {
            int n = int.Parse(Controls.Find("Przesuniecie", false)[0].Text);
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";

            foreach (char chart in old)
            {
                int tmp = alphabet.IndexOf(chart);
                if (tmp != -1)
                {
                    resoult += alphabet[(tmp + n) % alphabet.Count];
                }
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }

        void EncryptVigener(object o, EventArgs e)
        {
            string n = Controls.Find("Przesuniecie", false)[0].Text.ToUpper();
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";
            int pass = 0;

            for (int i = 0; i < old.Length; i++)
            {
                int row = alphabet.IndexOf(old[i]);
                int column = alphabet.IndexOf(n[(i - pass) % n.Length]);
                if (row == -1)
                    pass++;
                else
                    resoult += alphabet[(column + row) % alphabet.Count];
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }

        void EncryptPlayfair(object o, EventArgs e)
        {
            string n = Controls.Find("Przesuniecie", false)[0].Text.ToUpper();
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";

            n = n.Replace('J', 'L');
            old = old.Replace('J', 'L');
            char[] tmp = n.ToCharArray();
            Array.Reverse(tmp);
            n = new string(tmp);

            List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < n.Length; i++)
            {
                if (alphabet.Contains(n[i]))
                {
                    for (int j = i + 1; j < n.Length; j++)
                    {
                        if (n[i] == n[j])
                        {
                            n = n.Remove(j, 1);
                            j--;
                        }
                    }
                    alphabet.Remove(n[i]);
                    alphabet.Insert(0, n[i]);
                }
                else
                {
                    n = n.Remove(i, 1);
                    i--;
                }
            }
            //Controls.Find("Text", false)[0].Text = "";

            for (int i = 0; i < old.Length; i++)
            {
                if (!alphabet.Contains(old[i]))
                {
                    old = old.Remove(i, 1);
                    i--;
                }
            }

            for (int i = 0; i < old.Length; i += 2)
            {
                int ind1 = alphabet.IndexOf(old[i]);
                int ind2 = alphabet.IndexOf(old[i + 1]);

                int col1 = ind1 / 5;
                int col2 = ind2 / 5;
                int row1 = ind1 % 5;
                int row2 = ind2 % 5;

                //Controls.Find("Text", false)[0].Text += $"{old[i]} {ind1} {col1 + 1} {row1 + 1} || {old[i + 1]} {ind2} {col2 + 1} {row2 + 1}\r\n";

                if (col1 == col2)
                {
                    ind1 = (row1 + 1 > 5) ? col1 : ind1 + 1;
                    ind2 = (row2 + 1 > 5) ? col2 : ind2 + 1;
                }
                else if (row1 == row2)
                {
                    ind1 = (ind1 + 5 > 25) ? row1 : ind1 + 5;
                    ind2 = (ind2 + 5 > 25) ? row2 : ind2 + 5;
                }
                else
                {
                    ind1 = (col1 * 5) + row2;
                    ind2 = (col2 * 5) + row1;
                }

                resoult += alphabet[ind1];
                resoult += alphabet[ind2];
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }
        //decrypt
        void DecryptCaesar(object o, EventArgs e)
        {
            int n = int.Parse(Controls.Find("Przesuniecie", false)[0].Text);
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";

            foreach (char chart in old)
            {
                int tmp = alphabet.IndexOf(chart);
                if (tmp != -1)
                {
                    if (tmp - n < 0)
                        resoult += alphabet[alphabet.Count + (tmp - n)];
                    else
                        resoult += alphabet[tmp - n];
                }
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }

        void DecryptVigener(object o, EventArgs e)
        {
            string n = Controls.Find("Przesuniecie", false)[0].Text.ToUpper();
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";
            int pass = 0;

            for (int i = 0; i < old.Length; i++)
            {
                int row = alphabet.IndexOf(old[i]);
                int column = alphabet.IndexOf(n[(i - pass) % n.Length]);
                if (row == -1)
                    pass++;
                else
                {
                    if (row - column < 0)
                        resoult += alphabet[alphabet.Count + (row - column)];
                    else
                        resoult += alphabet[row - column];
                }
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }

        void DecryptPlayfair(object o, EventArgs e)
        {
            string n = Controls.Find("Przesuniecie", false)[0].Text.ToUpper();
            string old = Controls.Find("Text", false)[0].Text.ToUpper();
            string resoult = "";

            n = n.Replace('J', 'L');
            old = old.Replace('J', 'L');
            char[] tmp = n.ToCharArray();
            Array.Reverse(tmp);
            n = new string(tmp);

            List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < n.Length; i++)
            {
                if (alphabet.Contains(n[i]))
                {
                    for (int j = i + 1; j < n.Length; j++)
                    {
                        if (n[i] == n[j])
                        {
                            n = n.Remove(j, 1);
                            j--;
                        }
                    }
                    alphabet.Remove(n[i]);
                    alphabet.Insert(0, n[i]);
                }
                else
                {
                    n = n.Remove(i, 1);
                    i--;
                }
            }

            for (int i = 0; i < old.Length; i++)
            {
                if (!alphabet.Contains(old[i]))
                {
                    old = old.Remove(i, 1);
                    i--;
                }
            }

            for (int i = 0; i < old.Length; i += 2)
            {
                int ind1 = alphabet.IndexOf(old[i]);
                int ind2 = alphabet.IndexOf(old[i + 1]);

                int col1 = ind1 / 5;
                int col2 = ind2 / 5;
                int row1 = ind1 % 5;
                int row2 = ind2 % 5;

                if (col1 == col2)
                {
                    ind1 = (row1 - 1 < 0) ? col1 + 4 : ind1 - 1;
                    ind2 = (row2 - 1 < 0) ? col2 + 4 : ind2 - 1;
                }
                else if (row1 == row2)
                {
                    ind1 = (ind1 - 5 < 0) ? row1+20 : ind1 - 5;
                    ind2 = (ind2 - 5 < 0) ? row2+20 : ind2 - 5;
                }
                else
                {
                    ind2 = (col2 * 5) + row1;
                    ind1 = (col1 * 5) + row2;
                }

                resoult += alphabet[ind1];
                resoult += alphabet[ind2];
            }

            Controls.Find("Text", false)[0].Text = resoult;
        }
        //show menu
        void ShowMenu(string menuName = "MainMenu", string title = "Szyfry", int height = 280, int width = 230)
        {
            Controls.Clear();
            Cont[menuName].ForEach(m =>
            {
                Controls.Add(m);
            });

            this.Text = title;
            this.ClientSize = new System.Drawing.Size(width, height);
        }
    }
}
