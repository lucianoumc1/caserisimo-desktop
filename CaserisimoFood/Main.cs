using MySql.Data.MySqlClient;
using System.Data;

namespace CaserisimoFood
{
    public partial class frmMain : Form
    {
        //private int currentRowIndex = 0;
        int? IdChanging;

        private DBConnection DBConnection;
        private void CleanUpInputs()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtDetail.Text = "";
            cbxPaymentType.Text = "";
            txtPrice.Text = "";
            cbxDelivery.Text = "";
        }

        private void ToggleButtonState()
        {
            bool currentState = btnAdd.Enabled;

            btnAdd.Enabled = !currentState;
            btnAdd.Visible = !currentState;

            btnPatch.Enabled = currentState;
            btnPatch.Visible = currentState;

            btnCancel.Enabled = currentState;
            btnCancel.Visible = currentState;
        }

        private void loadDataResource()
        {
            string selectAllquery = "select * from order_list";
            var connection = DBConnection.getConnection();

            if (connection != null)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllquery, connection);

                var dt = new DataTable();
                adapter.Fill(dt);
                dtgvOrder.DataSource = dt;
                connection.Close();
            }
        }

        public frmMain()
        {
            InitializeComponent();
            DBConnection = new DBConnection();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadDataResource();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insertQuery = $"insert into order_list(customer, address, order_detail, method, price, delivery, state, reception) values('{txtName.Text}', '{txtAddress.Text}', '{txtDetail.Text}', '{cbxPaymentType.Text}', {float.Parse(txtPrice.Text)}, {int.Parse(cbxDelivery.Text)}, 'En preparacion', NOW())";

            var connection = DBConnection.getConnection();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                var response = MessageBox.Show(rowsAffected.ToString() + " Pedido agregado\n¿Desea imprimir el ticket?", "Aviso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    MessageBox.Show("imprimiendo...");
                }
                CleanUpInputs();
                connection.Close();
                loadDataResource();
            }
        }

        private void dtgvOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentRowIndex = e.RowIndex;

            string? idString = dtgvOrder.Rows[currentRowIndex].Cells[0].Value.ToString();
            IdChanging = int.Parse(idString);

            string? nombre = dtgvOrder.Rows[currentRowIndex].Cells[1].Value.ToString();
            string? direccion = dtgvOrder.Rows[currentRowIndex].Cells[2].Value.ToString();
            string? detalle = dtgvOrder.Rows[currentRowIndex].Cells[3].Value.ToString();
            string? pago = dtgvOrder.Rows[currentRowIndex].Cells[4].Value.ToString();
            string? precio = dtgvOrder.Rows[currentRowIndex].Cells[5].Value.ToString();
            string? delivery = dtgvOrder.Rows[currentRowIndex].Cells[6].Value.ToString();

            txtName.Text = nombre;
            txtAddress.Text = direccion;
            txtDetail.Text = detalle;
            cbxPaymentType.Text = pago;
            txtPrice.Text = precio;
            cbxDelivery.Text = delivery;

            ToggleButtonState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IdChanging = null;

            CleanUpInputs();
            ToggleButtonState();
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string detail = txtDetail.Text;
            string paymentType = cbxPaymentType.Text;
            string price = txtPrice.Text;
            string delivery = cbxDelivery.Text;

            string putQuery = $"update order_list set customer = '{name}', address ='{address}', order_detail = '{detail}', method ='{paymentType}', price = {price}, delivery = {delivery} where id = {IdChanging} limit 1;";

            var connection = DBConnection.getConnection();

            MySqlCommand command = new MySqlCommand(putQuery, connection);

            int rowsAffected = command.ExecuteNonQuery();

            var response = MessageBox.Show(rowsAffected.ToString() + " Pedido modificado\n¿Desea imprimir denuevo el ticket?", "Aviso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                MessageBox.Show("imprimiendo...");
            }
            connection.Close();

            IdChanging = null;
            CleanUpInputs();
            ToggleButtonState();
            loadDataResource();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //int totalOrder = dtgvOrder.RowCount;
            //float totalAmount = 0;

            //for (int i = 0; i < totalOrder; i++)
            //{
            //    totalAmount += float.Parse((string)dtgvOrder.Rows[i].Cells[5].Value);
            //}

            //MessageBox.Show(totalAmount.ToString());
        }

        private void dtgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string toggleOrderStatus(string initialState)
            //{
            //    List<string> states = new List<string>(["En preparacion", "Preparado", "En camino", "Entregado"]);

            //    int idxInitialState = states.IndexOf(initialState);
            //    int nextIdxState = idxInitialState == states.Count - 1 ? 0 : idxInitialState + 1;

            //    return states[nextIdxState];
            //}

            //int idxCell = e.ColumnIndex;
            //if (idxCell == 7)
            //{
            //    string currentState = dtgvOrder.Rows[e.RowIndex].Cells[idxCell].Value.ToString();
            //    string newState = toggleOrderStatus(currentState);
            //    dtgvOrder.Rows[e.RowIndex].Cells[idxCell].Value = newState;
            //}
        }

        private void btnTotalDeliveries_Click(object sender, EventArgs e)
        {
            float totalLupi = 0;
            float totalRhaego = 0;

            int totalOrder = dtgvOrder.RowCount;

            for (int i = 0; i < totalOrder; i++)
            {
                if (dtgvOrder.Rows[i].Cells[6].Value.ToString() == "LUPI")
                {
                    totalLupi++;
                }
                else
                {
                    totalRhaego++;
                }
            }

            MessageBox.Show($"Deliveris\nLupi: {totalLupi}\nRhaego: {totalRhaego}");
        }

    }
}
