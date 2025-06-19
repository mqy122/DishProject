using Dishes.Controller;
using Dishes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dishes
{
    public partial class Form1 : Form
        
    {
        DishTypeController types = new DishTypeController();
        DishController dishes = new DishController();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Dish dish)
        {
            txt5.BackColor = Color.LightSalmon;
            txt5.Text = dish.Id.ToString();
            txt2.Text = dish.Name;
            txt3.Text = dish.Description;
            txt4.Text = dish.Price.ToString();
            txt5.Text = dish.Weight.ToString();
            cmb1.Text = dish.DishType.Name;
        }

        private void ClearScreen()
        {
            txt5.BackColor = Color.LightSalmon;
            txt5.Clear();
           txt2.Clear();
           txt3.Clear();
         txt4.Clear();
           txt5.Clear();
           cmb1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishType> allDishTypes = types.GetAllDishTypes();
          cmb1.DataSource = allDishTypes;
            cmb1.DisplayMember = "DishName";
           cmb1.ValueMember = "Id";

         

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt2.Text) || txt2.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                txt2.Focus();
                return;
            }
            Dish newDish = new Dish();
            newDish.Weight = int.Parse(txt5.Text);
            newDish.Name = txt2.Text;
            newDish.Description = txt3.Text;
            newDish.Price = decimal.Parse(txt4.Text);
            newDish.Id = (int)cmb1.SelectedValue;

            dishes.Create(newDish);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            
        }
        
    }
}
