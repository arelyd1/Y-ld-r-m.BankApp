﻿namespace Yıldırım.BankApp.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUsers { get; set; }
    }
}
