using System.ComponentModel;
using System.IO;

namespace GridTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "test.xml")))
            {
                gridControl1.MainView.RestoreLayoutFromXml(Path.Combine(Environment.CurrentDirectory, "test.xml"));
            }

            gridControl1.DataSource = GetDatas();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            gridControl1.MainView.SaveLayoutToXml(Path.Combine(Environment.CurrentDirectory, "test.xml"));
            base.OnClosing(e);
        }

        private List<Data> GetDatas()
        {
            var list = new List<Data>();
            for (int i = 0; i < 10; i++)
            {
                //list.Add(new Data() { Id = i, Description = new DataSub() { Id = i, Name = i.ToString()}, Name = i.ToString() });
                list.Add(new Data() { Id = i, Description =i.ToString(), Name = i.ToString() });
            }
            list.Add(new Data() { Id = 11, Name = "11", Description = null });
            return list;
        }

       
    }
}