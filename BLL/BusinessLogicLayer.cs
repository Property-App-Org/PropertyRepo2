using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertPropertyType(PropertyType pty)
        {
            return dal.InsertPropertyType(pty);
        }
        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }
        public int InsertProperty(Property pt)
        {
            return dal.InsertProperty(pt);
        }
        public int UpdateProperty(Property pt)
        {
            return dal.UpdateProperty(pt);
        }
        public int DeleteProperty(Property pt)
        {
            return dal.DeleteProperty(pt);
        }
        public DataTable GetProperty()
        {
            return dal.GetProperty();
        }
        public int InsertProvince(Province pr)
        {
            return dal.InsertProvince(pr);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }
        public int InsertCity(City ct)
        {
            return dal.InsertCity(ct);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }
        public int InsertSurbub(Surbub sb)
        {
            return dal.InsertSurbub(sb);
        }
        public DataTable GetSurbub()
        {
            return dal.GetSurbub();
        }
        public int InsertAgency(Agency ag)
        {
            return dal.InsertAgency(ag);
        }
        public int DeleteAgency(Agency ag)
        {
            return dal.DeleteAgency(ag);
        }
        public DataTable GetAgency()
        {
            return dal.GetAgency();
        }
        public int InsertAgent(Agent a)
        {
            return dal.InsertAgent(a);
        }
        public int UpdateAgent(Agent a)
        {
            return dal.UpdateAgent(a);
        }
        public int DeleteAgent(Agent a)
        {
            return dal.DeleteAgent(a);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public int InsertTenant(Tenant t)
        {
            return dal.InsertTenant(t);
        }
        public int UpdateTenant(Tenant t)
        {
            return dal.UpdateTenant(t);
        }
        public int DeleteTenant(Tenant t)
        {
            return dal.DeleteTenant(t);
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();
        }
        public int InsertPropertyAgent(PropertyAgent pa)
        {
            return dal.InsertPropertyAgent(pa);
        }
        public int UpdatePropertAgent(PropertyAgent pa)
        {
            return dal.UpdatePropertyAgent(pa);
        }
        public DataTable GetPropertyAgent()
        {
            return dal.GetPropertyAgent();
        }
        public int InsertRental(Rental r)
        {
            return dal.InsertRental(r);
        }
        public int UpdateRental(Rental r)
        {
            return dal.UpdateRental(r);
        }
        public DataTable GetRental()
        {
            return dal.GetRental();
        }
        public int InsertAdmin(Admin ad)
        {
            return dal.InsertAdmin(ad);
        }
        public int UpdateAdmin(Admin ad)
        {
            return dal.UpdateAdmin(ad);
        }
        public int DeleteAdmin(Admin ad)
        {
            return dal.DeleteAdmin(ad);
        }
        public DataTable GetAdmin()
        {
            return dal.GetAdmin();
        }
        public int InsertLocation(Location l)
        {
            return dal.InsertLocation(l);
        }
        public int UpdateLocation(Location l)
        {
            return dal.UpdateLocation(l);
        }
        public DataTable GetLocation()
        {
            return dal.GetLocation();
        }
    }
}
