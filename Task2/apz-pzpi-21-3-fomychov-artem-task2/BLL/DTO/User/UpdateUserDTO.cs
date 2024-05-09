﻿using DAL.Entities;

namespace BLL.DTO
{
    public class UpdateUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fingerprint { get; set; }
        public RoleName RoleName { get; set; }
    }
}