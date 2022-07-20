using Factory_Exercise2;



Console.WriteLine("Please choose a database: list, sql, or mongo");
var input = Console.ReadLine();
IDataAccess newDataAccess = DataAccessFactory.GetDataAccess(input);
newDataAccess.LoadData();
newDataAccess.SaveData();   