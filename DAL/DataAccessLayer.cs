using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string Connstr = @"Data Source=MAZIBUKO\SQLEXPRESS;Initial Catalog=PropertyAppDB;Integrated Security=True";
        SqlConnection dbConn=new SqlConnection(Connstr);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertPropertyType(PropertyType pty)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertPropertyType",dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", pty.PropertyTypeDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertRole(Role r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertRole", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleDesc",r.RoleDesc);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertUser(User u)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name",u.Name);
            dbComm.Parameters.AddWithValue("@Surname",u.Surname);
            dbComm.Parameters.AddWithValue("@Email",u.Email);
            dbComm.Parameters.AddWithValue("@Password",u.Password);
            dbComm.Parameters.AddWithValue("@RoleID",u.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetPropertyType", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetAdminByName(Admin ad)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetAdminByAdmin", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", ad.Name);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetAgentByName(Agent ag)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetAgentByName", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", ag.Name);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetTenantByName(Tenant t)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetTenantByName", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", t.Name);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

        public DataTable GetRole()
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetRole", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetUser()
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_GetUser", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertProperty(Property pt)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", pt.Description);
            dbComm.Parameters.AddWithValue("@Price", pt.Price);
            dbComm.Parameters.AddWithValue("@Image", pt.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", pt.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", pt.Status);
            dbComm.Parameters.AddWithValue("@SurbubID", pt.SurbubID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateProperty(Property pt)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeID",pt.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Price", pt.Price);
            dbComm.Parameters.AddWithValue("@Status", pt.Status);
            dbComm.Parameters.AddWithValue("@PropertyID", pt.PropertyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
        public int DeleteProperty(Property pt)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_DeleteProperty",dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", pt.PropertyID);

            int x=dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetProperty()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetProperty", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertProvince(Province pr)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", pr.Description);
            
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetProvince()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetProvince", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertCity(City c)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", c.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", c.ProvinceID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetCity()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetCity", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertSurbub(Surbub s)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertSurbub", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SurbubDescription",s.SurbubDescription);
            dbComm.Parameters.AddWithValue("@PostalCode",s.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID",s.CityID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetSurbub()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetSurbub", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertAgency(Agency a)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyName",a.AgencyName);
            dbComm.Parameters.AddWithValue("@SurbubID",a.SurbubID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int DeleteAgency(Agency a)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_DeleteAgency", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyID",a.AgencyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAgency()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetAgency", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertAgent(Agent ag)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name",ag.Name);
            dbComm.Parameters.AddWithValue("@Surname", ag.Surname);
            dbComm.Parameters.AddWithValue("@Email", ag.Email);
            dbComm.Parameters.AddWithValue("@Password", ag.Password);
            dbComm.Parameters.AddWithValue("@Phone", ag.Phone);
            dbComm.Parameters.AddWithValue("@Status", ag.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", ag.AgencyID);




            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateAgent(Agent ag)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", ag.Email);
            dbComm.Parameters.AddWithValue("@Phone", ag.Phone);
            dbComm.Parameters.AddWithValue("@Status", ag.Status);
            dbComm.Parameters.AddWithValue("@AgentID", ag.AgentID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
        public int DeleteAgent(Agent ag)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_DeleteAgent", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", ag.AgentID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAgent()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetAgent", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertTenant(Tenant t)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", t.Name);
            dbComm.Parameters.AddWithValue("@Surname", t.Surname);
            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Password", t.Password);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);

             int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateTenant(Tenant t)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);
            dbComm.Parameters.AddWithValue("@TenantID", t.TenantID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int DeleteTenant(Tenant t)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_DeleteTenant", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", t.TenantID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetTenant()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetTenant", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertPropertyAgent(PropertyAgent pa)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdatePropertyAgent(PropertyAgent pa)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            dbComm.Parameters.AddWithValue("@PropertyAgentID", pa.PropertyAgentID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetPropertyAgent()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetPropertyAgent", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertRental(Rental r)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", r.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@TenantID",r.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", r.EndDate);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateRental(Rental r)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", r.RentalID);
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", r.EndDate);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetRental()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetRental", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertAdmin(Admin a)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", a.Name);
            dbComm.Parameters.AddWithValue("@Surname", a.Surname);
            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            dbComm.Parameters.AddWithValue("@PropertyID", a.PropertyID);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", a.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@LocationID", a.LocationID);
            dbComm.Parameters.AddWithValue("@AgentID", a.AgentID);
            dbComm.Parameters.AddWithValue("@AgencyID", a.AgencyID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateAdmin(Admin a)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateAdmin", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            dbComm.Parameters.AddWithValue("@PropertyID", a.PropertyID);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", a.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@LocationID", a.LocationID);
            dbComm.Parameters.AddWithValue("@AgentID", a.AgentID);
            dbComm.Parameters.AddWithValue("@AgencyID", a.AgencyID);
            dbComm.Parameters.AddWithValue("@AdminID", a.AdminID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int DeleteAdmin(Admin a)
        {
            dbConn.Open();

            dbComm=new SqlCommand("sp_DeleteAdmin", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AdminID", a.AdminID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAdmin()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetAdmin", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertLocation(Location loc)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertLocation", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SurbubID", loc.SurbubID);
            dbComm.Parameters.AddWithValue("@ProvinceID", loc.ProvinceID);
            dbComm.Parameters.AddWithValue("@Address",loc.Address);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateLocation(Location loc)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateLocation", dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SurbubID", loc.SurbubID);
            dbComm.Parameters.AddWithValue("@ProvinceID", loc.ProvinceID);
            dbComm.Parameters.AddWithValue("@Address", loc.Address);
            dbComm.Parameters.AddWithValue("@LocationID", loc.LocationID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetLocation()
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_GetLocation", dbConn);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable Login(string email,string password)
        {

            dbConn.Open();

            dbComm=new SqlCommand("sp_Login", dbConn);

            dbComm.CommandType=CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email",email);
            dbComm.Parameters.AddWithValue("@Password",password);

            dbAdapter=new SqlDataAdapter(dbComm);
            dt=new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

    }
}
