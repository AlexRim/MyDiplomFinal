using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlLibrary;
using  EntityDataBaseLibrary;
using  DialogFormLibrary;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;



namespace MyDiplomFinal
{
    public partial class Form1 : Form
    {
        public MyFormUserControl1 userControl1;
        public MyFormUserControl2 userControl2;


            // method removes current userControl    
        public void ChangeUserControl(MyFormUserControl1 userControl1, MyFormUserControl2 userControl2)
        {
            if (userControl1 != null)
            {
                Controls.Remove(userControl1);
                userControl1.Dispose();
            }
            if (userControl2 != null)
            {
                Controls.Remove(userControl2);
                userControl2.Dispose();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        // shows clients usercontrol
        private async void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(userControl1, userControl2);
            userControl1 = new MyFormUserControl1();
            this.Controls.Add(userControl1);
            userControl1.Top = 25;
            userControl1.Left = 0;

            using (var gb = new DBContainer())
            {
                userControl1.dataGridView1_Client.DataSource =
               await     gb.ClientSet.Select(a => new {id = a.ClientID, ФИО = a.ClientName, Адрес = a.ClientAdress,УНН=a.ClientUNN,Пасспорт=a.ClientPassport,Тел_Факс=a.ClientPhonePhax})
                        .ToListAsync();
                userControl1.dataGridView1_Client.Columns[0].Visible = false;
               
            }

        }
        //shows counts usercontrol
        private async void расчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindCurrentContract find = new FindCurrentContract(userControl1.FindContractId);
            int id = find();
            ChangeUserControl(userControl1, userControl2);
            userControl2 = new MyFormUserControl2();
            this.Controls.Add(userControl2);
            userControl2.Top = 25;
            userControl2.Left = 0;
            
            using (var gb = new DBContainer())
            {             
                IQueryable<Contract> query = gb.ContractSet.Where(a => a.ContractID == id);
                var con = query;
             await  query.ToListAsync();
                userControl2.dataGridView2_Contr.DataSource= await query.Select(a=>new
                {
                    Id = a.ContractID,
                    Номер = a.ContractNumber,
                    Объект = a.ContractObject,
                    Дата = a.ContractDate,
                    Цена = a.ContractPrice,
                    Статус = a.ContractStatus
                }).ToListAsync();
                userControl2.dataGridView2_Contr.Columns[0].Visible = false;
                var typeQuery = from TypeOfWork in gb.TypeOfWorkSet
                    where TypeOfWork.ContractContractID == id
                    select TypeOfWork;
                typeQuery.ToList();
                foreach (var i in typeQuery)
                {
                       userControl2.listBox1_TypesOfWork.Items.Add(i.TypeOfWorkName);
                }
                userControl2.listBox1_TypesOfWork.Refresh();
                userControl2.listBox1_TypesOfWork.SelectedIndex = 0;

            }

        }
    }
}
