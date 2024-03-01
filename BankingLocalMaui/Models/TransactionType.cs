﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLocalMaui.Models
{
    public class TransactionType
    {

        [PrimaryKey, AutoIncrement]
        public int TransactionTypeId { get; set; }

        public string TransactionTypeDescritpion { get; set; }

    }
}
