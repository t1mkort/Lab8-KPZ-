using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BurgerDecoratorLab
{
    public partial class Form1 : Form
    {
        private List<string> addons = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Rebuild();
        }

        private void Rebuild()
        {
            lstLog.Items.Clear();

            Burger burger;
            if (radioChicken.Checked)
            {
                burger = new ChickenBurger();
                lstLog.Items.Add("Burger burger = new ChickenBurger();");
            }
            else
            {
                burger = new BeefBurger();
                lstLog.Items.Add("Burger burger = new BeefBurger();");
            }
            lstLog.Items.Add("      Name: " + burger.Name + "; GetCost(): " + burger.GetCost());

            foreach (string addon in addons)
            {
                switch (addon)
                {
                    case "chkCheese":
                        burger = new CheeseBurger(burger);
                        lstLog.Items.Add("burger = new CheeseBurger(burger);");
                        break;
                    case "chkBacon":
                        burger = new BaconBurger(burger);
                        lstLog.Items.Add("burger = new BaconBurger(burger);");
                        break;
                    case "chkTomato":
                        burger = new TomatoBurger(burger);
                        lstLog.Items.Add("burger = new TomatoBurger(burger);");
                        break;
                    case "chkSauce":
                        burger = new SauceBurger(burger);
                        lstLog.Items.Add("burger = new SauceBurger(burger);");
                        break;
                }
                lstLog.Items.Add("      Name: " + burger.Name + "; GetCost(): " + burger.GetCost());
            }

            lblName.Text = "Назва: " + burger.Name;
            lblCost.Text = "Ціна: " + burger.GetCost() + " грн";

            ShowBurger(burger);
        }

        private void ShowBurger(Burger burger)
        {
            Bitmap bmp = new Bitmap(picBurger.Width, picBurger.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int cx = bmp.Width / 2;
                int plateY = bmp.Height * 3 / 4;

                DrawTable(g, bmp.Width, bmp.Height, plateY);
                int y = plateY;
                y = DrawBottomBun(g, cx, y);
                y = burger.Draw(g, cx, y);
                DrawTopBun(g, cx, y);
            }
            Image old = picBurger.Image;
            picBurger.Image = bmp;
            if (old != null)
                old.Dispose();
        }

        private void DrawTable(Graphics g, int width, int height, int plateY)
        {
            g.Clear(Color.FromArgb(255, 248, 232));
            using (SolidBrush wood = new SolidBrush(Color.FromArgb(190, 142, 92)))
            using (SolidBrush edge = new SolidBrush(Color.FromArgb(150, 104, 62)))
            using (SolidBrush shadow = new SolidBrush(Color.FromArgb(120, 80, 50)))
            using (SolidBrush rim = new SolidBrush(Color.FromArgb(226, 226, 232)))
            using (SolidBrush dish = new SolidBrush(Color.FromArgb(246, 246, 250)))
            {
                int tableTop = plateY - 18;
                g.FillRectangle(wood, 0, tableTop, width, height - tableTop);
                g.FillRectangle(edge, 0, tableTop, width, 5);
                int cx = width / 2;
                g.FillEllipse(shadow, cx - 122, plateY - 8, 252, 36);
                g.FillEllipse(rim, cx - 126, plateY - 16, 252, 36);
                g.FillEllipse(dish, cx - 104, plateY - 10, 208, 24);
            }
        }

        private int DrawBottomBun(Graphics g, int cx, int y)
        {
            int w = 204, h = 30, r = 14;
            int left = cx - w / 2;
            int top = y - h;
            using (SolidBrush bun = new SolidBrush(Color.FromArgb(226, 160, 72)))
            using (SolidBrush shade = new SolidBrush(Color.FromArgb(196, 126, 48)))
            {
                g.FillRectangle(shade, left, top, w, h - r);
                g.FillRectangle(shade, left + r, top + h - r, w - 2 * r, r);
                g.FillEllipse(shade, left, top + h - 2 * r, 2 * r, 2 * r);
                g.FillEllipse(shade, left + w - 2 * r, top + h - 2 * r, 2 * r, 2 * r);
                g.FillRectangle(bun, left, top, w, 12);
            }
            return top;
        }

        private void DrawTopBun(Graphics g, int cx, int y)
        {
            int w = 208, dome = 52, slab = 10;
            int left = cx - w / 2;
            int[] seedX = { -60, -34, -8, 20, 46, 68, -46, -18, 8, 34, -2 };
            int[] seedY = { 30, 18, 10, 14, 24, 34, 38, 28, 26, 36, 20 };
            using (SolidBrush bun = new SolidBrush(Color.FromArgb(226, 160, 72)))
            using (SolidBrush shade = new SolidBrush(Color.FromArgb(196, 126, 48)))
            using (SolidBrush shine = new SolidBrush(Color.FromArgb(240, 190, 110)))
            using (SolidBrush seed = new SolidBrush(Color.FromArgb(255, 244, 214)))
            {
                int top = y - slab - dome;
                g.FillRectangle(shade, left, y - slab, w, slab);
                g.FillPie(shade, left, top, w, 2 * dome, 180, 180);
                g.FillPie(bun, left + 4, top + 4, w - 8, 2 * dome - 8, 180, 180);
                g.FillEllipse(shine, cx - 70, top + 12, 56, 14);
                for (int i = 0; i < seedX.Length; i++)
                {
                    g.FillEllipse(seed, cx + seedX[i] - 4, top + seedY[i], 8, 4);
                }
            }
        }

        private void radioBase_CheckedChanged(object sender, EventArgs e)
        {
            Rebuild();
        }

        private void chkAddon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                addons.Add(box.Name);
            else
                addons.Remove(box.Name);
            Rebuild();
        }
    }
}
