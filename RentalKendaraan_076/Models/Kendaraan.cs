using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_076.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan wajib diisi!")]
        public string NamaKendaraan { get; set; }
        [MaxLength(15,ErrorMessage ="masukan 15 digit no polisi")]
        public string NoPolisi { get; set; }
        [MaxLength(8, ErrorMessage = "masukan no stnk")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "Id Jenis Kendaraan wajib diisi!")]
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan wajib diisi!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
