using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDataBaseLibrary;
using DialogFormLibrary;






namespace UserControlLibrary
{
    public delegate int FindCurrentContract();
    public partial class MyFormUserControl1 : UserControl
    {
        // shows currect (selected) clients contracts
        private async void ShowCurrentClientContracts()
        {
            using (var gb = new DBContainer())
            {


                int id = FindClientID();
                var currentClient = await gb.ClientSet.FirstOrDefaultAsync(a => a.ClientID == id);

                dataGridView_Contract.DataSource =
                    currentClient.Contract.Select(
                        a =>
                            new
                            {
                                Id = a.ContractID,
                                Номер = a.ContractNumber,
                                Объект = a.ContractObject,
                                Дата = a.ContractDate,
                                Цена = a.ContractPrice,
                                Статус = a.ContractStatus
                            }).ToList();
                dataGridView_Contract.Columns[0].Visible = false;
         
            }
        }

        // method refresh ClientDatagrid
        private async void RefreshClientDataView()
        {
            using (var gb = new DBContainer())
            {
                dataGridView1_Client.DataSource =
               await gb.ClientSet.Select(a => new { id = a.ClientID, ФИО = a.ClientName, Адрес = a.ClientAdress, УНН = a.ClientUNN, Пасспорт = a.ClientPassport, Тел_Факс = a.ClientPhonePhax })
                        .ToListAsync();
                dataGridView1_Client.Columns[0].Visible = false;
                dataGridView1_Client.Refresh();
              
            }

        }

        private async void RefreshContractDataView()
        {
            using (var gb = new DBContainer())
            {
                dataGridView_Contract.DataSource =
                    await
                        gb.ContractSet.Select(
                            a =>
                                new
                                {
                                    Id = a.ContractID,
                                    Номер = a.ContractNumber,
                                    Объект = a.ContractObject,
                                    Дата = a.ContractDate,
                                    Цена = a.ContractPrice,
                                    Статус = a.ContractStatus
                                }).OrderBy(a => a.Номер).ToListAsync();
                dataGridView_Contract.Columns[0].Visible = false;
            }


        }
        // method returns Contract ID
        public int FindContractId()
        {
            int id = 0;
            if (dataGridView_Contract.SelectedRows.Count > 0)
            {
                int index = dataGridView_Contract.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView_Contract[0, index].Value.ToString(), out id);
            }

            return id;

        }
        // method returns client ID
     private  int FindClientID()
        {
            int id = 0;
            if (dataGridView1_Client.SelectedRows.Count > 0)
            {
                int index = dataGridView1_Client.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1_Client[0, index].Value.ToString(), out id);
            }

            return id;
        }
        public MyFormUserControl1()
        {
            InitializeComponent();
        }
        // event adds new client
        private async void button1_AddClient_Click(object sender, EventArgs e)
        {
            try
            {
                X:
                var add = new ClientDialog();
                if (add.radioButton1.Checked = true)
                {
                    add.textBox_ClientPassport.Enabled = false;
                }
                add.Text = "Добавить клиента";
                using (var gb = new DBContainer())
                {




                    var client = new Client();
                    if (add.ShowDialog() == DialogResult.OK)
                    {

                        client.ClientUNN = add.textBox_ClientUNN.Text;
                        client.ClientPassport = add.textBox_ClientPassport.Text;
                        client.ClientPhonePhax = add.textBox_ClintPhone.Text;
                        client.ClientAdress = add.textBox1_ClientAdress.Text;
                        client.ClientName = add.textBox1_ClientName.Text;

                        if (await gb.ClientSet.FirstOrDefaultAsync(
                            a => a.ClientUNN == client.ClientUNN && a.ClientPassport == client.ClientPassport) != null)
                        {
                            MessageBox.Show("Такой клиент есть в базе!");
                            return;
                        }

                        if (add.textBox1_ClientName.Text.Length == 0)
                        {
                            MessageBox.Show(@"Поле название/ФИО должно быть заполнено!");
                            goto X;
                        }
                        if (add.textBox1_ClientAdress.Text.Length == 0)
                        {
                            MessageBox.Show(@"Поле адрес должно быть заполнено!");
                            goto X;
                        }
                        if (add.textBox_ClientPassport.Enabled == true && add.textBox_ClientPassport.Text.Length == 0)
                        {
                            MessageBox.Show(@"Поле № пасспорта должно быть заполнено!");
                            goto X;
                        }
                        if (add.textBox_ClientUNN.Enabled == true && add.textBox_ClientUNN.Text.Length == 0)
                        {
                            MessageBox.Show(@"Поле УНН должно быть заполнено!");
                            goto X;
                        }
                        if (add.textBox_ClientUNN.Enabled == true && add.textBox_ClientUNN.Text.Length < 9)
                        {
                            MessageBox.Show(@"Поле УНН должно иметь 9 символов!");
                            goto X;
                        }
                        if (add.textBox_ClientPassport.Enabled == true && add.textBox_ClientPassport.Text.Length < 9)
                        {
                            MessageBox.Show(@"Поле № пасспорта должно иметь 9 символов!");
                            goto X;
                        }

                        gb.ClientSet.Add(client);
                        await gb.SaveChangesAsync();
                        MessageBox.Show("Клиент успешно добавлен!");
                        RefreshClientDataView();
                    }

                }
            }
            catch (Exception)
            {

                throw;
                MessageBox.Show("Неправильно введены данные!");
            }


        }
        //event deletes client
        private async void button1_DeleClient_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить клиента?", "Внимание!", MessageBoxButtons.YesNo,
   MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            using (var gb = new DBContainer())
            {
                var client = await gb.ClientSet.FindAsync(FindClientID());
               
              client.Contract.Clear();
                gb.ClientSet.Remove(client);


                gb.SaveChanges();
            }
            RefreshClientDataView();
         dataGridView_Contract.DataSource=new object();
           
            MessageBox.Show("Клиент удален успешно!");      
        }
        // event changes clents information
        private async void button1_ChangeClient_Click(object sender, EventArgs e)
        {
            try
            {



                Z:
                var add = new ClientDialog();
                add.Text = "Редактировать клиента";
                var client = new Client();
                using (var gb = new DBContainer())
                {
                    client = await gb.ClientSet.FindAsync(FindClientID());
                    add.textBox1_ClientName.Text = client.ClientName;
                    add.textBox_ClintPhone.Text = client.ClientPhonePhax;
                    add.textBox1_ClientAdress.Text = client.ClientAdress;
                    add.textBox_ClientUNN.Text = client.ClientUNN;
                    add.textBox_ClientPassport.Text = client.ClientPassport;
                    if (add.textBox_ClientPassport.Text.Length == 0)
                    {
                        add.radioButton1.Checked = true;
                        add.textBox_ClientPassport.Enabled = false;
                    }
                    if (add.textBox_ClientUNN.Text.Length == 0)
                    {
                        add.radioButton2.Checked = true;
                        add.textBox_ClientUNN.Enabled = false;
                    }
                    if (add.ShowDialog() == DialogResult.OK)
                    {

                        client.ClientUNN = add.textBox_ClientUNN.Text;
                        client.ClientPassport = add.textBox_ClientPassport.Text;
                        client.ClientPhonePhax = add.textBox_ClintPhone.Text;
                        client.ClientAdress = add.textBox1_ClientAdress.Text;
                        client.ClientName = add.textBox1_ClientName.Text;

                    }
                    var result = MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Внимание!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    if (add.textBox1_ClientName.Text.Length == 0)
                    {
                        MessageBox.Show(@"Поле название/ФИО должно быть заполнено!");
                        goto Z;
                    }
                    if (add.textBox1_ClientAdress.Text.Length == 0)
                    {
                        MessageBox.Show(@"Поле адрес должно быть заполнено!");
                        goto Z;
                    }
                    if (add.textBox_ClientPassport.Enabled == true && add.textBox_ClientPassport.Text.Length == 0)
                    {
                        MessageBox.Show(@"Поле № пасспорта должно быть заполнено!");
                        goto Z;
                    }
                    if (add.textBox_ClientUNN.Enabled == true && add.textBox_ClientUNN.Text.Length == 0)
                    {
                        MessageBox.Show(@"Поле УНН должно быть заполнено!");
                        goto Z;
                    }
                    if (add.textBox_ClientUNN.Enabled == true && add.textBox_ClientUNN.Text.Length < 9)
                    {
                        MessageBox.Show(@"Поле УНН должно иметь 9 символов!");
                        goto Z;
                    }
                    if (add.textBox_ClientPassport.Enabled == true && add.textBox_ClientPassport.Text.Length < 9)
                    {
                        MessageBox.Show(@"Поле № пасспорта должно иметь 9 символов!");
                        goto Z;
                    }
                    else
                    {
                        MessageBox.Show("Данные о клиенте успешно изменены");
                    }

                    await gb.SaveChangesAsync();

                    RefreshClientDataView();
                }
            }
            catch (Exception)
            {

                throw;
                MessageBox.Show("Недопустимое действие!");
            }
        }
        //event adds contract to client
        private async void button_AddContractToClient_Click(object sender, EventArgs e)
        {
            try
            {



                C:
                int iD = FindClientID();
                var add = new AddContractDialog();
                add.radioButton_Status1.Checked = true;
                add.Text = "Добавить договор";
                using (var gb = new DBContainer())
                {

                    var contract = new Contract();
                    var currentClient = await gb.ClientSet.FindAsync(FindClientID());
                    int z = currentClient.Contract.Count + 1;
                    add.textBox_ContractNumber.Text = "№ " + DateTime.Now.ToString((@"dd/MM/yyyy")) + "-" + z;
                    add.textBox_ContractDate.Text = DateTime.Now.ToString(@"dd/MM/yyyy");
                    double b;
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        contract.ContractDate = add.textBox_ContractDate.Text;
                        contract.ContractNumber = add.textBox_ContractNumber.Text;
                        contract.ContractPrice = Convert.ToDouble(add.textBox_ContractPrice.Text);
                        contract.ContractObject = add.textBox_ContractObject.Text;
                        foreach (RadioButton radio in add.Controls.OfType<RadioButton>())
                        {
                            if (radio.Checked == true)
                            {
                                contract.ContractStatus = radio.Text;
                            }
                        }

                        if (add.textBox_ContractObject.Text.Length == 0)
                        {
                            MessageBox.Show("Поле предмет договора не может быть пустым!");
                            goto C;
                        }

                        var result2 = MessageBox.Show("Вы уверены что хотите сохранить договор?", "Внимание!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result2 == DialogResult.No)
                        {
                            return;
                        }

                        else
                        {
                            MessageBox.Show("Договор добавлен");
                        }


                        currentClient.Contract.Add(contract);

                        await gb.SaveChangesAsync();
                        ShowCurrentClientContracts();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Не корректно введены данные!");
             return;
            }
        }

        private async void dataGridView1_Client_SelectionChanged(object sender, EventArgs e)
        {
      
            using (var gb = new DBContainer())
            {
                int id = FindClientID();
                var currentClient =await gb.ClientSet.FindAsync(id);
                if (currentClient != null)
                {
                    dataGridView_Contract.DataSource = 
                        currentClient.Contract.Select(
                            a =>
                                new
                                {
                                    Id = a.ContractID,
                                    Номер = a.ContractNumber,
                                    Объект = a.ContractObject,
                                    Дата = a.ContractDate,
                                    Цена = a.ContractPrice,
                                    Статус = a.ContractStatus
                                }).ToList();
                    dataGridView_Contract.Columns[0].Visible = false;
                }
                else
                {
                    var cl=new Client();
                     cl = gb.ClientSet.First(a => a.ClientID >= 0);
                    
                    dataGridView_Contract.DataSource =
                       cl.Contract.Select(
                           a =>
                               new
                               {
                                   Id = a.ContractID,
                                   Номер = a.ContractNumber,
                                   Объект = a.ContractObject,
                                   Дата = a.ContractDate,
                                   Цена = a.ContractPrice,
                                   Статус = a.ContractStatus
                               }).ToList();
                    dataGridView_Contract.Columns[0].Visible = false;
                }


            }
        }
        //event shows clients contracts
        private async void dataGridView1_Client_Click(object sender, EventArgs e)
        {
            using (var gb = new DBContainer())
            {
                int id = FindClientID();
                var currentClient = await gb.ClientSet.FirstOrDefaultAsync(a => a.ClientID == id);

                dataGridView_Contract.DataSource =
                        currentClient.Contract.Select(
                            a =>
                                new
                                {
                                    Id = a.ContractID,
                                    Номер = a.ContractNumber,
                                    Объект = a.ContractObject,
                                    Дата = a.ContractDate,
                                    Цена = a.ContractPrice,
                                    Статус = a.ContractStatus
                                }).ToList();
                dataGridView_Contract.Columns[0].Visible = false;


            }

        }

        private  void dataGridView1_Client_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }
        // method changes contract data
        private async void button_ChangeContract_Click(object sender, EventArgs e)
        {
            var changeDialog=new AddContractDialog();
            changeDialog.Text = "Редактировать договор";
            var contr=new Contract();

            using (var gb = new DBContainer())
            {
                contr = await gb.ContractSet.FindAsync(FindContractId());
                changeDialog.textBox_ContractDate.Text = contr.ContractDate;
                changeDialog.textBox_ContractNumber.Text = contr.ContractNumber;
                changeDialog.textBox_ContractObject.Text = contr.ContractObject;
                changeDialog.textBox_ContractPrice.Text = contr.ContractPrice.ToString();
                if (contr.ContractStatus == "заключается")
                {
                    changeDialog.radioButton_Status1.Checked = true;
                }
                else if (contr.ContractStatus=="исполняется")
                {
                    changeDialog.radioButton_Status2.Checked = true;
                }
                else if(contr.ContractStatus=="исполнен")
                {
                    changeDialog.radioButton_Status3.Checked = true;
               
                }
                else if (contr.ContractStatus == "расторгнут")
                {
                    changeDialog.radioButton_Status4.Checked = true;
                }

                if (changeDialog.ShowDialog() == DialogResult.OK)
                {
                    contr.ContractDate =changeDialog.textBox_ContractDate.Text;
                    contr.ContractNumber = changeDialog.textBox_ContractNumber.Text;
                    contr.ContractPrice = Convert.ToDouble(changeDialog.textBox_ContractPrice.Text);
                    contr.ContractObject = changeDialog.textBox_ContractObject.Text;
                    foreach (RadioButton radio in changeDialog.Controls.OfType<RadioButton>())
                    {
                        if (radio.Checked == true)
                        {
                            contr.ContractStatus = radio.Text;
                        }
                    }
                    var result2 = MessageBox.Show("Вы уверены что хотите сохранить изменения договор?", "Внимание!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Договор изменен");
                    }
                    await gb.SaveChangesAsync();
 

                    ShowCurrentClientContracts();
                }




            }
            
        }
        //events delets contracts
        private async void button_RemoveContrct_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить договор?", "Внимание!", MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            using (var gb = new DBContainer())
            {
                var client=new Client();
                var contr=new Contract();
                client =await gb.ClientSet.FindAsync(FindClientID());
                contr = await gb.ContractSet.FindAsync(FindContractId());
                contr.TypeOfWork.Clear();
                gb.ContractSet.Remove(contr);
                await gb.SaveChangesAsync();
                MessageBox.Show("Договор удален успешно!");
                RefreshClientDataView();
                ShowCurrentClientContracts();
                RefreshContractDataView();

            }

        }
        //AddBank event
        private async void button1_Click(object sender, EventArgs e)
        {
            int id = FindClientID();
           var b=new Bank();
            using (var gb=new DBContainer())
            {               
                var client =await gb.ClientSet.FindAsync(id);
                      
                if ( client.Bank==null )
                {
                    var result = MessageBox.Show("Банк не добавлен, желаете добавить банк?", "Внимание!", MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                    var add=new AddBankDialog();
                    add.Text = "Добавление банка";
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        b.BankName = add.textBox_BankName.Text;
                        b.BankCode = add.textBox_BankCode.Text;
                        b.BankPhonePhax = add.textBox_PhonePhax.Text;
                        b.BankUNN = add.textBox_BankUNN.Text;
                        client.Bank = b;
                       await gb.SaveChangesAsync();
                        MessageBox.Show("Банк добавлен");
                    }
                }
                else
                {
                    var add = new AddBankDialog();
                    add.textBox_BankName.Text = client.Bank.BankName;
                    add.textBox_BankName.Enabled = false;
                    add.textBox_BankCode.Text = client.Bank.BankCode;
                    add.textBox_BankCode.Enabled = false;
                    add.textBox_PhonePhax.Text = client.Bank.BankPhonePhax;
                    add.textBox_PhonePhax.Enabled = false;
                    add.textBox_BankUNN.Text = client.Bank.BankUNN;
                    add.textBox_BankUNN.Enabled = false;
                    add.checkBox_EditBankInfo.Checked = true;
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        client.Bank.BankName = add.textBox_BankName.Text;
                        client.Bank.BankCode = add.textBox_BankCode.Text;
                        client.Bank.BankPhonePhax = add.textBox_PhonePhax.Text;
                        client.Bank.BankUNN = add.textBox_BankUNN.Text;
                        await gb.SaveChangesAsync();                  
                    }

                }
            }

        }

        private void MyFormUserControl1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
