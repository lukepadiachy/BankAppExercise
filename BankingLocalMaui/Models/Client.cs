using SQLite;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace BankingLocalMaui.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ClientId { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        public string SaIdNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ContactNumber { get; set; }

        public string PhysicalAddress { get; set; }

        
        [ForeignKey(typeof(ClientType))] // can check the client type - checks the foreign key 
        public int ClientTypeId { get; set; }


        [ForeignKey(typeof(Bank))] // 
        public int BankId { get; set; }




    }
}
