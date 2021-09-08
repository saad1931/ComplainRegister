using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ComplainRegister
{
    class ConnectionClass
    {

        static string path = Application.StartupPath;
        public string conString = "Data Source=DESKTOP-CT235QF;Initial Catalog=coomplain;Integrated Security=True";

        public void updateComplaint(int compID, string cdetails, string product, string date, string status, string technicians, string engineers, string cityrgion)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string sql = "UPDATE ComplainDetails SET Details='" + cdetails + "',Date='" + date + "',Status='" + status + "',Technicians='" + technicians + "',Engineers='" + engineers + "',CityRegion='" + cityrgion + "',Product='" + product + "' WHERE ComplaintID='" + compID + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }
        }
        public void addComplain(string cname, string cdetails, string product, string date, string status, string technicians, string engineers, string cityrgion)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    //details     
                    string sql = "INSERT INTO ComplainDetails(clientName,details,product,date,status,technicians,engineers,cityregion)VALUES('" + cname + "','" + cdetails + "','" + product + "','" + date + "','" + status + "','" + technicians + "','" + engineers + "','" + cityrgion + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("Complain added successfully!");
                    log.Show();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
                con.Close();
            }
        }
        public void addClientDetails(string name, string contact, string email, string cityregion, bool isEdited, bool clientExists)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string insertSql = "INSERT INTO ClientDetail(clientName,contact,cityregion,email)VALUES('" + name + "','" + contact + "','" + cityregion + "','" + email + "')";
                string updateSql = "UPDATE ClientDetail SET Contact=@contact,Email=@eml WHERE clientName=@clname";
                if (isEdited == true && clientExists == true)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(updateSql, con);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@eml", email);
                        cmd.Parameters.AddWithValue("@clname", name);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (isEdited == false && clientExists == false)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(insertSql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.ToString());
                    }
                }
            }
            con.Close();
        }
        public bool dbExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
