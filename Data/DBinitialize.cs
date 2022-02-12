using ControlMoneyApp.Entity;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMoneyApp.Data
{
    class DBinitialize
    {
        public static bool CreateTable()
        {
            var conn = new SQLiteConnection("SaveMoney.db");
            string sql = "create table if not exists SaveMoney (id integer primary key autoincrement not null, " +
                                                                "name varchar(140), " +
                                                                "money double, " +
                                                                "datepay date, " +
                                                                "category varchar(140))";
            using (var stt = conn.Prepare(sql))
            {
                stt.Step();
            }
                return true;
        }

        public static bool SaveNewTransaction(MyTransaction myTransaction)
        {
            var conn = new SQLiteConnection("SaveMoney.db");
            using(var stt2 = conn.Prepare("insert into SaveMoney (name, money, datepay, category) values (?,?,?,?)"))
            {
                stt2.Bind(1, myTransaction.name);
                stt2.Bind(2, myTransaction.money);
                stt2.Bind(3, myTransaction.datepay.ToString("yyyy-MM-dd"));
                stt2.Bind(4, myTransaction.category);
                stt2.Step();
            }

            return true;
        }

        public static List<MyTransaction> SelectAll()
        {
            var conn = new SQLiteConnection("SaveMoney.db");
             var listAll = new List<MyTransaction>();
            using(var stt = conn.Prepare("select * from SaveMoney"))
            {               
                while(stt.Step() == SQLiteResult.ROW)
                {
                    var newTransaction = new MyTransaction();
                    newTransaction.name = stt["name"] as string;
                    newTransaction.money = (double)stt["money"];
                    newTransaction.datepay = Convert.ToDateTime(stt["datepay"]);
                    newTransaction.category = stt["category"] as string;
                    Debug.WriteLine(newTransaction.name);
                    listAll.Add(newTransaction);
                }
            }            
            return listAll;
        }
    }
}
