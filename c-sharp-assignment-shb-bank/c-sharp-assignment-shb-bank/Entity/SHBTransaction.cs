﻿    using System;

namespace c_sharp_assignment_shb_bank.Entity
{
    public class SHBTransaction
    {
        /*for transaction histories*/
        public string Code { get; set; }
        public string SenderAccountNumber { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public string Message { get; set; }
        public double Amount { get; set; }
        public double Fee { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public TransactionStatus Status { get; set; }
        public TransactionType Type { get; set; }
    }

    public enum TransactionType
    {
        WITHDRAW = 1, //rut tien
        DEPOSIT = 2, // buff tien vao tk
        TRANSFER = 3 //chuyen khoan
    }

    public enum TransactionStatus
    {
        PENDING = 1,
        DONE = 2,
        FAILED = 0
    }
}