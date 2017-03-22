using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public int FindWorkId()
        {
            int id = 0;
            if (dataGridView_AdWork.SelectedRows.Count > 0)
            {
                int index = dataGridView_AdWork.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView_AdWork[0, index].Value.ToString(), out id);
            }

            return id;

        }
        public MyFormUserControl2()
        {
            InitializeComponent();
        }
        // returns selected ID in contract
       public int FindIDContract() 
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
            try
            {



                Y:
                var type = new TypeOfWork();
                var add = new TypeWorkDialog();
                using (var gb = new DBContainer())
                {


                    var contr = await gb.ContractSet.FindAsync(FindIDContract());

                    add.comboBox_TypesOfWork.Items.AddRange(new[]
                    {"демонтаж", "полы", "стены", "потолки", "электрика", " сантехника", "проемы", "вентиляция"});
                    add.comboBox_TypesOfWork.Refresh();


                    if (add.ShowDialog() == DialogResult.OK)
                    {

                        //type.TypeOfWorkName  =  add.textBox1_TypeWork.Text;
                        type.TypeOfWorkName = add.comboBox_TypesOfWork.Text;
                        var checkType =
                            contr.TypeOfWork.FirstOrDefault(a => a.TypeOfWorkName == add.comboBox_TypesOfWork.Text);
                        if (checkType != null)
                        {
                            MessageBox.Show("Такой вид работы уже внесен!");
                            return;
                        }
                        if (add.comboBox_TypesOfWork.Text.Length == 0)
                        {
                            MessageBox.Show("Поле ПТМ не может быть пустым!");
                            goto Y;
                        }
                        contr.TypeOfWork.Add(type);
                        await gb.SaveChangesAsync();
                        MessageBox.Show("Птм добавлен!");
                        listBox1_TypesOfWork.Items.Add(type.TypeOfWorkName);
                        listBox1_TypesOfWork.Refresh();
                        listBox1_TypesOfWork.SelectedIndex = contr.TypeOfWork.Count - 1;
                    }


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Недопустимое действие!");
                return;
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
                        a => a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString()&& a.ContractContractID==id);
                var worksClear = type.Work;
                worksClear.ToList();
                var work = type.Work.FirstOrDefault(a => a.TypeOfWork == type);



                try
                {
                    var matSum = work.Material.Select(a => a.MaterialAmmount*a.MaterialUnitPrice);
                    foreach (var i in matSum)
                    {
                        contr.ContractPrice -= i;
                    }           
                    var workSum = type.Work.Select(a => a.WorkAmmount*a.WorkUnitPrice);
                    foreach (var i in workSum)
                    {
                        contr.ContractPrice -= i;
                    }
                }
                         catch (Exception)
                { }                              
       
                contr.TypeOfWork.Remove(type);
             var q = from TypeOfWork in gb.TypeOfWorkSet select TypeOfWork;
                q.ToList();          
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
                RefreshContrData(id);
                if (listBox1_TypesOfWork.Items.Count > 0)
                {
                    listBox1_TypesOfWork.SelectedIndex = listBox1_TypesOfWork.Items.Count - 1;
                }
                else
                {
                    dataGridView_AdWork.DataSource=new object();
                    dataGridView_ShowMaterials.DataSource=new object();
                }

               
                



            }
        }
        // event changes selected in listbox typeOfWork data
        private async void button_ChangeTypeOfWork_Click(object sender, EventArgs e)
        {
            try
            {

                var red = new TypeWorkDialog();
                red.Text = "Редактирование";
                int id = FindIDContract();


                using (var gb = new DBContainer())
                {

                    V:
                    var contr = await gb.ContractSet.FindAsync(id);
                    var type =
                        contr.TypeOfWork.FirstOrDefault(
                            a => a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString());
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
                        if (red.comboBox_TypesOfWork.Text.Length == 0)
                        {
                            MessageBox.Show("Поле ПТМ не может быть пустым!");
                            goto V;
                        }
                        await gb.SaveChangesAsync();


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
            catch (Exception)
            {

                MessageBox.Show("Недопустимое действие!");
                return;
            }
        }
        // event adds new work to typeOfWork
        private async void button_AddWork_Click(object sender, EventArgs e)
        {
            try
            {



                m:
                int id = FindIDContract();
                var add = new AddWorkDialog();
                add.Text = "Добавить работу";
                var work = new Work();
                add.comboBox_WorkUnit.Items.AddRange(new[] {"м2", "м3", "шт", "м"});
                using (var gb = new DBContainer())
                {
                    var contr = await gb.ContractSet.FindAsync(id);
                    if (listBox1_TypesOfWork.SelectedItem != null)
                    {
                        var type = await

                            gb.TypeOfWorkSet.FirstOrDefaultAsync(
                                a =>
                                    a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString() &&
                                    a.ContractContractID == id);
                        if (add.ShowDialog() == DialogResult.OK)
                        {
                            work.WorkName = add.textBox1_WorkName.Text;
                            work.WorkAmmount = Convert.ToDouble(add.textBox_WorkAmmount.Text);
                            work.WorkUnit = add.comboBox_WorkUnit.Text;
                            work.WorkUnitPrice = Convert.ToDouble(add.textBox_WorkUnitPrice.Text);

                            if (add.textBox1_WorkName.Text.Length == 0)
                            {
                                MessageBox.Show("Поле наименование работы не может быть пустым!");
                                goto m;
                            }
                            if (add.comboBox_WorkUnit.Text.Length == 0)
                            {
                                MessageBox.Show("Поле ед. изм. не может быть пустым!");
                                goto m;
                            }
                        }
                        type.Work.Add(work);
                        contr.ContractPrice += work.WorkUnitPrice*work.WorkAmmount;
                        await gb.SaveChangesAsync();
                        RefreshWorkData(type);
                    }
                    else
                    {
                        MessageBox.Show("Выберите ПТМ!");
                    }
                    RefreshContrData(id);
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Невозможное действие!");
                //return;
            }

        }
        // change selection index in listbox
        private async void listBox1_TypesOfWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = FindIDContract();
            using (var gb = new DBContainer())
            {
                var contr =await gb.ContractSet.FindAsync(id);
                if (listBox1_TypesOfWork.SelectedItem != null)
                {
                    var type = await

                        gb.TypeOfWorkSet.FirstOrDefaultAsync(
                            a =>
                                a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString() &&
                                a.ContractContractID == id);
                    RefreshWorkData(type);
                }


            }
        }
        // delete work from current type of work
        private async void button1_Click(object sender, EventArgs e)
        {
            int id2 = FindWorkId();
            int id = FindIDContract();
         
            using (var gb = new DBContainer())
            {
                var contr =await gb.ContractSet.FindAsync(id);

                var work = await gb.WorkSet.FindAsync(id2);
         var type =contr.TypeOfWork.FirstOrDefault(a => a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString() && a.ContractContractID == id);
                type.Work.Remove(work);
                contr.ContractPrice -= work.WorkUnitPrice*work.WorkAmmount;
              await  gb.SaveChangesAsync();
                RefreshWorkData(type);
            }

            RefreshContrData(id);
        }

        //method refreshes work data
        public  void RefreshWorkData( TypeOfWork type)
        {
            using (var gb = new DBContainer())
            {
                dataGridView_AdWork.DataSource = type.Work.Select(
            a =>
                new
                {
                    id = a.WorkID,
                    Наименование = a.WorkName,
                    Объем = a.WorkAmmount,
                    Eд = a.WorkUnit,
                    Цена_за_ед = a.WorkUnitPrice,
                    Итого = a.WorkAmmount * a.WorkUnitPrice
                }).ToList();
                dataGridView_AdWork.Columns[0].Visible = false;
                dataGridView_AdWork.Refresh();

            }
            
        }
        // method refreshes contract data after changing work data
        public async void RefreshContrData(int contrId)
        {
            using (var gb=new DBContainer())
            {               
            IQueryable<Contract> query = gb.ContractSet.Where(a => a.ContractID == contrId);
            await query.ToListAsync();
            dataGridView2_Contr.DataSource = await query.Select(a => new
            {
                Id = a.ContractID,
                Номер = a.ContractNumber,
                Объект = a.ContractObject,
                Дата = a.ContractDate,
                Цена = a.ContractPrice,
                Статус = a.ContractStatus
            }).ToListAsync();
            dataGridView2_Contr.Columns[0].Visible = false;
                dataGridView2_Contr.Refresh();
            }

        }
        // method refreshes mat datagrid
       private async void RefreshMatData(int id)
        {
            using (var gb = new DBContainer())
            {
                var work = await gb.WorkSet.FindAsync(id);
                dataGridView_ShowMaterials.DataSource =
                    work.Material.Select(
                        a =>
                            new
                            {
                                id = a.MaterialID,
                                Наименование = a.MaterialName,
                                Количество = a.MaterialAmmount,
                                Ед = a.MaterialUnit,
                                Цена_ед = a.MaterialUnitPrice,
                                Итого = a.MaterialAmmount*a.MaterialUnitPrice
                            }).ToList();
                dataGridView_ShowMaterials.Columns[0].Visible = false;
             
                dataGridView_ShowMaterials.Refresh();
            }
        }
        // event changes Work data
        private async void button_ChangeWork_Click(object sender, EventArgs e)
        {
            int id = FindWorkId();
            var ch =new AddWorkDialog();
            ch.Text = "Редактирование работы";
            int id2 = FindIDContract();
            using (var gb = new DBContainer())
            {
                var contr = await gb.ContractSet.FindAsync(id2);
                var type = contr.TypeOfWork.FirstOrDefault(a => a.TypeOfWorkName == listBox1_TypesOfWork.SelectedItem.ToString() && a.ContractContractID == id2);
              
                var work =await gb.WorkSet.FindAsync(id);
                ch.comboBox_WorkUnit.Text = work.WorkUnit;
                ch.textBox1_WorkName.Text = work.WorkName;
                ch.textBox_WorkAmmount.Text = work.WorkAmmount.ToString();
                ch.textBox_WorkUnitPrice.Text = work.WorkUnitPrice.ToString();
                double x = work.WorkAmmount*work.WorkUnitPrice;
                contr.ContractPrice -= x;
                if (ch.ShowDialog() == DialogResult.OK)
                {
                    work.WorkName = ch.textBox1_WorkName.Text;
                    work.WorkAmmount = Convert.ToDouble(ch.textBox_WorkAmmount.Text);
                    work.WorkUnit = ch.comboBox_WorkUnit.Text;
                    work.WorkUnitPrice = Convert.ToDouble(ch.textBox_WorkUnitPrice.Text);
                    double y = work.WorkAmmount*work.WorkUnitPrice;
                    contr.ContractPrice += y;
                }
              await  gb.SaveChangesAsync();
                RefreshContrData(id2);
                RefreshWorkData(type);



            }

        }
        // event adds new material to work
        private async void button_AddMaterial_Click(object sender, EventArgs e)
        {
            try
            {



                p:
                int id = FindWorkId();
                int idContr = FindIDContract();
                var add = new AddMaterialDialog();
                add.Text = "Добавить материал";
                add.comboBox_MaterialUnit.Items.AddRange(new[] {"кг", "т", "м.п.", "м2", "м3", "шт"});
                var mat = new Material();
                using (var gb = new DBContainer())
                {
                    var contr = await gb.ContractSet.FindAsync(idContr);
                    var work = await gb.WorkSet.FindAsync(id);
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        mat.MaterialName = add.textBox_MaterialName.Text;
                        mat.MaterialAmmount = Convert.ToDouble(add.textBox_MaterialAmmount.Text);
                        mat.MaterialUnit = add.comboBox_MaterialUnit.Text;
                        mat.MaterialUnitPrice = Convert.ToDouble(add.textBox_MaterialUnitPrice.Text);
                        if (add.textBox_MaterialName.Text.Length == 0)
                        {
                            MessageBox.Show("Поле наименование материала не может быть пустым!");
                            goto p;
                        }
                        if (add.comboBox_MaterialUnit.Text.Length == 0)
                        {
                            MessageBox.Show("Поле ед. изм. не может быть пустым!");
                            goto p;
                        }
                    }

                    work.Material.Add(mat);
                    contr.ContractPrice += mat.MaterialUnitPrice*mat.MaterialAmmount;
                    await gb.SaveChangesAsync();
                    RefreshMatData(id);
                    RefreshContrData(idContr);
                }
            }
            catch (Exception)
            {

            }

        }
        // event delets material from work
        private async void button_DeleteMaterial_Click(object sender, EventArgs e)
        {
            int idContr = FindIDContract();
            int workId = FindWorkId();
            int matID = FindMatId();
            using (var gb = new DBContainer())
            {
                var contr = await gb.ContractSet.FindAsync(idContr);
                var work = await gb.WorkSet.FindAsync(workId);
                var mat =await gb.MaterialSet.FindAsync(matID);

                work.Material.Remove(mat);
                contr.ContractPrice -= mat.MaterialUnitPrice*mat.MaterialAmmount;
               await gb.SaveChangesAsync();
                RefreshMatData(workId);
                RefreshContrData(idContr);


            }

        }
        // method finds material ID
        public int FindMatId()
        {
            int id = 0;
            if (dataGridView_ShowMaterials.SelectedRows.Count > 0)
            {
                int index = dataGridView_ShowMaterials.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView_ShowMaterials[0, index].Value.ToString(), out id);
            }

            return id;
        }

        private async void button_ChangeMat_Click(object sender, EventArgs e)
        {
            int idWork = FindWorkId();
            int idContr = FindIDContract();
            int idMat = FindMatId();
            var ch = new AddMaterialDialog();
           ch.Text = "Редактирование материала";
            ch.comboBox_MaterialUnit.Items.AddRange(new[] { "кг", "т", "м.п.", "м2", "м3", "шт" });
            using (var gb = new DBContainer())
            {
                var contr = await gb.ContractSet.FindAsync(idContr);
                var mat = await gb.MaterialSet.FindAsync(idMat);
                  ch.textBox_MaterialName.Text=mat.MaterialName;
                 ch.textBox_MaterialAmmount.Text= mat.MaterialAmmount.ToString();
                ch.comboBox_MaterialUnit.Text = mat.MaterialUnit;
                ch.textBox_MaterialUnitPrice.Text= mat.MaterialUnitPrice.ToString();
                double x = mat.MaterialAmmount*mat.MaterialUnitPrice;
                contr.ContractPrice -= x;
                if (ch.ShowDialog() == DialogResult.OK)
                {
                    mat.MaterialName = ch.textBox_MaterialName.Text;
                    mat.MaterialAmmount = Convert.ToDouble(ch.textBox_MaterialAmmount.Text);
                    mat.MaterialUnit = ch.comboBox_MaterialUnit.Text;
                    mat.MaterialUnitPrice = Convert.ToDouble(ch.textBox_MaterialUnitPrice.Text);
                }
                contr.ContractPrice += mat.MaterialUnitPrice * mat.MaterialAmmount;
                await gb.SaveChangesAsync();
                RefreshMatData(idMat);
                RefreshContrData(idContr);

            }
        }

        private async void dataGridView_ShowMaterials_SelectionChanged(object sender, EventArgs e)
        {
        
        }

        private async void dataGridView_AdWork_SelectionChanged(object sender, EventArgs e)
        {
            int workId = FindWorkId();
            using (var gb = new DBContainer())
            {
                var work = await gb.WorkSet.FindAsync(workId);
                if (work != null)
                {
                    RefreshMatData(workId);
                }
                else
                {

                    var w = new Work();
                    w = gb.WorkSet.First(a => a.WorkID >= 0);
                   RefreshMatData(w.WorkID);
              
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
