﻿using CapDemo.DA;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.BL
{
    class CatalogueBL
    {
        DatabaseAccess DA;
        public CatalogueBL()
        {
            DA = new DatabaseAccess();
        }
        //select catalogue table
        public List<Catalogue> GetCatalogue()
        {
            List<Catalogue> CatalogueList = new List<Catalogue>();
            string query = "SELECT [Catalogue_ID],[Catalogue_Name]"
                        + " FROM [Capstone].[dbo].[Catalogue]";
            DataTable dt = DA.SelectDatabase(query);
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Catalogue cat = new Catalogue();
                    cat.IDCatalogue=Convert.ToInt32(item["Catalogue_ID"]);
                    cat.NameCatalogue = item["Catalogue_Name"].ToString();
                    CatalogueList.Add(cat);
 
                }
            }
            return CatalogueList;
        }

        //Insert Catalogue
        public bool AddCatalogue(Catalogue Catalogue)
        {
            string query = "INSERT INTO Catalogue (Catalogue_Name)"
                        + " VALUES ('" + Catalogue.NameCatalogue + "')";

            if(ExistCatalogue(Catalogue) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }
        //Check Catalogue Exist
        public bool ExistCatalogue(Catalogue Catalogue)
        {
            string query = "SELECT Catalogue_ID, Catalogue_Name FROM Catalogue"
                         + " WHERE Catalogue_Name = '" + Catalogue.NameCatalogue.ToUpper() + "'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Edit catalogue
        public bool EditCataloguebyID(Catalogue Catalogue)
        {
            string query = "UPDATE Catalogue SET Catalogue_Name ='" + Catalogue.NameCatalogue + "'"
                         + " WHERE Catalogue_ID = '" + Catalogue.IDCatalogue + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete catalogue
        public bool DeleteCataloguebyID(Catalogue Catalogue){
             string query = "DELETE FROM Catalogue"
                          + " WHERE Catalogue_ID = '" + Catalogue.IDCatalogue + "'";
            return DA.DeleteDatabase(query);
        }
        //Delete question by catalogue ID
        public bool DeleteQuestionbyIDCatalogue(Catalogue Catalogue)
        {
            string query = "DELETE FROM Question"
                         + " WHERE Catalogue_ID = '" + Catalogue.IDCatalogue + "'";
            return DA.DeleteDatabase(query);
        }
        //DELETE ANSWER
        public bool DeleteAnswerByIDQuestion(Question Question)
        {
            string query = "DELETE FROM Answer"
                          + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }

        
    }
}