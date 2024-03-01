using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLocalMaui.Models
{
    public class ClientType // template for a client type // never used till we call it 
    {
        [PrimaryKey, AutoIncrement] // Primary Key- Csharp attribute // Can specify key type too // AutoIncrement - keeps the sequence and gives a unique number  //
        public int ClientId { get; set; }

        public string ClientTypeDescription { get; set; }
        
       /* public ClientType(string description) // ensure that the clienttype has a description 
        {
            ClientTypeDescription = description;        
        
        }

        */

    }
}
