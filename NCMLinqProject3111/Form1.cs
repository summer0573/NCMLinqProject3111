using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCMLinqProject3111
{
    public partial class Form1 : Form
    {
        static private List<Animal> animals = new List<Animal>()
        {
            new Animal(){Name = "봄이", Age =5, Types = "고양이", Healthy = true},
            new Animal(){Name = "아리", Age = 2, Types = "고양이", Healthy = true },
            new Animal(){Name = "콩이", Age = 7, Types = "강아지", Healthy = false },
            new Animal(){Name = "푸바오", Age = 3, Types = "판다", Healthy = true },
            new Animal(){Name = "아르세우스", Age =10, Types = "알파카", Healthy = false },
            new Animal(){Name = "피카츄", Age =7, Types = "쥐", Healthy = true },
            new Animal(){Name = "똘이", Age = 12, Types = "강아지", Healthy = false},
            new Animal(){Name = "랑호", Age = 7, Types = "호랑이", Healthy = false },
            new Animal(){Name = "현진이", Age = 8, Types = "토끼", Healthy = true },
            new Animal(){Name = "필릭스", Age = 2, Types = "병아리", Healthy =false },
            new Animal(){Name = "월이", Age = 5, Types = "호랑이", Healthy = false },
            new Animal(){Name = "설이", Age = 7, Types = "표범", Healthy = true },
            new Animal(){Name = "영이", Age = 9, Types = "앵무새", Healthy = false },
            new Animal(){Name = "자리", Age = 1, Types = "거북이", Healthy = false },
            new Animal(){Name = "하리", Age = 2, Types = "부엉이", Healthy = true},
            new Animal(){Name = "꼬부기", Age = 15, Types = "거북이", Healthy = false },
            new Animal(){Name = "돌돌이", Age = 17, Types = "돌고래", Healthy = true },
            new Animal(){Name = "이름이", Age = 9, Types = "쥐", Healthy = true },
            new Animal(){Name = "무명이", Age = 2, Types = "사슴", Healthy =true },
            new Animal(){Name = "레오나르도빚갚으리오", Age = 18, Types = "곰", Healthy = false },
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            animalBindingSource.DataSource = animals;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animalBindingSource.DataSource = from item in animals
                                             orderby item.Name descending
                                             select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animalBindingSource.DataSource = from item in animals
                                             orderby item.Age descending
                                             select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            animalBindingSource.DataSource = from item in animals
                                             orderby item.Types descending
                                             select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            animalBindingSource.DataSource = from item in animals
                                             where item.Healthy == false
                                             orderby item.Types descending
                                             select item;
        }
    }
}
