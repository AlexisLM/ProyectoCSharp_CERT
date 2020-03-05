using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    static class PizzaDatabase
    {
        public static string CreateDatabase()
        {
            var res = $"Users: {CreateTableUsers()}{Environment.NewLine}";
            res += $"Products: {CreateTableProducts()}{Environment.NewLine}";
            res += $"Orders: {CreateTableOrders()}{Environment.NewLine}";
            res += $"Order_Items: {CreateTableOrderItems()}{Environment.NewLine}";
            return res;
        }

        public static string DeleteDatabase()
        {
            var res = $"Order_Items: {DeleteTableOrderItems()}{Environment.NewLine}";
            res += $"Orders: {DeleteTableOrders()}{Environment.NewLine}";
            res += $"Products: {DeleteTableProducts()}{Environment.NewLine}";
            res += $"Users: {DeleteTableUsers()}{Environment.NewLine}";
            return res;
        }

        public static string FillDatabase()
        {
            var res = $"Users: {InsertUsers()}{Environment.NewLine}";
            res += $"Products: {InsertProducts()}{Environment.NewLine}";
            res += $"Orders: {InsertOrders()}{Environment.NewLine}";
            res += $"Order_Items: {InsertOrderItems()}{Environment.NewLine}";
            return res;
        }

        private static bool CreateTableUsers()
        {
            var aux = "CREATE TABLE Users ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "name TEXT NOT NULL UNIQUE,"
                + "password TEXT NOT NULL,"
                + "phone TEXT NOT NULL,"
                + "suburb TEXT NOT NULL,"
                + "postal_code TEXT NOT NULL,"
                + "street TEXT NOT NULL,"
                + "ext_number INTEGER,"
                + "int_number INTEGER,"
                + "CHECK (postal_code GLOB '[0-9][0-9][0-9][0-9][0-9]'),"
                + "CHECK (phone GLOB '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"
                + "[0-9][0-9]'))";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool DeleteTableUsers()
        {
            var aux = "DROP TABLE Users";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool InsertUsers()
        {
            var aux1 = "INSERT INTO Users (name, password, phone, suburb, "
                + "postal_code, street, ext_number) "
                + $"VALUES ('Admin', '{CreateMD5.Hash("hola123.,")}', '5555555555', 'C.U.', "
                + "'04330', 'Investigación Cientifica', 10)";
            var aux2 = "INSERT INTO Users (name, password, phone, suburb, "
                + "postal_code, street, ext_number, int_number) "
                + $"VALUES ('Test', '{CreateMD5.Hash("123456")}', '5000000000', 'Zacatenco', "
                + "'25250', 'Queso', 10, 5)";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux1)
                && DatabaseConnection.ExecuteCommand(connection, aux2);
        }

        private static bool CreateTableProducts()
        {
            var aux = "CREATE TABLE Products ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "name TEXT NOT NULL UNIQUE,"
                + "description TEXT NOT NULL,"
                + "price INTEGER NOT NULL,"
                + "CHECK (price > 0))";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool DeleteTableProducts()
        {
            var aux = "DROP TABLE Products";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool InsertProducts()
        {
            var aux = new string[]{
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Hawaiana Chica', '25 cm: Jamón y Piña', "
                + "'40')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Hawaiana Mediana', '30 cm: Jamón y Piña', "
                + "'80')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Hawaiana Grande', '35 cm: Jamón y Piña', "
                + "'120')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Pepperoni Chica', '25 cm: Jamón y Piña', "
                + "'35')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Pepperoni Mediana', '30 cm: Jamón y Piña', "
                + "'70')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Pizza Pepperoni Grande', '35 cm: Jamón y Piña', "
                + "'110')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Coca Cola', '2.5 litros', '40')",
                "INSERT INTO Products (name, description, price) "
                + "VALUES ('Mirinda', '2 Litros', '37')" };
            var connection = DatabaseConnection.CreateConnection();
            var result = true;
            foreach (string str in aux)
            {
                result &= DatabaseConnection.ExecuteCommand(connection, str);
            }
            return result;
        }

        private static bool CreateTableOrders()
        {
            var aux = "CREATE TABLE Orders ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "order_date TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,"
                + "total INTEGER NOT NULL,"
                + "id_user INTEGER NOT NULL,"
                + "FOREIGN KEY (id_user) REFERENCES Users(id),"
                + "CHECK (total > 0))";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool DeleteTableOrders()
        {
            var aux = "DROP TABLE Orders";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool InsertOrders()
        {
            var aux = new string[]{
                "INSERT INTO Orders (total, id_user) "
                + "VALUES (120, 1)",
                "INSERT INTO Orders (total, id_user) "
                + "VALUES (367, 2)",
                "INSERT INTO Orders (total, id_user) "
                + "VALUES (270, 2)" };
            var connection = DatabaseConnection.CreateConnection();
            var result = true;
            foreach (string str in aux)
            {
                result &= DatabaseConnection.ExecuteCommand(connection, str);
            }
            return result;
        }
        
        private static bool CreateTableOrderItems()
        {
            var aux = "CREATE TABLE Order_Items ("
                + "id_product INTEGER NOT NULL,"
                + "id_order INTEGER NOT NULL,"
                + "quantity INTEGER NOT NULL,"
                + "PRIMARY KEY (id_product, id_order),"
                + "FOREIGN KEY (id_product) REFERENCES Products(id),"
                + "FOREIGN KEY (id_order) REFERENCES Orders(id))";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool DeleteTableOrderItems()
        {
            var aux = "DROP TABLE Order_Items";
            var connection = DatabaseConnection.CreateConnection();
            return DatabaseConnection.ExecuteCommand(connection, aux);
        }

        private static bool InsertOrderItems()
        {
            var aux = new string[]{
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (2, 1, 1)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (7, 1, 1)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (6, 2, 3)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (8, 2, 1)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (3, 3, 1)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (6, 3, 1)",
                "INSERT INTO Order_Items (id_product, id_order, quantity) "
                + "VALUES (7, 3, 1)" };
            var connection = DatabaseConnection.CreateConnection();
            var result = true;
            foreach (string str in aux)
            {
                result &= DatabaseConnection.ExecuteCommand(connection, str);
            }
            return result;
        }
    }
}
