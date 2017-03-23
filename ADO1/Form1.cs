using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ADO1
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            //OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            //bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            //bldr.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            try
            {
                con.Open();
                buttonCommand.Enabled = true;
                cmd = con.CreateCommand();
                cmd.Parameters.Add("AGR", OleDbType.Integer);
                String artgr = textBoxArtGruppe.Text;
                cmd.CommandText = "Select * from tArtikel Where ArtikelGruppe = AGR";
                cmd.CommandType = CommandType.Text;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd.Parameters["AGR"].Value = textBoxArtGruppe.Text;
                reader = cmd.ExecuteReader();
                buttonRead.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBoxAusgabe.Items.Clear();
            while(reader.Read())
            {
                //Artikel a = mkArtikelObject(reader);
                listBoxAusgabe.Items.Add(mkArtikelObject(reader));
            }
            reader.Close();
        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            // weiterer Code
            int i = 0;
            a.ArtikelOid =  Convert.ToInt32( reader[i++]);
            if(reader[i] == DBNull.Value)
            {
                a.ArtikelNr = 0;
            }
            else
            {
                a.ArtikelNr = Convert.ToInt32(reader[i++].ToString());
            }
            if (reader[i] != DBNull.Value)
            {
                a.ArtielGruppe = Convert.ToInt32(reader[i++]);
            }
            a.Bezeichnung = reader[i++].ToString();
            if (reader[i] != DBNull.Value)
            {
                a.Bestand = Convert.ToByte(reader[i++]);
            }
            if (reader[i] != DBNull.Value)
            {
                a.Meldebestand = Convert.ToInt16(reader[i++]);
            }
            if (reader[i] != DBNull.Value)
            {
                a.Verpackung = Convert.ToInt16(reader[i++]);
            }
            if (reader[i] != DBNull.Value)
            {
                a.VkPreis = Convert.ToDecimal(reader[i++]);
            }
            if (reader[i] != DBNull.Value)
            {
                a.LetzteEntnahme = Convert.ToDateTime(reader[i++]);
            }
           

            return a;

        }
    }
}
