using factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    //提供一個創建一系列相關或互相依賴對象的接口，而無須指定他們具體的類  

    interface IConnection
    {
        void connect();
    }
    interface ICommand
    {
        void command();
    }
    interface IDatabasUtils
    {       

        public IConnection GetConnection();
        public ICommand GetCommand();   

    }

    class MySqlConnection : IConnection
    {
        public void connect()
        {
            Console.WriteLine("MySql connected");
        }
    }
    class MySqlCommand : ICommand
    {
        public void command()
        {
            Console.WriteLine("MySql command");
        }
    }

    class MysqlUtils : IDatabasUtils
    {
        

        public ICommand GetCommand()
        {
            return new MySqlCommand();
        }

        public IConnection GetConnection()
        {
            return new MySqlConnection();
        }
    }


    class OracleConnection : IConnection
    {
        public void connect()
        {
            Console.WriteLine("Oracle connected");
        }
    }
    class OracleCommand : ICommand
    {
        public void command()
        {
            Console.WriteLine("Oracle command");
        }
    }

    class OracleUtils : IDatabasUtils
    {


        public ICommand GetCommand()
        {
            return new OracleCommand();
        }

        public IConnection GetConnection()
        {
            return new OracleConnection();
        }
    }
}
