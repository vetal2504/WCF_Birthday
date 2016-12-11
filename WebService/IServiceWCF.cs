using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceWCF" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceWCF
    {
        [OperationContract]
        void DoShowData();

        [OperationContract]
        void DoAddData();
    }
}
