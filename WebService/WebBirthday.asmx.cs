using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Сводное описание для WebBirthday
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebBirthday : System.Web.Services.WebService
    {

        [WebMethod]
        public string AddData(string name, string date)
        {
            string temp = "";
            using (PersonData db = new PersonData())
            {
                // создаем два объекта User
                Person user1 = new Person { Name = name, Date = date };
                temp = user1.Name;
                // добавляем их в бд
                db.Persons.Add(user1);
                db.SaveChanges();
            }
            return temp;
        }

        [WebMethod]
        public object AddDataGridId()
        {
            int temp = 0;
            using (PersonData db = new PersonData())
            {
                var id = from s in db.Persons select s.Id;
                return id;
            }

            //return temp;
        }

        [WebMethod]
        public object AddDataGridDate()
        {
            string temp = string.Empty;
            using (PersonData db = new PersonData())
            {
                var date = from s in db.Persons select s.Date;
                return date;
            }

            //return temp;
        }
    }
}
