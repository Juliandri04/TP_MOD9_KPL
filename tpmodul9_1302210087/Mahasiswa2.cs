using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmodul9_1302210087
{
    public class Mahasiswa2
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mahasiswa2(string nama, string nim) { this.Nama = nama; this.Nim = nim; }
    }

}
