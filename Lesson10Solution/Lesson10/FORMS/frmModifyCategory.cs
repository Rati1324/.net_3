using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson10.EF;
using Lesson10.Classes;
using Lesson10.ENUMS;

namespace Lesson10.FORMS
{
    public partial class frmModifyCategory : Form
    {
        private ModeEnum mode;
        private NWDBEntities db = new NWDBEntities();
        public frmModifyCategory(ModeEnum mode)
        {
            InitializeComponent();
            this.mode = mode;

            switch (this.mode)
            {
                case ModeEnum.Add:
                    {
                        this.Text = "Add New Category";
                        label1.Visible = false;
                        textBox_ID.Visible = false;
                        button_Agreement.Text = "Agreement";
                    }; break;

                case ModeEnum.Edit:
                    {
                        this.Text = "Update Category";
                        button_Agreement.Text = "Agreement";
                    }; break;

                case ModeEnum.Delete:
                    {
                        this.Text = "Delete Category";
                        button_Agreement.Text = "Delete";
                    }; break;

                default: break;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                switch (this.mode)
                {
                    case ModeEnum.Add:
                        {
                            Category cat = new Category();
                            cat.CategoryName = textBox_Name.Text;
                            cat.Description = textBox_Description.Text;
                            //cat.Picture = pictureBox_Category.Image
                            db.Categories.Add(cat);
                        }; break;
                    case ModeEnum.Edit:
                        {
                            int categoryID = int.Parse(textBox_ID.Text);
                            Category cat = db.Categories.Where(i => i.CategoryID == categoryID).First();
                            cat.CategoryName = textBox_Name.Text;
                            cat.Description = textBox_Description.Text;
                            //cat.Picture = pictureBox_Category.Image
                        }; break;
                    case ModeEnum.Delete:
                        {
                            if (MessageBox.Show("Do you want to remove this category from list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int categoryID = int.Parse(textBox_ID.Text);
                                Category cat = db.Categories.Where(i => i.CategoryID == categoryID).First();
                                db.Categories.Remove(cat);
                            }
                            else
                                return;
                        }; break;

                    default: break;
                }


                db.SaveChanges();
                MessageBox.Show("Success!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_ID_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_ID.Text))
                {
                    int categoryID;
                    if (int.TryParse(textBox_ID.Text, out categoryID))
                    {
                        Category cat = db.Categories.Where(i => i.CategoryID == categoryID).FirstOrDefault();
                        if (cat != null)
                        {
                            textBox_Name.Text = cat.CategoryName;
                            textBox_Description.Text = cat.Description;
                            // pictureBox_Category.Image = cat.Picture;

                            textBox_ID.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
