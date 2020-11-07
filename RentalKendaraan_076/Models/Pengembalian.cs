using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_076.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "Tgl Peminjaman wajib diisi!")]
        public DateTime TglPengembalian { get; set; }
        [Required(ErrorMessage = "ID Peminjaman wajib diisi!")]
        public int? IdPeminjaman { get; set; }
        [Required(ErrorMessage = "ID Kondisi wajib diisi!")]
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda wajib diisi!")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
