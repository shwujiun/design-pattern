// See https://aka.ms/new-console-template for more information
using factory;
using System.Runtime.InteropServices;


//簡單工廠
SimpleFactory.CreateProduct("A");


//抽象工廠
IDatabasUtils utils = new OracleUtils();
IConnection connection = utils.GetConnection(); 
connection.connect();
ICommand cmd = utils.GetCommand();
cmd.command();





