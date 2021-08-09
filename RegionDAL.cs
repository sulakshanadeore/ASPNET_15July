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
         DataSet ds = new DataSet();
        SqlDataAdapter adapter;
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

        private  void FillData()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCnString"].ConnectionString);
            adapter= new SqlDataAdapter("select * from region", cn);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds,"regions");
        }

        public void InsertRegion(RegionBAL data)
        {
            FillData();
            DataRow drow = ds.Tables["regions"].NewRow();
            drow[0] = Convert.ToInt32(data.RegionID);
            drow["RegionDescription"] = data.RegionName.ToString();
            ds.Tables["regions"].Rows.Add(drow);
            SaveToDB();

        }

        private void SaveToDB()
        {
            SqlCommandBuilder bldr = new SqlCommandBuilder(adapter);
            adapter.Update(ds.Tables["regions"]);
        }

        public void DeleteRegion(int regionid)
        {
            FillData();
            DataRow found=ds.Tables["regions"].Rows.Find(regionid);
            found.Delete();
            //SqlCommandBuilder bldr = new SqlCommandBuilder(adapter);
            //adapter.Update(ds.Tables["regions"]);
            SaveToDB();


        }
        public void UpdateRegion(RegionBAL region)
        {

            FillData();

            DataRow found = ds.Tables["regions"].Rows.Find(region.RegionID);

            found["RegionDescription"] = region.RegionName;
            //SqlCommandBuilder bldr = new SqlCommandBuilder(adapter);
            //adapter.Update(ds.Tables["regions"]);
            SaveToDB();
            



        }

        public RegionBAL FindRegion(int regionid)
        {
            FillData();

            DataRow found = ds.Tables["regions"].Rows.Find(regionid);
            
            RegionBAL bal = new RegionBAL();
            bal.RegionID = regionid;
            bal.RegionName = found["RegionDescription"].ToString();
            return bal;

        }


    }
}
