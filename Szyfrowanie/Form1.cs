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
            InitMainMenu();
            InitSideMenu();

            ShowMenu();
        }

        void InitMainMenu()
        {
            List<Control> mainMenu = new List<Control>();
            Button button;
            int i = 0;
            //szyfr 1
            button = new Button();
            button.Name = "Cezara";
            button.Text = "Szyfr Cezara";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            i++;
            //szyfr 2
            button = new Button();
            button.Name = "2";
            button.Text = "Szyfr 2";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            i++;
            //szyfr 3
            button = new Button();
            button.Name = "3";
            button.Text = "Szyfr 3";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += MainMenuCiperClick;
            mainMenu.Add(button);
            i++;
            //wyjdz
            button = new Button();
            button.Name = "Wyjdz";
            button.Text = "Wyjdz";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
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
            int i = 0;
            //szyfruj
            button = new Button();
            button.Name = "Szyfruj";
            button.Text = "Szyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            sideMenu.Add(button);
            i++;
            //deszyfruj
            button = new Button();
            button.Name = "Deszyfruj";
            button.Text = "Deszyfruj";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            sideMenu.Add(button);
            i++;
            //cofnij
            button = new Button();
            button.Name = "Cofnij";
            button.Text = "Cofnij";
            button.Size = new Size(200, 50);
            button.Location = new Point(15, 15 + i * 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            button.Click += BackToMainMenu;
            sideMenu.Add(button);

            Cont.Add("SideMenu", sideMenu);
        }

        void CloseForm(object o, EventArgs e)
        {
            this.Close();
        }

        void MainMenuCiperClick(object o, EventArgs e)
        {
            ShowMenu("SideMenu", "Szyfry " + ((Control)o).Name, 215);
        }

        void BackToMainMenu(object o, EventArgs e)
        {
            ShowMenu();
        }

        void ShowMenu(string menuName = "MainMenu", string title = "szyfry", int height = 280, int width = 230)
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
