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
        [Required(ErrorMessage = "No HP tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        [MinLength(10, ErrorMessage = "No HP minimal 10 digit")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 digit")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "Gender wajib diisi!")]
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
