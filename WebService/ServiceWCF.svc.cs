using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;
using System.Collections;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceWCF" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ServiceWCF.svc или ServiceWCF.svc.cs в обозревателе решений и начните отладку.
    public class ServiceWCF : IServiceWCF
    {
        //private IQueryable<Person> person;

        public void DoAddData(string date, string name)
        {
            using (PersonDb db = new PersonDb())
            {
                Person person = new Person {Id = 1, Date = date, Name = name };
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public List<Person> DoShowData()
        {
            List<Person> temp = new List<Person>();
            using (PersonDb db = new PersonDb())
            {
                var person = from t in db.Persons where t.Name.Length > 0 select t;
                foreach(Person t in person)
                {
                    temp.Add(t);
                }
            }
            return temp;
        }
    }
}
