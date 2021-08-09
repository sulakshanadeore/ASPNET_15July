using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using System.Data;
using System.Configuration;
namespace DAL
{
    public class RegionDAL
    {
        static DataSet ds = new DataSet();
        public List<RegionBAL> ShowRegions()
        {
            FillData();
            List<RegionBAL> regions = new List<RegionBAL>();
            DataTable dt = new DataTable();
            dt=ds.Tables["regions"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RegionBAL r = new RegionBAL();
                r.RegionID = Convert.ToInt32(dt.Rows[i][0]);
                r.RegionName = dt.Rows[i][1].ToString();
                regions.Add(r);
            }
            return regions;

        }

        private static void FillData()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCnString"].ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from region", cn);
            
            adapter.Fill(ds,"regions");
        }

        public void InsertRegion(RegionBAL data)
        { }
        public void DeleteRegion(int regionid)
        { }
        public void UpdateRegion(RegionBAL regionid)
        { }

        //public RegionBAL FindRegion(int regionid)
        //{ }


    }
}
