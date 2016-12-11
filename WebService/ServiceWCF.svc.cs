using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceWCF" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ServiceWCF.svc или ServiceWCF.svc.cs в обозревателе решений и начните отладку.
    public class ServiceWCF : IServiceWCF
    {
        public void DoAddData()
        {
            using (PersonDb db = new PersonDb())
            {
                Person person = new Person {Id = 3, Date = "1111", Name = "1111"};
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public void DoShowData()
        {
            
        }
    }
}
