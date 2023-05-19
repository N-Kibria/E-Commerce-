﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Commerce
{
    
    public static class utility
    {
        internal static List<user> users = new List<user>();

        public static void load_users()

        {
            string path = @"G:\IUT\Semester\1-2\SWE 4202\zzz\Information.txt";
        
        StreamReader srr = new StreamReader(path);

            var strr = srr.ReadLine();

            while (strr != null)
            {
                string[] k = null;
                k = strr.Split(',');
                string user_name = k[0];
                string pass = k[1];
                string name = k[2];

                user u = new user(user_name, pass, name);
                users.Add(u);

                strr = srr.ReadLine();
            }

            srr.Close();
        }


    }
}
