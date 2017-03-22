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
/// //////////////
 using System.Text;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


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
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(userControl1, userControl2);
            userControl1 = new MyFormUserControl1();
            this.Controls.Add(userControl1);
            userControl1.Top = 25;
            userControl1.Left = 0;

            using (var gb = new DBContainer())
            {
                userControl1.dataGridView1_Client.DataSource =
                    gb.ClientSet.Select(a => new {id = a.ClientID, ФИО = a.ClientName, Адрес = a.ClientAdress,УНН=a.ClientUNN,Пасспорт=a.ClientPassport,Тел_Факс=a.ClientPhonePhax})
                        .ToList();
                userControl1.dataGridView1_Client.Columns[0].Visible = false;
               
            }
            расчетыToolStripMenuItem.Enabled = true;

        }
        //shows counts usercontrol
        private async void расчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                    await query.ToListAsync();
                    userControl2.dataGridView2_Contr.DataSource = await query.Select(a => new
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
                    if (userControl2.listBox1_TypesOfWork.Items.Count != 0)
                        userControl2.listBox1_TypesOfWork.SelectedIndex = 0;

                }
                this.выводToolStripMenuItem.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show(@"Должна быть активна вкладка клиенты");

            }
        }

        private void расчетСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////////////
            string str = PrintShapka();
            string str1 = PrintRaschet();
            string st = str + str1;
            Word.Application wordapp;
            wordapp = new Word.Application();
            wordapp.Visible = true;
            wordapp.Documents.Add();
            wordapp.Selection.Text = st;

        }

        public void ChooseFolder()
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void проектДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный модуль в процессе разработки");
        }

        private void коммерческоеПредлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = PrintCommerce();
            Word.Application wordapp2;
            wordapp2 = new Word.Application();
            wordapp2.Visible = true;
            wordapp2.Documents.Add();
            wordapp2.Selection.Text = str;
        }

        private void расценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный функционал в разработке!");
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный функционал в разработке!");
        }

        private void выводToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        public string PrintShapka()
        {
 string str = "";

            using (var gb = new DBContainer())
            {
                int id = this.userControl2.FindIDContract();
                var contr = gb.ContractSet.Find(id);
              
           string     str1 = "Наименование объекта: " + contr.ContractObject+"\n";
                string str2 = "Заказчик: " + contr.Client.ClientName+"\n"; 
                string str3=@"Подрядчик: ЧСУП Лейпкомпани"+"\n\n";
                string str4 = "\t\t\t\t\tРАСЧЕТ СТОИМОСТИ\n";
                str = str1 + str2 + str3 + str4;
            }
            return str;
        }

        public string PrintRaschet()
        {
            string str = "";
            using (var gb = new DBContainer())
            {
                int id = this.userControl2.FindIDContract();

                var contr = gb.ContractSet.Find(id);
                var cl = gb.ClientSet.First(a => a.ClientID == contr.ClientClientID);
     
                
                List<TypeOfWork> typeOfWorks = gb.TypeOfWorkSet.Where(a => a.ContractContractID == id).ToList();
                str = "\t\t\t\t\t\t Работы\n";
                foreach (var b in typeOfWorks)
                {

                    str+=b.TypeOfWorkName + ":\n";
                    foreach (var a in b.Work)
                    {
                       
                       str+=a.WorkName + "\t" + a.WorkAmmount + " " + a.WorkUnit + "\tцена ед. " +
                                     a.WorkUnitPrice + " руб.\t" +
                                     "\tcтоимость: " + a.WorkAmmount * a.WorkUnitPrice+" руб."+"\n";
                    }

                }
                str+= "\n\t\t\t\t\t\t Материалы\n";
                List<Work> work=new List<Work>();
                foreach (var i in typeOfWorks)
                {
                    foreach (var b in i.Work)
                    {
                       work.Add(b); 
                    }
                }

                foreach (var i in work)
                {
                    if (i.Material.Count != 0)
                    {
                        str += i.WorkName + "\n";
                        foreach (var z in i.Material)
                        {
                            str += z.MaterialName + "\t" + z.MaterialAmmount + " " + z.MaterialUnit + "\t цена ед. " +
                                   z.MaterialUnitPrice +
                                   " руб." + "\tcтоимость: " + z.MaterialAmmount*z.MaterialUnitPrice + " руб." + "\n";
                        }
                    }


                }
                str+="\r\n" + "Всего стоимость работ на объекте: "+contr.ContractObject+" составляет: " + contr.ContractPrice +
             " белорусских рублей\n";
                double q=0;
                double q1 = 0;
                foreach (var i in work)
                {
                    q += i.WorkUnitPrice*i.WorkAmmount;
                    foreach (var z in i.Material)
                    {
                        q1 += z.MaterialAmmount*z.MaterialUnitPrice;
                    }
                }
                

                str += "в том числе:\n"+q+" руб."+" -стоимость работ\n"+q1+ " руб." + " -стоимость материалов";

               str +="\r\n\r\n\r\n";

               str+=" Заказчик _______________ " + "\t\t\t\t" + "Подрядчик _______________\n";
               str += cl.ClientName + "\t\t\t\t\t" + "Директор ЧСУП Лейпкомпани\n";
                str += "\t\t\t\t\t\t\t" + "Лесько В.Н.";


            }

            return str;
        }

        private void протоколСоглToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str= PrintProtokol();
            Word.Application wordapp1;
            wordapp1 = new Word.Application();
            wordapp1.Visible = true;
            wordapp1.Documents.Add();
         wordapp1.Selection.Text = str;
        }

        public string PrintProtokol()
        {
            string str = "";

            using (var gb = new DBContainer())
            {
                int id = this.userControl2.FindIDContract();

                var contr = gb.ContractSet.Find(id);
                var cl = gb.ClientSet.First(a => a.ClientID == contr.ClientClientID);


                str+= "\n\n\n\n" + "\t\t\t\t\tПРОТОКОЛ\n"
                      + "\t\t\t\tсогласования договорной цены\n" +
                      "\tЧСУП Лейпкомпани, именуемое в дальнейшем  ИСПОЛНИТЕЛЬ, в лице директора Лесько В.Н., действующего на основании Устава," +
                      " с одной стороны, и " + cl.ClientName +
                      " в лице              , действующего на основании Устава, именуемое в дальнейшем ЗАКАЗЧИК, с другой стороны, " +
                      "подписали настоящий протокол:\n" +
                      "Стоимость работ по Договору " + contr.ContractNumber + " от " + contr.ContractDate +
                      " составляет: " + contr.ContractPrice + " белоруских рублей\n" +
                      "Итоговая стоимость работ: " + contr.ContractPrice + " руб.\n\n";
str+=@"Стоимость работ, определенная в соответствии с настоящим Договором по объему работ, на основании расчета стоимости, являющимся неотъемлемой частью упомянутого Договора, является окончательной и пересмотру не подлежит.
 
От Иполнителя                                                                                 От Заказчика
______________                                                                                 ______________
М.П.                                                                                                    М.П.

";

            }
            return str;
        }

        public string PrintCommerce()
        {
            string str = "";

            using (var gb = new DBContainer())
            {
                int id = this.userControl2.FindIDContract();

                var contr = gb.ContractSet.Find(id);
                var cl = gb.ClientSet.First(a => a.ClientID == contr.ClientClientID);

                str += "\n\n\n\n\n\n\n\n\n" + "\t\t\t\t\tКоммерческое предложение\n " + "\t От " +
                       DateTime.Now.ToString(@"dd/MM/yyyy") + "\n" + "\tКому: " + cl.ClientName + "\n";
                str += "\t" + @"ЧСУП Лейпкомпани" +
                       "220009 г. Минск, ул. Шугаева 8, оф.3,тел. 258-73-25,факс 258-73-25," +
                       " УНН 235847874\n";
                str += "\tИзучив направленный  Вами запрос предложений цены, мы, нижеподписавшиеся,   " +
                       "предлагаем осуществить оказание услуг (выполнение работ) на объекте: " + contr.ContractObject +
                       " "
                       + "на сумму: " + contr.ContractPrice + " " + "белоруских рублей, подтвержденную прилагаемым расчетом" +
                       " стоимости\n";
                str += "\tПредставленное коммерческое предложение действительно в течение 45" +
                       " календарных дней с момента регистрации\n";
                str += "\t  Мы  обязуемся  в  случае  принятия  нашего  коммерческого предложения " +
                       " заключить договор в соответствии  с прилагаемым проектом договора и " +
                       "выполнить работы в соответствии с требованиями  запроса предложений\n";
                str +=
                    "\tМы признаем, что направление  заказчиком  запроса  предложений  и представление подрядчиком (исполнителем) " +
                    "коммерческого предложения не накладывает  на  стороны никаких дополнительных обязательств.\n\n\n";
                str += "\tДиректор\n \tЧСУП Лейпкомпани\t\t\t\t\t\t\t\tЛесько В.Н.";











            }
            return str;
        }







    }
}
