using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryPublic.Table
{
    public class TableCostCenter
    {
       // public static string IDCostCenter = "IDCostCenter";
        public static string Gun { get { return "Gun"; } }
        public static string ID { get { return "ID"; }  }
        public static string GroupID { get { return "GroupID"; } }
        public static string GroupName { get { return "GroupName"; } }
        public static string NameLng1 { get { return "NameLng1"; } }
        public static string NameLng2 { get { return "NameLng2"; } }
        public static string IsGroup { get { return "IsGroup"; } }

        private ClassPublicVar.TypeOperation _TypeOperation;
        public ClassPublicVar.TypeOperation TypeOperation
        {
            get{ return _TypeOperation;}
            set{ _TypeOperation = value;}
        }

    }
}
