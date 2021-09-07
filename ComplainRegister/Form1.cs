using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace ComplainRegister
{
    public partial class Form1 : Form
    {
        Point lastClick;
        string currentUser;
        static string path = Application.StartupPath;
        public string conString = "Data Source=DESKTOP-CT235QF;Initial Catalog=coomplain;Integrated Security=True";
        public bool deleteClicked;
        int CompID;

        SqlDataAdapter adap;
        static bool phoneEmailEdited = false;
        public Form1()
        {
            InitializeComponent();
            addTechListItems();
            addEngListItems();
            clientNameComboItems();
            ClientBasicInfo();
            searchNameAutoComplete();
            statusCombo.SelectedIndex = 0;
            if (cNameCombo.SelectedItem.ToString() == "New Client")
            {
                phone.Enabled = true;
                email.Enabled = true;
                cityregion.Enabled = true;
                cNameCombo.DropDownStyle = ComboBoxStyle.DropDown;
                cNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cNameCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        public Form1(string currentUser)
        {
            InitializeComponent();
            ChangeUserPass.Show();
            this.currentUser = currentUser;
            addTechListItems();
            addEngListItems();
            clientNameComboItems();
            ClientBasicInfo();
            searchNameAutoComplete();
            statusCombo.SelectedIndex = 0;
            if (cNameCombo.SelectedItem.ToString() == "New Client")
            {
                phone.Enabled = true;
                email.Enabled = true;
                cityregion.Enabled = true;
                cNameCombo.DropDownStyle = ComboBoxStyle.DropDown;
                cNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cNameCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }

        }


        private void searchNameAutoComplete()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM ComplainDetails";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cNameSearch.AutoCompleteCustomSource.Add(dr["ClientName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", (float)13.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        //error
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            techCombo.Items.Add(techList.SelectedItem);
            techList.Items.Remove(techList.SelectedItem);

            try
            {
                engCombo.Items.Add(engList.SelectedItem);
                engList.Items.Remove(engList.SelectedItem);
                if (engCombo.Items.Count != 0)
                {
                    engCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "No engineers were selected.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                System.Console.WriteLine(ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                techCombo.Items.Add(techList.SelectedItem);
                techList.Items.Remove(techList.SelectedItem);
                if (techCombo.Items.Count != 0)
                {
                    techCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "No engineers were selected.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                System.Console.WriteLine(ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogOutMessageBox log = new LogOutMessageBox();
            log.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {


            if (phone.Text == "" || cityregion.Text == "" || detailsText.Text == "" || email.Text == "" || productText.Text == "")
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.Show();
                log.makeOkButton("A required field is empty.");
                log.Location = new Point(log.Location.X + 10, log.Location.Y);


            }
            else
            {

                ConnectionClass cc = new ConnectionClass();
                if (cNameCombo.Text != "New Client")
                {
                    cNameCombo.SelectedItem = cNameCombo.Text;
                    cNameCombo.Items.Add(cNameCombo.Text);
                    cc.addComplain(cNameCombo.Text, detailsText.Text, productText.Text, dateTimePicker1.Text, statusCombo.SelectedItem.ToString(), techniciansString(), engineersString(), cityregion.Text);
                    cc.addClientDetails(cNameCombo.Text, phone.Text, email.Text, cityregion.Text, phoneEmailEdited, doesClientExist());
                    phone.Clear();
                    cityregion.Clear();
                    detailsText.Clear();
                    email.Clear();
                    productText.Clear();
                    for (int i = 0; i < techList.Items.Count; i++)
                    {
                        techCombo.Items.Add(techList.Items[i]);

                    }
                    techList.Items.Clear();
                    for (int i = 0; i < engList.Items.Count; i++)
                    {
                        engCombo.Items.Add(engList.Items[i]);

                    }
                    engList.Items.Clear();
                    cNameCombo.SelectedItem = "New Client";
                    this.Refresh();
                }
                else if (cNameCombo.Text == "New Client")
                {
                    LogOutMessageBox log1 = new LogOutMessageBox();
                    log1.Show();
                    log1.makeOkButton("Invalid client name.");
                }


            }
        }
        public bool doesClientExist()
        {
            bool x = false;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string sql = "SELECT * FROM ClientDetail";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (cNameCombo.SelectedItem != null)
                    {
                        if (cNameCombo.SelectedItem.ToString() == dr["ClientName"].ToString() || cNameCombo.SelectedText == dr["ClientName"].ToString())
                        {
                            x = true;
                        }
                    }
                    else
                    {
                        if (cNameCombo.SelectedText == dr["ClientName"].ToString())
                        {
                            x = true;
                        }
                    }
                }
            }
            catch
            {

            }
            return x;
        }

        public void addTechListItems()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM Technicians ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        techCombo.Items.Add(dr["Name"].ToString());
                    }
                    techCombo.SelectedIndex = 0;
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public void addEngListItems()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM Engineers ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        engCombo.Items.Add(dr["Name"].ToString());
                    }
                    engCombo.SelectedIndex = 0;
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        private void techCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                techList.Items.Add(techCombo.SelectedItem);
                techCombo.Items.Remove(techCombo.SelectedItem);
                if (techCombo.Items.Count > 1)
                {
                    techCombo.SelectedIndex += 1;
                }
            }
            catch { }

        }

        private void engCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                engList.Items.Add(engCombo.SelectedItem);
                engCombo.Items.Remove(engCombo.SelectedItem);
                if (engCombo.Items.Count > 1)
                {
                    engCombo.SelectedIndex += 1;
                }
            }
            catch { }
        }
        public void operatorLogin()
        {
            pictureBox1.Size = new Size(162, 653);
            pictureBox1.Location = new Point(5, 91);
            tabPage3.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
            
                //////dataGridView1.Rows.Clear();
            }
            catch
            {

            }
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    if (compIDSearch.Text == "" && cNameSearch.Text == "" && cityRegionSearch.Text == "" && statusSearch.Text == "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results have been found.");
                            log.Show();
                        }

                    }
                    if (compIDSearch.Text == "" && cNameSearch.Text != "" && cityRegionSearch.Text == "" && statusSearch.Text == "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE ClientName='" + cNameSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }

                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text == "" && cityRegionSearch.Text == "" && statusSearch.Text == "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text != "" && cityRegionSearch.Text == "" && statusSearch.Text == "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE ClientName='" + cNameSearch.Text + "' AND ComplaintID='" + compIDSearch.Text
                                + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text == "" && cityRegionSearch.Text != "" && statusSearch.Text == "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE CityRegion='" + cityRegionSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        // Got it? Okay let me know if anything else needed
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text != "" && cityRegionSearch.Text != "" && statusSearch.Text == "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE ClientName='" + cNameSearch.Text + "' AND CityRegion='" + cityRegionSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text != "" && cityRegionSearch.Text != "" && statusSearch.Text == "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE ClientName='" + cNameSearch.Text + "' AND ComplaintID='" + compIDSearch.Text + "'AND CityRegion='" + cityRegionSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text == "" && cityRegionSearch.Text != "" && statusSearch.Text == "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE CityRegion='" + cityRegionSearch.Text + "' AND ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text == "" && cityRegionSearch.Text == "" && statusSearch.Text != "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text == "" && cityRegionSearch.Text != "" && statusSearch.Text != "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND CityRegion='" + cityRegionSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text != "" && cityRegionSearch.Text != "" && statusSearch.Text != "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND CityRegion='" + cityRegionSearch.Text + "' AND ClientName='" + cNameSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text != "" && cityRegionSearch.Text != "" && statusSearch.Text != "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND CityRegion='" + cityRegionSearch.Text + "' AND ClientName='" + cNameSearch.Text + "'  AND ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text != "" && cityRegionSearch.Text == "" && statusSearch.Text != "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND ClientName='" + cNameSearch.Text + "'  AND ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text == "" && cityRegionSearch.Text != "" && statusSearch.Text != "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND CityRegion='" + cityRegionSearch.Text + "' AND ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text != "" && cNameSearch.Text == "" && cityRegionSearch.Text == "" && statusSearch.Text != "")
                    {
                        try
                        {
                            adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND ComplaintID='" + compIDSearch.Text + "'", con);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count < 1)
                            {
                                LogOutMessageBox log = new LogOutMessageBox();
                                log.makeOkButton("    No results match your query.");
                                log.Show();
                            }
                        }
                        catch
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }
                    else if (compIDSearch.Text == "" && cNameSearch.Text != "" && cityRegionSearch.Text == "" && statusSearch.Text != "")
                    {
                        adap = new SqlDataAdapter("SELECT * FROM ComplainDetails WHERE Status='" + statusSearch.Text + "' AND ClientName='" + cNameSearch.Text + "'", con);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dt.Rows.Count < 1)
                        {
                            LogOutMessageBox log = new LogOutMessageBox();
                            log.makeOkButton("    No results match your query.");
                            log.Show();
                        }
                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string techniciansString()
        {
            string S = "";
            int count = 0;
            try
            {
                for (int i = 0; i < techList.Items.Count; i++)
                {
                    if (count == 0)
                    {
                        S += techList.Items[i];
                    }
                    else
                    {
                        S = S + "," + techList.Items[i];
                    }
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return S;
        }
        public string engineersString()
        {
            string S = "";
            int count = 0;
            try
            {
                for (int i = 0; i < engList.Items.Count; i++)
                {

                    if (count == 0)
                    {
                        S += engList.Items[i];
                    }
                    else
                    {
                        S = S + "," + engList.Items[i];
                    }
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return S;
        }
        public void clientNameComboItems()
        {
            cNameCombo.Items.Add("New Client");
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM ClientDetail";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cNameCombo.Items.Add(dr["ClientName"].ToString());
                    }
                }

                cNameCombo.SelectedIndex = 0;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cNameCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cNameCombo.SelectedItem.ToString() == "New Client")
            {
                phone.Enabled = true;
                email.Enabled = true;
                cityregion.Enabled = true;
                cNameCombo.DropDownStyle = ComboBoxStyle.DropDown;
                cNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cNameCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            else
            {
                phone.Enabled = false;
                email.Enabled = false;
                cityregion.Enabled = false;
                cNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                cNameCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cNameCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            ClientBasicInfo();

        }

        private void ClientBasicInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM ClientDetail";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["ClientName"].ToString() == cNameCombo.SelectedItem.ToString())
                        {

                            phone.Text = dr["Contact"].ToString();
                            email.Text = dr["Email"].ToString();
                            cityregion.Text = dr["CityRegion"].ToString();
                            break;
                        }
                        else
                        {
                            phone.Clear();
                            email.Clear();
                            cityregion.Clear();
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void viewComplaint(Complaint c, string eml, string phne)
        {
            string[] currentTech = null;
            string[] currentEng = null;
            for (int i = 0; i < techList.Items.Count; i++)
            {
                techCombo.Items.Add(techList.Items[0]);
                techList.Items.RemoveAt(0);
            }
            for (int i = 0; i < engList.Items.Count; i++)
            {
                engCombo.Items.Add(engList.Items[0]);
                engList.Items.RemoveAt(0);
            }
            cNameCombo.SelectedItem = c.ClientName;
            productText.Text = c.Product;
            detailsText.Text = c.Details;
            dateTimePicker1.Text = c.Date;
            cityregion.Text = c.CityRegion;
            email.Text = c.Email;
            phone.Text = c.Contact;
            statusCombo.SelectedItem = c.Status;
            currentTech = c.Technicians.Split(',');
            for (int i = 0; i < currentTech.Length; i++)
            {
                techList.Items.Add(currentTech[i]);
                techCombo.Items.Remove(currentTech[i]);
            }
            currentEng = c.Engineers.Split(',');
            for (int i = 0; i < currentEng.Length; i++)
            {
                engList.Items.Add(currentEng[i]);
                engCombo.Items.Remove(currentEng[i]);
            }
            tabControl1.SelectedTab = tabPage1;
            //tabControl1.SelectedTab = tabPage1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SubmitButton.Hide();
            UpdateButton.Show();
            CancelButton.Show();
            RegisterHeading.Text = "View/Edit Complaint";
            techList.Items.Clear();
            engList.Items.Clear();
            techCombo.Items.Clear();
            engCombo.Items.Clear();
            addEngListItems();
            addTechListItems();
            cNameCombo.Enabled = false;
            phone.Enabled = false;
            email.Enabled = false;


            string cname, prdct, dtails, dte, ctyrgn, eml = "", phne = "", stts, technicians, engineers;
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    CompID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    cname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    dtails = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    dte = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    stts = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    technicians = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    engineers = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    prdct = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    ctyrgn = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    string sql = "SELECT * FROM ClientDetail WHERE ClientName='" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        eml = dr["Email"].ToString();
                        phne = dr["Contact"].ToString();
                    }


                    Complaint C = new Complaint(cname, phne, dtails, prdct, dte, stts, engineers, technicians, ctyrgn, eml);
                    viewComplaint(C, eml, phne);
                    pictureBox1.Location = new Point(5, 68);
                    pictureBox1.Size = new Size(162, 676);
                    tabControl1.TabPages.Remove(tabControl1);
                    tabControl1.TabPages.Remove(tabControl1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count == 0)
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.makeOkButton("No complaint was selected.");
                log.Show();
            }
            else
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.makeOkButton("Please search and select a complaint.");
                log.Show();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string compID;
            try
            {
                string stts = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                compID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (stts != "Completed")
                {
                    string sql = "UPDATE ComplainDetails SET Status='Completed' WHERE ComplaintID='" + compID + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("Status updated successfully.");
                    log.Show();
                    this.Refresh();
                }
                else
                {
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("Status already updated.");
                    log.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this complaint?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string compID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    string sql = "DELETE FROM ComplainDetails WHERE ComplaintID='" + compID + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Complain deleted");
                    con.Close();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());

                }
            }
        }

        private void newPass_Enter(object sender, EventArgs e)
        {
            string user = userChangePass.Text;
            string pass = oldPass.Text;
            string dbUsername = "", dbPassword = "";

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string sql = "SELECT * FROM Users WHERE Username='" + user + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dbUsername = dr["Username"].ToString();
                    dbPassword = dr["Password"].ToString();
                }
                if (user == dbUsername && pass == dbPassword)
                {
                    userPassMatched.ForeColor = Color.Green;
                    userPassMatchedIcon.Image = tabPage1.Properties.Resources.CHECK_GREEN_RESIZED;
                    

                }
                else
                {

                    userPassMatched.ForeColor = Color.Red;
                    userPassMatchedIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;

                }

                con.Close();
            }
            catch
            {


            }
        }

        private void confirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (newPass.Text == confirmPass.Text)
            {
                passConfirmed.ForeColor = Color.Green;
                passConfirmIcon.Image = tabPage1.Properties.Resources.CHECK_GREEN_RESIZED;

            }
            else
            {
                passConfirmed.ForeColor = Color.Red;
                passConfirmIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;
            }

        }

        private void oldPass_TextChanged(object sender, EventArgs e)
        {
            string user = userChangePass.Text;
            string pass = oldPass.Text;
            string dbUsername = "", dbPassword = "";

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string sql = "SELECT * FROM Users WHERE Username='" + user + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dbUsername = dr["Username"].ToString();
                    dbPassword = dr["Password"].ToString();
                }
                if (user == dbUsername && pass == dbPassword)
                {
                    userPassMatched.ForeColor = Color.Green;
                    userPassMatchedIcon.Image = tabPage1.Properties.Resources.CHECK_GREEN_RESIZED;

                }
                else
                {

                    userPassMatched.ForeColor = Color.Red;
                    userPassMatchedIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;

                }

                con.Close();
            }
            catch
            {



            }
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (newPass.Text != "" || confirmPass.Text != "")
            {
                if (newPass.Text == confirmPass.Text)
                {
                    passConfirmed.ForeColor = Color.Green;
                    passConfirmIcon.Image = tabPage1.Properties.Resources.CHECK_GREEN_RESIZED;

                }
                else
                {
                    passConfirmed.ForeColor = Color.Red;
                    passConfirmIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (passConfirmed.ForeColor == Color.Green && userPassMatched.ForeColor == Color.Green)
            {
                try
                {

                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    string sql = "UPDATE Users SET Password='" + confirmPass.Text + "' WHERE Username='" + userChangePass.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("Password updated successfully!");
                    userChangePass.Clear();
                    oldPass.Clear();
                    newPass.Clear();
                    confirmPass.Clear();
                    userPassMatched.ForeColor = Color.Red;
                    userPassMatchedIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;
                    passConfirmed.ForeColor = Color.Red;
                    passConfirmIcon.Image = tabPage1.Properties.Resources.CROSS_RED_RESIZED;
                    log.Show();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            else
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.makeOkButton("One or more requirements not fulfilled.");
                log.Size = new Size(log.Width + 10, log.Height);
                log.SetCrossLocation(log.button1.Location.X + 12, log.button1.Location.Y);
                log.Show();
            }
        }

        private void ChangeUserPass_Click(object sender, EventArgs e)
        {
            new ChangeOwnPass(currentUser).Show();
          
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SubmitButton.Show();
            UpdateButton.Hide();
            CancelButton.Hide();
            techList.Items.Clear();
            engList.Items.Clear();
            techCombo.Items.Clear();
            engCombo.Items.Clear();
            addEngListItems();
            addTechListItems();
            phone.Clear();
            cityregion.Clear();
            detailsText.Clear();
            email.Clear();
            productText.Clear();
            cNameCombo.SelectedIndex = 0;
            cNameCombo.Enabled = true;
            statusCombo.SelectedIndex = 0;
            pictureBox1.Size = new Size(162, 628);
            pictureBox1.Location = new Point(5, 116);
            tabControl1.TabPages.Add(tabControl1);
            tabControl1.TabPages.Add(tabControl1);
            dateTimePicker1.Text = DateTime.Today.ToString();
            RegisterHeading.Text = "Register Complaint";
            tabControl1.SelectedTab = tabControl1;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            if (phone.Text == "" || cityregion.Text == "" || detailsText.Text == "" || email.Text == "" || productText.Text == "")
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.Show();
                log.makeOkButton("A required field is empty.");
                log.Location = new Point(log.Location.X + 10, log.Location.Y);
            }
            else
            {
                cc.updateComplaint(CompID, detailsText.Text, productText.Text, dateTimePicker1.Text, statusCombo.SelectedItem.ToString(), techniciansString(), engineersString(), cityregion.Text);
                cc.addClientDetails(cNameCombo.Text, phone.Text, email.Text, cityregion.Text, phoneEmailEdited, doesClientExist());
                LogOutMessageBox log = new LogOutMessageBox();
                log.makeOkButton("Complain updated successfully!");
                CancelButton_Click(sender, e);
                log.Show();

            }

    
        }

        private void techCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //nothing
            }
        }

        private void cNameCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //nothing
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (cNameCombo.SelectedItem.ToString() == "New Client")
            {
                phone.Enabled = true;
                email.Enabled = true;
                cityregion.Enabled = true;
                cNameCombo.DropDownStyle = ComboBoxStyle.DropDown;
                cNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cNameCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            cNameCombo.SelectedItem = "New Client";
            phone.Clear();
            phone.Enabled = true;
            email.Clear();
            email.Enabled = true;
            cityregion.Clear();
            cityregion.Enabled = true;
        }

    }
}
