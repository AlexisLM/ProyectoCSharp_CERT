using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Ticket : Form
    {
        readonly private String orderID;
        readonly private String userID;

        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(String userID, String orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            this.userID = userID;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            string query = "SELECT name, price, quantity " +
                           "FROM Order_Items, Products " +
                           $"WHERE Order_Items.id_order = {orderID} AND " +
                                "Products.id = Order_Items.id_product";

            var connection = DatabaseConnection.CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = query;

            var reader = command.ExecuteReader();

            string listFood = "";
            double totalPriceItem;
            double total;

            while (reader.Read())
            {
                totalPriceItem = Double.Parse(reader[1].ToString()) * 
                    Double.Parse(reader[2].ToString());
                listFood += $"{reader[0],-25} {reader[2],2}x{reader[1],-10:c} " +
                    $"{totalPriceItem,10:c}\n";
            }

            query = $"SELECT total FROM Orders WHERE id = {orderID}";
            total = Double.Parse(DatabaseConnection.ReadResult(connection, query));

            query = "SELECT name, phone, street, ext_number, suburb, " +
                    $"postal_code FROM Users WHERE id = {userID}";

            reader.Close();

            command.CommandText = query;
            reader = command.ExecuteReader();
            reader.Read();

            userLabel.Text = reader[0].ToString();
            addressLabel.Text = $"La orden se entregará en {reader[2]}, " +
                $"{reader[3]}, {reader[4]}. CP. {reader[5]}.\n\n" +
                $"En caso de un contratiempo se llamará al {reader[1]}.";

            foodItems.Text = listFood;
            dateLabel.Text = String.Format("{0:G}", DateTime.Now);
            totalPriceLabel.Text = $"{total,10:c}";

            reader.Close();
            connection.Close();
        }
    }
}
