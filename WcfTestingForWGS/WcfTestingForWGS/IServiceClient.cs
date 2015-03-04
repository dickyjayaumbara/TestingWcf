using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestingForWGS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceClient
    {
        [OperationContract]
        decimal Perkalian(decimal angkaPertama, decimal angkaKedua);

        [OperationContract]
        decimal Pembagian(decimal angkaPertama, decimal angkaKedua);

        [OperationContract]
        decimal Penjumlahan(decimal angkaPertama, decimal angkaKedua);

        [OperationContract]
        decimal Pengurangan(decimal angkaPertama, decimal angkaKedua);

    }
}
