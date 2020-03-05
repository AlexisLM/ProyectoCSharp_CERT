using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form1 : Form
    {
        readonly private string userId;
        private int productNum = 0;
        readonly private List<string> productIDs = new List<string>();
        private double totalCost = 0.0;

        public Form1()
        {
            InitializeComponent();
            this.userId = "0";
            OrderBtn.BackColor = ColorTranslator
                .FromHtml(Properties.Resources.Primary_accent);
        }

        public Form1(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            OrderBtn.BackColor = ColorTranslator
                .FromHtml(Properties.Resources.Primary_accent);
        }

        private TableLayoutPanel CreateProductControls(int pos, string name, string price)
        {
            var productTableLayout = new System.Windows.Forms.TableLayoutPanel();
            var productPictureBox = new System.Windows.Forms.PictureBox();
            var productLabel = new System.Windows.Forms.Label();
            var priceLabel = new System.Windows.Forms.Label();
            var qtyTableLayout = new System.Windows.Forms.TableLayoutPanel();
            var qtyLabel = new System.Windows.Forms.Label();
            var productPlusBtn = new System.Windows.Forms.Button();
            var productMinusBtn = new System.Windows.Forms.Button();
            // 
            // productTableLayout
            // 
            productTableLayout.BackColor = System.Drawing.SystemColors.Window;
            productTableLayout.ColumnCount = 1;
            productTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            productTableLayout.Controls.Add(productPictureBox, 0, 0);
            productTableLayout.Controls.Add(productLabel, 0, 1);
            productTableLayout.Controls.Add(priceLabel, 0, 2);
            productTableLayout.Controls.Add(qtyTableLayout, 0, 3);
            productTableLayout.Name = "productTableLayout" + pos;
            productTableLayout.RowCount = 4;
            productTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            productTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            productTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            productTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            productTableLayout.Size = new System.Drawing.Size(225, 177);
            // 
            // productPictureBox
            // 
            productPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            productPictureBox.Image = getProductImage(name);
            productPictureBox.Name = "productPictureBox" + pos;
            productPictureBox.Size = new System.Drawing.Size(167, 91);
            productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // productLabel
            // 
            productLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            productLabel.AutoSize = true;
            productLabel.Name = "productLabel" + pos;
            productLabel.Size = new System.Drawing.Size(35, 13);
            productLabel.Text = name;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Name = "priceLabel" + pos;
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.Text = $"${price}.00";
            // 
            // qtyTableLayout
            // 
            qtyTableLayout.ColumnCount = 3;
            qtyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            qtyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            qtyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            qtyTableLayout.Controls.Add(qtyLabel, 1, 0);
            qtyTableLayout.Controls.Add(productPlusBtn, 2, 0);
            qtyTableLayout.Controls.Add(productMinusBtn, 0, 0);
            qtyTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            qtyTableLayout.Name = "qtyTableLayout" + pos;
            qtyTableLayout.RowCount = 1;
            qtyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            qtyTableLayout.Size = new System.Drawing.Size(228, 34);
            // 
            // qtyLabel
            // 
            qtyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            qtyLabel.AutoSize = true;
            qtyLabel.Name = "qtyLabel" + pos;
            qtyLabel.Size = new System.Drawing.Size(35, 13);
            qtyLabel.Text = "0";
            // 
            // productPlusBtn
            // 
            productPlusBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            productPlusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            productPlusBtn.Name = "productPlusBtn" + pos;
            productPlusBtn.Size = new System.Drawing.Size(35, 22);
            productPlusBtn.Text = "+";
            productPlusBtn.UseVisualStyleBackColor = false;
            productPlusBtn.Click += new EventHandler(delegate (Object o, EventArgs a)
            {
                bool parsedQty = Int32.TryParse(qtyLabel.Text, out int qty);
                bool parsedPrice = Int32.TryParse(price, out int cost);
                if (parsedQty && parsedPrice)
                {
                    qty++;
                    this.totalCost += cost;
                    this.totalLabel.Text = $"{totalCost:c}";
                    qtyLabel.Text = qty.ToString();
                }
            });
            // 
            // productMinusBtn
            // 
            productMinusBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            productMinusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            productMinusBtn.Name = "productMinusBtn" + pos;
            productMinusBtn.Size = new System.Drawing.Size(35, 22);
            productMinusBtn.Text = "-";
            productMinusBtn.UseVisualStyleBackColor = false;
            productMinusBtn.Click += new EventHandler(delegate (Object o, EventArgs a)
            {
                bool parsedQty = Int32.TryParse(qtyLabel.Text, out int qty);
                bool parsedPrice = Int32.TryParse(price, out int cost);
                if (parsedQty && parsedPrice && qty > 0)
                {
                    qty--;
                    totalCost -= cost;
                    this.totalLabel.Text = $"{totalCost:c}";
                    qtyLabel.Text = qty.ToString();
                }
            });
            return productTableLayout;
        }

        private Bitmap getProductImage(String productName)
        {
            if (productName.Contains("Hawaiana"))
                return global::PizzaApp.Properties.Resources.hawaian;
            else if (productName.Contains("Pepperoni"))
                return global::PizzaApp.Properties.Resources.pepperoni;
            else if (productName.Contains("Coca Cola"))
                return global::PizzaApp.Properties.Resources.coke_img;
            else if (productName.Contains("Mirinda"))
                return global::PizzaApp.Properties.Resources.soda_img;
            else
                return null;
        }

        private void LoadProducts()
        {
            var connection = DatabaseConnection.CreateConnection();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT id, name, price FROM Products"; ;
                    var reader = command.ExecuteReader();
                    this.productNum = 0;
                    while (reader.Read())
                    {
                        this.productIDs.Add(reader[0].ToString());
                        this.mainFlowLayout.Controls.Add(CreateProductControls(this.productNum++, reader[1].ToString(), reader[2].ToString()));
                    }
                }
                catch (SQLiteException)
                {
                    transaction.Rollback();
                }
                transaction.Commit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (totalCost == 0.0)
                return;

            var connection = DatabaseConnection.CreateConnection();
            var orderQuery = $"INSERT INTO Orders (total, id_user) VALUES ({totalCost}, {userId})";
            if (DatabaseConnection.ExecuteCommand(connection, orderQuery))
            {
                var orderIdQuery = "SELECT last_insert_rowid()";
                var reader = DatabaseConnection.GetResultReader(connection, orderIdQuery);
                if (reader.Read())
                {
                    var orderId = reader[0].ToString();
                    for (int i = 0; i < this.productNum; i++)
                    {
                        var qty = this.Controls.Find("qtyLabel" + i, true)[0].Text;
                        if (qty.Equals("0"))
                            continue;
                        var orderItemQuery = $"INSERT INTO Order_Items "
                            + "(id_product, id_order, quantity) VALUES "
                            + $"({productIDs[i]}, {orderId}, {qty})";

                        DatabaseConnection.ExecuteCommand(connection, orderItemQuery);
                    }
                    reader.Close();
                    new Ticket(userId, orderId).Show();
                }
            }
            else
            {
                MessageBox.Show("No fue posible realizar su compra. Intente " +
                    "más tarde.");
            }

        }

        private void DisableSideMenuButtons()
        {
            OrderBtn.BackColor = Color.Transparent;
            AboutBtn.BackColor = Color.Transparent;
            ContactBtn.BackColor = Color.Transparent;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            DisableSideMenuButtons();
            OrderBtn.BackColor = ColorTranslator
                .FromHtml(Properties.Resources.Primary_accent);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            DisableSideMenuButtons();
            AboutBtn.BackColor = ColorTranslator
                .FromHtml(Properties.Resources.Primary_accent);

            String message = "Somos una empresa 100% mexicana que gusta de " +
                "hacer pizzas y hacer feliz al cliente.";

            MessageBox.Show(message);
            OrderBtn.PerformClick();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            DisableSideMenuButtons();
            ContactBtn.BackColor = ColorTranslator
                .FromHtml(Properties.Resources.Primary_accent);

            String message = "Teléfono: 55-12-34-56-78\n" +
                "Correo: childs_piksas@gmail.com";

            MessageBox.Show(message);
            OrderBtn.PerformClick();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
    }
}
