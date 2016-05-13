using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var txtvalue = rich1.Text;
            //rich1.Text = "";
            //txtvalue = txtvalue.Replace("\n", "','");
            //txtvalue = "'" + txtvalue + "'";
            //rich1.Text = txtvalue;
            var txtvalue = rich1.Text;
            txtvalue = txtvalue.Replace("\n", ";");
            var ilist = txtvalue.Split(';');
            var tempsql = @"  INSERT INTO dbo.Atg_BlockList
          ( CellPhone ,
            UserName ,
            Isforever ,
            CreateTime 
          )VALUES ";
            var num = 0;
            foreach (var item in ilist)
            {
                if (item == "") continue;
                var UserName = item.Substring(0, item.IndexOf("\t")).Trim();//用户名
                var CellPhone = item.Substring(item.IndexOf("\t") + 1).Trim();//联系方式
                tempsql += @"('" + CellPhone + "','" + UserName + "'," + 1 + ",'" + DateTime.Now + "'),";
                num += 1;
            }
            tempsql = tempsql.Substring(0, tempsql.LastIndexOf(",")) + ";";
            rich2.Text = tempsql;
        }
    }
}
