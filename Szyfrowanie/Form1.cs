using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Control>> Cont = new Dictionary<string, List<Control>>();

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
            button.Name = "2";
            button.Text = "Szyfr 2";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 80);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            //szyfr 3
            button = new Button();
            button.Name = "3";
            button.Text = "Szyfr 3";
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
            textBox.Name = "Caesar";
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
            button.Name = "Szyfruj cezara";
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
            textBox.Name = "Caesar";
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
            button.Name = "Szyfruj cezara";
            button.Text = "Szyfruj";
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
                    if (((Control)o).Name == "Szyfruj")
                        ShowMenu("Caesar Encrypt", "Szyfrowanie Cezara", 280);
                    else
                        ShowMenu("Caesar Decrypt", "Deszyfrowanie Cezara", 280);
                    break;
            }
        }
        //encrypt
        void EncryptCaesar(object o, EventArgs e)
        {
            List<char> alphabet = new List<char> { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' };
            int n = int.Parse(Controls.Find("Przesuniecie", false)[0].Text);
            string old = Controls.Find("Caesar", false)[0].Text.ToUpper();
            string resoult = "";

            foreach (char chart in old)
            {
                int tmp = alphabet.IndexOf(chart);
                if (tmp != -1)
                {
                    resoult += alphabet[(tmp+n)%35];
                }
            }

            Controls.Find("Caesar", false)[0].Text = resoult;
        }
        //decrypt
        void DecryptCaesar(object o, EventArgs e)
        {
            List<char> alphabet = new List<char> { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' };
            int n = int.Parse(Controls.Find("Przesuniecie", false)[0].Text);
            string old = Controls.Find("Caesar", false)[0].Text.ToUpper();
            string resoult = "";

            foreach (char chart in old)
            {
                int tmp = alphabet.IndexOf(chart);
                if (tmp != -1)
                {
                    if(tmp - n <0)
                        resoult += alphabet[35+(tmp-n)];
                    else
                        resoult += alphabet[tmp - n];
                }
            }

            Controls.Find("Caesar", false)[0].Text = resoult;
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
