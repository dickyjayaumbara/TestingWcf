using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestingForWGS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceClient : IServiceClient
    {
        /// <summary>
        /// proses mendapatkan nilai hasil perkalian
        /// </summary>
        /// <param name="angkaPertama">input angka pertama</param>
        /// <param name="angkaKedua">input angka kedua</param>
        /// <returns>hasil perkalian</returns>
        public decimal Perkalian(decimal angkaPertama, decimal angkaKedua)
        {
            return (angkaPertama * angkaKedua);
        }

        /// <summary>
        /// proses mendapatkan nilai hasil pembagian
        /// </summary>
        /// <param name="angkaPertama">input angka pertama</param>
        /// <param name="angkaKedua">input angka kedua</param>
        /// <returns>hasil pembagian</returns>
        public decimal Pembagian(decimal angkaPertama, decimal angkaKedua)
        {
            return (angkaPertama / angkaKedua);
        }

        /// <summary>
        /// proses mendapatkan nilai hasil penjumlahan
        /// </summary>
        /// <param name="angkaPertama">input angka pertama</param>
        /// <param name="angkaKedua">input angka kedua</param>
        /// <returns>hasil penjumlahan</returns>
        public decimal Penjumlahan(decimal angkaPertama, decimal angkaKedua)
        {
            return (angkaPertama + angkaKedua);
        }


        /// <summary>
        /// proses mendapatkan nilai hasil pengurangan
        /// </summary>
        /// <param name="angkaPertama">input angka pertama</param>
        /// <param name="angkaKedua">input angka kedua</param>
        /// <returns>hasil pengurangan</returns>
        public decimal Pengurangan(decimal angkaPertama, decimal angkaKedua)
        {
            return (angkaPertama - angkaKedua);
        }
    }
}
