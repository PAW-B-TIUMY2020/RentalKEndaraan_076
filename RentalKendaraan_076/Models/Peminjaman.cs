using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_076.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }

        [DisplayName("Tanggal Peminjaman")]
        [Required(ErrorMessage = "Tgl Peminjaman wajib diisi!")]
        public DateTime TglPeminjaman { get; set; }

        [Required(ErrorMessage = "Kendaraan wajib diisi!")]
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }

        [Required(ErrorMessage = "Customer wajib diisi!")]
        [DisplayName("Customer")]
        public int? IdCostumer { get; set; }

        [Required(ErrorMessage = "Jaminan wajib diisi!")]
        [DisplayName("Jaminan")]
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya wajib diisi!")]
        public int? Biaya { get; set; }
        [DisplayName("Kendaraan")]
        
        public Kendaraan IdCostumer1 { get; set; }
        [DisplayName("Customer")]
        
        public Customer IdCostumerNavigation { get; set; }

        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
