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
    public partial class MyFormUserControl1 : UserControl
    {
        // method refresh ClientDatagrid
        private async void RefreshClientDataView()
        {
            using (var gb = new DBContainer())
            {
                dataGridView1_Client.DataSource =
               await gb.ClientSet.Select(a => new { id = a.ClientID, ФИО = a.ClientName, Адрес = a.ClientAdress, УНН = a.ClientUNN, Пасспорт = a.ClientPassport, Тел_Факс = a.ClientPhonePhax })
                        .ToListAsync();
                dataGridView1_Client.Columns[0].Visible = false;
              
            }

        }
        // method returns client ID
        private int FindClientID()
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
            var add = new ClientDialog();
            using (var gb = new DBContainer())
            {
                var client=new Client();
                if (add.ShowDialog() == DialogResult.OK)
                {
                    client.ClientUNN = add.textBox_ClientUNN.Text;
                    client.ClientPassport = add.textBox_ClientPassport.Text;
                    client.ClientPhonePhax = add.textBox_ClintPhone.Text;
                    client.ClientAdress = add.textBox1_ClientAdress.Text;
                    client.ClientName = add.textBox1_ClientName.Text;
                    if (  await      gb.ClientSet.FirstOrDefaultAsync(
            a => a.ClientUNN == client.ClientUNN && a.ClientPassport == client.ClientPassport) != null)
                    {
                        MessageBox.Show("Такой клиент есть в базе!");
                        return;
                    }
                    gb.ClientSet.Add(client);
                    await  gb.SaveChangesAsync();
                    MessageBox.Show("Клиент успешно добавлен!");
                    RefreshClientDataView();
                }


            }
        }
    }
}
