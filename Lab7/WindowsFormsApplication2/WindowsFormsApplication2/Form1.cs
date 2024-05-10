using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=WIN-PDT5R8H09U0\SQLEXPRESS01; Initial Catalog = master; Integrated Security=True");
        

        Char[] separators = { ';' };
        Dictionary<String, Table> tables = new Dictionary<String, Table>();
        public Form1()
        {
            InitializeComponent();
            initTables();
        }


        private void initTables()
        {
            // Заявки
            this.tables.Add("Заявки", new Table
            {
                Name = "Заявки",
                Fields = new[] { "NumberClaim", "Name", "Phone", "Receipt", "Bank", "Account", "Address", "District", "DateStart", "Document", "Speed", "DateStop", "Cost" },
                Args = new[] { "@NumberClaim", "@Name", "@Phone", "@Receipt", "@Bank", "@Account", "@Address", "@District", "@DateStart", "@Document", "@Speed", "@DateStop", "@Cost" },
                Defaults = new[] { "", "", "", "0", "", "", "", "", "", "", "0", "NULL", "0" },
                FormatDelegates = (List<String> res, SqlDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("NumberClaim")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Name")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Phone")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Receipt")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Bank")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Account")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Address")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("District")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("DateStart")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Document")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Speed")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("DateStop")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Cost")).ToString());
                }
            });

            // Выдача
            this.tables.Add("Выдача", new Table
            {
                Name = "Выдача",
                Fields = new[] { "NumberClaim", "Finish" },
                Args = new[] { "@NumberClaim", "@Finish" },
                Defaults = new[] { "", "0" },
                FormatDelegates = (List<String> res, SqlDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("NumberClaim")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Finish")).ToString());
                }
            });

            // Выход_техника
            this.tables.Add("Выход_техника", new Table
            {
                Name = "Выход_техника",
                Fields = new[] { "NumberClaim", "Inspector", "Time" },
                Args = new[] { "@NumberClaim", "@Inspector", "@Time" },
                Defaults = new[] { "", "", "" },
                FormatDelegates = (List<String> res, SqlDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("NumberClaim")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Inspector")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Time")).ToString());
                }
            });

            // Исполнение
            this.tables.Add("Исполнение", new Table
            {
                Name = "Исполнение",
                Fields = new[] { "NumberClaim", "Chief", "Worker", "DateWorker", "Helper" },
                Args = new[] { "@NumberClaim", "@Chief", "@Worker", "@DateWorker", "@Helper" },
                Defaults = new[] { "", "", "", "", "" },
                FormatDelegates = (List<String> res, SqlDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("NumberClaim")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Chief")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Worker")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("DateWorker")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Helper")).ToString());
                }
            });

            // Оплата
            this.tables.Add("Оплата", new Table
            {
                Name = "Оплата",
                Fields = new[] { "NumberClaim", "Cash", "DateCost", "Value" },
                Args = new[] { "@NumberClaim", "@Cash", "@DateCost", "@Value" },
                Defaults = new[] { "", "0", "", "0" },
                FormatDelegates = (List<String> res, SqlDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("NumberClaim")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Cash")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("DateCost")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Value")).ToString());
                }
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private List<String> Get_From_Table(String tableName, formatRequestResult format, SqlCommand cmd)
        {
            List<String> res = new List<String>();

            try
            {



                cn.Open();
                if (cmd == null)
                    cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandText =
                "SELECT * FROM ";
                cmd.CommandText += tableName;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                label1.Text = "successfully";
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }

            return res;
        }
        private String getSelectedTable()
        {
            if (Dogovor.Checked)
                return "Заявки";
            else if (Magazin.Checked)
                return "Выдача";
            else if (Otdel.Checked)
                return "Выход_техника";
            else if (Postavshik.Checked)
                return "Исполнение";
            else if (Sotrudnik.Checked)
                return "Оплата";

            return "";
        }

        private String formatArgs(String[] list)
        {
            String format = "";
            for (int i = 0; i < list.Length - 1; i++)
                format += list[i] + ", ";
            format += list[list.Length - 1];

            return format;
        }
        private void Add_new(String text, Table table)
        {
            cn.Open();
            try
            {
                String[] subs = text.Split(this.separators);
                if (subs.Length > table.Args.Length)
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO " + table.Name + "(" + formatArgs(table.Fields) + ")";
                cmd.CommandText += "VALUES (" + formatArgs(table.Args) + ")";
                for (int i = 0; i < subs.Length; i++)
                    cmd.Parameters.AddWithValue(table.Args[i], subs[i]);
                for (int i = subs.Length; i < table.Args.Length; i++)
                    cmd.Parameters.AddWithValue(table.Args[i], table.Defaults[i]);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void Delete_Employee(String id, Table table)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM " + table.Name + " WHERE " + table.Fields[0] + " = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void Update(String text, Table table)
        {
            cn.Open();
            try
            {
                String[] subs = text.Split(this.separators);
                if (subs.Length > table.Args.Length)
                    return;

                String id = subs[0];
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE " + table.Name + " SET ";
                for (int i = 1; i < subs.Length - 1; i++)
                {
                    if (subs[i] != "")
                    {
                        String value = "@Value" + i.ToString();
                        cmd.CommandText += table.Fields[i] + " = " + value + ", ";
                        cmd.Parameters.AddWithValue(value, subs[i]);
                    }
                }
                cmd.CommandText += table.Fields[subs.Length - 1] + " = @LastValue";
                cmd.Parameters.AddWithValue("@LastValue", subs[subs.Length - 1]);
                cmd.CommandText += " WHERE " + table.Fields[0] + " = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                label1.Text = "successfuly";
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listBox1.Items.Clear();
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                foreach (String i in Get_From_Table(selectedTable, this.tables[selectedTable].FormatDelegates, null))
                    listBox1.Items.Add(i);
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Add_new(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Delete_Employee(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Update(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }

       
        private List<String> Get_Sys()
        {
            cn.Open();
            List<String> res = new List<String>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM MSysObjects";

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        res.Add(rd.GetValue(rd.GetOrdinal("Name")).ToString() + "; " +
                        rd.GetValue(rd.GetOrdinal("Type")).ToString());
                    }
                }
                else
                {
                    res.Add("-");
                }
                label1.Text = "successfully";
            }

            finally
            {
                cn.Close();
            }
            return res;
        }
        private void sysreq_Click(object sender, EventArgs e)
        {
            foreach (String i in Get_Sys())
                listBox1.Items.Add(i);
        }


        private void add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                string query = "select * from Врач";
                command.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            catch
            {

            }
        }
    }
    public delegate void formatRequestResult(List<String> res, SqlDataReader rd);
    public class Table
    {
        String name = "";
        String[] fields;
        String[] args;
        String[] defaults;
        formatRequestResult formatsDelegates;

        public String Name { get; set; }
        public String[] Fields { get; set; }
        public String[] Args { get; set; }
        public String[] Defaults { get; set; }
        public formatRequestResult FormatDelegates { get; set; }
    }
}
