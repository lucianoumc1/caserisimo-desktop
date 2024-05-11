namespace CaserisimoFood
{
    public partial class frmMain : Form
    {
        int currentRowIndex = 0;

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

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvOrder.Rows.Add(1, txtName.Text, txtAddress.Text, txtDetail.Text, cbxPaymentType.Text, txtPrice.Text, cbxDelivery.Text, "En preparacion");

            //var printQuest = MessageBoxButtons.YesNo;

            MessageBox.Show("Pedido agregado\n¿Desea imprimir el ticket?", "Aviso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            CleanUpInputs();
        }

        private void dtgvOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRowIndex = e.RowIndex;

            string nombre = dtgvOrder.Rows[currentRowIndex].Cells[1].Value.ToString();
            string direccion = dtgvOrder.Rows[currentRowIndex].Cells[2].Value.ToString();
            string detalle = dtgvOrder.Rows[currentRowIndex].Cells[3].Value.ToString();
            string pago = dtgvOrder.Rows[currentRowIndex].Cells[4].Value.ToString();
            string precio = dtgvOrder.Rows[currentRowIndex].Cells[5].Value.ToString();
            string delivery = dtgvOrder.Rows[currentRowIndex].Cells[6].Value.ToString();


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


            dtgvOrder.Rows[currentRowIndex].Cells[1].Value = name;
            dtgvOrder.Rows[currentRowIndex].Cells[2].Value = address;
            dtgvOrder.Rows[currentRowIndex].Cells[3].Value = detail;
            dtgvOrder.Rows[currentRowIndex].Cells[4].Value = paymentType;
            dtgvOrder.Rows[currentRowIndex].Cells[5].Value = price;
            dtgvOrder.Rows[currentRowIndex].Cells[6].Value = delivery;

            CleanUpInputs();

            currentRowIndex = 0;

            MessageBox.Show("Pedido modificado\n¿Desea imprimir el ticket?", "Aviso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ToggleButtonState();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int totalOrder = dtgvOrder.RowCount;
            float totalAmount = 0;

            for (int i = 0; i < totalOrder; i++)
            {
                totalAmount += float.Parse((string)dtgvOrder.Rows[i].Cells[5].Value);
            }

            MessageBox.Show(totalAmount.ToString());

        }

        private void dtgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string toggleOrderStatus(string initialState)
            {
                List<string> states = new List<string>(["En preparacion", "Preparado", "En camino", "Entregado"]);

                int idxInitialState = states.IndexOf(initialState);
                int nextIdxState = idxInitialState == states.Count - 1 ? 0 : idxInitialState + 1;

                return states[nextIdxState];
            }

            int idxCell = e.ColumnIndex;
            if (idxCell == 7)
            {
                string currentState = dtgvOrder.Rows[e.RowIndex].Cells[idxCell].Value.ToString();
                string newState = toggleOrderStatus(currentState);
                dtgvOrder.Rows[e.RowIndex].Cells[idxCell].Value = newState;
            }
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
