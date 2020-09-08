﻿using ChoETL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VideogameShopLibrary.CVS_Models
{
    [ChoCSVFileHeader]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ChoCSVRecordField(1)]
        public string Product { get; set; }

        [ChoCSVRecordField(2)]
        [DefaultValue(1)]
        public uint Quantity { get; set; }

        [ChoCSVRecordField(3)]
        public string Condition { get; set; }

        [ChoCSVRecordField(4)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        [ChoCSVRecordField(5)]
        public decimal Total { get; set; }

        [ChoCSVRecordField(6, FieldName = "Customer Name")]
        public string CustomerName { get; set; }


        [ChoCSVRecordField(7, FieldName = "Customer Phone")]
        public string CustomerPhone { get; set; }

        [ChoCSVRecordField(8)]
        public string Email { get; set; }
        [ChoCSVRecordField(9, FieldName ="Type of Sale")]
        [DefaultValue("Cash")]
        public string TypeOfSale { get; set; }

        [ChoCSVRecordField(10, FieldName="Name on Credit Card")]
        public string CreditCardName { get; set; }

        [ChoCSVRecordField(11, FieldName ="Credit Card Number")]
        public int CreditCardNumber { get; set; }

        [ChoCSVRecordField(12,FieldName ="Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

        [ChoCSVRecordField(13, FieldName ="Security Code")]

        public int SecurityCode { get; set; }





    }
}
