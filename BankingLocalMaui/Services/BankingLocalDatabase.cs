using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BankingLocalMaui.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;

namespace BankingLocalMaui.Services
{
    public class BankingLocalDatabase
    {       
            private SQLiteConnection _dbConnection; // understands SQLite Member Variable / Use it anywhere in the class 

        public string GetDataBasePath() // first step you do when making any app

        {
            string filename = "bankingdata.db"; // file naming 
            string PathToDb = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData); //sets the path 

            return Path.Combine(PathToDb, filename); // Make sure all slashes are right 
        }

        public BankingLocalDatabase() // first code that gets called 
        {

            _dbConnection = new SQLiteConnection(GetDataBasePath());       //make a connection 

            _dbConnection.CreateTable<ClientType>();
            // Create Table from class // check if table exists 
            _dbConnection.CreateTable<BankAccountType>();
            _dbConnection.CreateTable<TransactionType>();
            _dbConnection.CreateTable<Bank>();
            _dbConnection.CreateTable<Client>();
            SeedDatabase();
        }

        public void SeedDatabase() // everything to do with populating the database // Make sure to use select statment 
        {

            if (_dbConnection.Table<ClientType>().ToList().Count() == 0) // if the count of rows = 0 dont add more records // if it complains clear method under constructor on CS ClienttypeDescriptions 
            {

                ClientType clientType = new ClientType()
                {
                    ClientTypeDescription = "Private"

                }; // create a new  instance of client type based off Client Type CS

                _dbConnection.Insert(clientType); // saves to the database // will auto increment 

                clientType = new ClientType()
                {
                    ClientTypeDescription = "MVP"

                };
                _dbConnection.Insert(clientType);

                clientType = new ClientType()
                {
                    ClientTypeDescription = "Standard"

                };
                _dbConnection.Insert(clientType);
            }

            if (_dbConnection.Table<BankAccountType>().ToList().Count() == 0)
            {
                BankAccountType bankAccountType = new BankAccountType()
                {
                    BankAccountTypeDescription = "Credit"

                };

                _dbConnection.Insert(bankAccountType);


                bankAccountType = new BankAccountType()
                {
                    BankAccountTypeDescription = "Savings"

                };

                _dbConnection.Insert(bankAccountType);

                bankAccountType = new BankAccountType()
                {
                    BankAccountTypeDescription = "Cheque"

                };

                _dbConnection.Insert(bankAccountType);

            }
            if (_dbConnection.Table<TransactionType>().ToList().Count() == 0)
            {


                TransactionType transactionType = new TransactionType()
                {

                    TransactionTypeDescritpion = "Deposit"

                };
                _dbConnection.Insert(transactionType);

                transactionType = new TransactionType()
                {

                    TransactionTypeDescritpion = "Cheque"

                };
                _dbConnection.Insert(transactionType);


            }
            Client client = new Client()
            {
                FirstName = "Brandon",
                Surname = "Mack",
                SaIdNumber = "18213124141",
                ContactNumber = 0845688228,
                Email = "me@computer.co.za",
                PhysicalAddress = "Swellendam"


            };




            Bank bank = new Bank()
            {

                BankName = "Nedbank",
                BranchCode ="12345"

            };

            _dbConnection.Insert(bank);
            _dbConnection.Insert(client);

            bank.Clients.Add(client);

            _dbConnection.UpdateWithChildren(bank); // sorts out all the relations

            




        }


                public List<ClientType> GetAllClientTypes() 
                {
                  var clientType =  _dbConnection.Table<ClientType>().ToList();

                    return clientType; 

                    

                }
    }


}

