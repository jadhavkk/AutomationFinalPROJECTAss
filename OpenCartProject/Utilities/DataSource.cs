using OpenCartProject.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject.Utilities
{
    public class DataSource : AutomationWrapper
    {

        public static object[] InvalidRegisterData()

        {

            string[] dataSet1 = new string[6];
            dataSet1[0] = "sakshi devkar";
            dataSet1[1] = "shakti";
            dataSet1[2] = "jack";
            dataSet1[3] = "sdevkar39@gmail.com";
            dataSet1[4] = "India";
            dataSet1[5] = "devkar@00";



            object[] allDataSet = new object[1];
            allDataSet[0] = dataSet1;


            return allDataSet;


        } 





        public static object[] ValidRegisterData()

        {

            string[] dataSet1 = new string[6];
            dataSet1[0] = "sakshi devkar";
            dataSet1[1] = "sakshi";
            dataSet1[2] = "devkar";
            dataSet1[3] = "sdevkar39@gmail.com";
            dataSet1[4] = "India";
            dataSet1[5] = "devkar@00";

           
            object[] allDataSet = new object[1]; 
            allDataSet[0] = dataSet1;
          

            return allDataSet;


        }
        public static object[] ValidLoginData()

        {

            string[] dataSet1 = new string[2];

            dataSet1[0] = "sdevkar39@gmail.com";
            dataSet1[1] = "devkar@00";


            object[] allDataSet = new object[1];
            allDataSet[0] = dataSet1;


            return allDataSet;
        }
        public static object[] InvalidLoginData()

        {

            string[] dataSet1 = new string[2];

            dataSet1[0] = "sdfgyhh@gmail.com";
            dataSet1[1] = "devkar@00";


            object[] allDataSet = new object[1];
            allDataSet[0] = dataSet1;


            return allDataSet;
        }














































        /*public static object[] InvalidLoginData2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray
                (@"", "InvalidRegisterTest");
            return data;
        }


        public static object[] AddUserTest()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray
                (@"", "AddUserTest");
            return data;
        }*/
    }
}

    

