﻿namespace VehicleTender.Web.AdminUI.Models.Admin
{
    public class UpdateAdmin
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
    }
}