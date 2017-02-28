using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDataBaseLibrary;
using DialogFormLibrary;

namespace UserControlLibrary
{
    public partial class MyFormUserControl2 : UserControl
    {
        public MyFormUserControl2()
        {
            InitializeComponent();
        }
        // returns selected ID in contract
        private int FindIDContract() 
        {
            int id = 0;
            if (dataGridView2_Contr.SelectedRows.Count > 0)
            {
                int index = dataGridView2_Contr.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView2_Contr[0, index].Value.ToString(), out id);
            }

            return id;
        }
        // method adds types of work
        private async void button_AddTypeWork_Click(object sender, EventArgs e)
        {
            var type=new TypeOfWork();
            var add = new TypeWorkDialog();
            using (var gb = new DBContainer())
            {
                var types =await  gb.TypeOfWorkSet.Select(a => a.TypeOfWorkName).ToListAsync();
                var contr =await gb.ContractSet.FindAsync(FindIDContract());
                
                    foreach (var i in types.Distinct())
                    {
                      add.comboBox_TypesOfWork.Items.Add(i);  
                    }
                    add.comboBox_TypesOfWork.Refresh();
               
               
                if (add.ShowDialog() == DialogResult.OK)
                {
                    
                 //type.TypeOfWorkName  =  add.textBox1_TypeWork.Text;
                    type.TypeOfWorkName = add.comboBox_TypesOfWork.Text;
                    var checkType = contr.TypeOfWork.FirstOrDefault(a => a.TypeOfWorkName == add.comboBox_TypesOfWork.Text);
                    if (checkType != null)
                    {
                        MessageBox.Show("Такой вид работы уже внесен!");
                       return;
                    }
                   
                    contr.TypeOfWork.Add(type);
                 await   gb.SaveChangesAsync();
                    MessageBox.Show("Птм добавлен!");
                    listBox1_TypesOfWork.Items.Add(type.TypeOfWorkName);
                    listBox1_TypesOfWork.Refresh();
                }


            }


        }

        private void MyFormUserControl2_Load(object sender, EventArgs e)
        {
           
        }
        // event delets TypeOfWork from contract
        private async void button_DeleteWorkType_Click(object sender, EventArgs e)
        {
            int id = FindIDContract();
            using (var gb = new DBContainer())
            {
                var contr =await gb.ContractSet.FindAsync(id);
                var type =
                    contr.TypeOfWork.FirstOrDefault(
                        a => a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString());
                var worksClear = type.Work;
                worksClear.ToList();
                var work = type.Work.FirstOrDefault(a => a.TypeOfWork == type);
                //var matClear = work.Material;
                //matClear.ToList();
                //work.Material.Clear();
                //gb.MaterialSet.RemoveRange(matClear);
                //type.Work.Clear();
                //gb.WorkSet.RemoveRange(worksClear);
                //gb.TypeOfWorkSet.Remove(type);
                contr.TypeOfWork.Remove(type);
            await    gb.SaveChangesAsync();
                listBox1_TypesOfWork.Items.Clear();
                var typeQuery = from TypeOfWork in gb.TypeOfWorkSet
                                where TypeOfWork.ContractContractID == id
                                select TypeOfWork;
                typeQuery.ToList();
                foreach (var i in typeQuery)
                {
                   listBox1_TypesOfWork.Items.Add(i.TypeOfWorkName);
                }
               listBox1_TypesOfWork.Refresh();




            }
        }
        // event changes selected in listbox typeOfWork data
        private async void button_ChangeTypeOfWork_Click(object sender, EventArgs e)
        {
            var red = new TypeWorkDialog();
            red.Text = "Редактирование";
            int id = FindIDContract();
           

            using (var gb = new DBContainer())
            {
                
                var contr =await gb.ContractSet.FindAsync(id);
                var type=contr.TypeOfWork.FirstOrDefault(a=>a.TypeOfWorkName==listBox1_TypesOfWork.SelectedItem.ToString());
                red.comboBox_TypesOfWork.Text = type.TypeOfWorkName;
                if (red.ShowDialog() == DialogResult.OK)
                {
                   
                    type.TypeOfWorkName = red.comboBox_TypesOfWork.Text;
                    var typeCheck =
                        contr.TypeOfWork.FirstOrDefault(a => a.TypeOfWorkName == red.comboBox_TypesOfWork.Text);
                    if (typeCheck != null)
                    {
                        MessageBox.Show("Такой вид работ уже внесен");
                        return;
                        

                    }
                  await  gb.SaveChangesAsync();


                }
                listBox1_TypesOfWork.Items.Clear();
                var typeQuery = from TypeOfWork in gb.TypeOfWorkSet
                                where TypeOfWork.ContractContractID == id
                                select TypeOfWork;
                typeQuery.ToList();
                foreach (var i in typeQuery)
                {
                    listBox1_TypesOfWork.Items.Add(i.TypeOfWorkName);
                }
                listBox1_TypesOfWork.Refresh();


            }
        }
    }
}
