using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_076.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer wajib diisi!")]
        public string NamaCustomer { get; set; }
        [Required(ErrorMessage = "Nik wajib diisi!")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib diisi!")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No Hp minimal 10 angka")]
        [MaxLength(1, ErrorMessage = "No Hp minimal 13 angka")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "Gender wajib diisi!")]
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
