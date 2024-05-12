namespace CaserisimoFood
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvOrder = new DataGridView();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtAddress = new TextBox();
            txtDetail = new TextBox();
            lblName = new Label();
            lblPrice = new Label();
            lblDetail = new Label();
            lblAdress = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbxPaymentType = new ComboBox();
            cbxDelivery = new ComboBox();
            lblPaymentType = new Label();
            lblDelivery = new Label();
            btnAdd = new Button();
            btnPatch = new Button();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTotal = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnTotalDeliveries = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvOrder
            // 
            dtgvOrder.AllowUserToAddRows = false;
            dtgvOrder.AllowUserToDeleteRows = false;
            dtgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Location = new Point(328, 418);
            dtgvOrder.Margin = new Padding(4);
            dtgvOrder.Name = "dtgvOrder";
            dtgvOrder.ReadOnly = true;
            dtgvOrder.Size = new Size(1084, 370);
            dtgvOrder.TabIndex = 1;
            dtgvOrder.CellContentDoubleClick += dtgvOrder_CellContentDoubleClick;
            dtgvOrder.RowHeaderMouseDoubleClick += dtgvOrder_RowHeaderMouseDoubleClick;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(338, 201);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 29);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(551, 201);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 29);
            txtPrice.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(338, 297);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(336, 91);
            txtAddress.TabIndex = 4;
            // 
            // txtDetail
            // 
            txtDetail.Font = new Font("Segoe UI", 12F);
            txtDetail.Location = new Point(711, 297);
            txtDetail.Margin = new Padding(4);
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(323, 91);
            txtDetail.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(338, 178);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 19);
            lblName.TabIndex = 6;
            lblName.Text = "Nombre";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(551, 178);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 19);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Precio";
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Location = new Point(711, 274);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(57, 19);
            lblDetail.TabIndex = 8;
            lblDetail.Text = "Detalle";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(338, 274);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(74, 19);
            lblAdress.TabIndex = 9;
            lblAdress.Text = "Dirección";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 29);
            dateTimePicker1.TabIndex = 11;
            // 
            // cbxPaymentType
            // 
            cbxPaymentType.FormattingEnabled = true;
            cbxPaymentType.Items.AddRange(new object[] { "EFECT", "TRANSF" });
            cbxPaymentType.Location = new Point(770, 203);
            cbxPaymentType.Name = "cbxPaymentType";
            cbxPaymentType.Size = new Size(121, 27);
            cbxPaymentType.TabIndex = 12;
            // 
            // cbxDelivery
            // 
            cbxDelivery.FormattingEnabled = true;
            cbxDelivery.Items.AddRange(new object[] { "RHAEGO", "LUPI" });
            cbxDelivery.Location = new Point(913, 203);
            cbxDelivery.Name = "cbxDelivery";
            cbxDelivery.Size = new Size(121, 27);
            cbxDelivery.TabIndex = 13;
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Location = new Point(770, 181);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(44, 19);
            lblPaymentType.TabIndex = 14;
            lblPaymentType.Text = "Pago";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Location = new Point(913, 181);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(66, 19);
            lblDelivery.TabIndex = 15;
            lblDelivery.Text = "Delivery";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1067, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 40);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPatch
            // 
            btnPatch.Enabled = false;
            btnPatch.Location = new Point(1067, 302);
            btnPatch.Name = "btnPatch";
            btnPatch.Size = new Size(146, 40);
            btnPatch.TabIndex = 17;
            btnPatch.Text = "Editar";
            btnPatch.UseVisualStyleBackColor = true;
            btnPatch.Visible = false;
            btnPatch.Click += btnPatch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(1067, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 40);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnTotal, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 1, 2);
            tableLayoutPanel1.Controls.Add(button5, 0, 3);
            tableLayoutPanel1.Controls.Add(button6, 1, 3);
            tableLayoutPanel1.Controls.Add(btnTotalDeliveries, 1, 1);
            tableLayoutPanel1.Location = new Point(1458, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.1492538F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8507462F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 239F));
            tableLayoutPanel1.Size = new Size(257, 767);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(3, 238);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(122, 94);
            btnTotal.TabIndex = 0;
            btnTotal.Text = "Totalizar";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 338);
            button3.Name = "button3";
            button3.Size = new Size(122, 91);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(131, 338);
            button4.Name = "button4";
            button4.Size = new Size(122, 91);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 435);
            button5.Name = "button5";
            button5.Size = new Size(122, 89);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(131, 435);
            button6.Name = "button6";
            button6.Size = new Size(122, 89);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnTotalDeliveries
            // 
            btnTotalDeliveries.Location = new Point(131, 238);
            btnTotalDeliveries.Name = "btnTotalDeliveries";
            btnTotalDeliveries.Size = new Size(122, 94);
            btnTotalDeliveries.TabIndex = 1;
            btnTotalDeliveries.Text = "Total Delivery";
            btnTotalDeliveries.UseVisualStyleBackColor = true;
            btnTotalDeliveries.Click += btnTotalDeliveries_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 801);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnCancel);
            Controls.Add(btnPatch);
            Controls.Add(btnAdd);
            Controls.Add(lblDelivery);
            Controls.Add(lblPaymentType);
            Controls.Add(cbxDelivery);
            Controls.Add(cbxPaymentType);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblAdress);
            Controls.Add(lblDetail);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(txtDetail);
            Controls.Add(txtAddress);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(dtgvOrder);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvOrder;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtAddress;
        private TextBox txtDetail;
        private Label lblName;
        private Label lblPrice;
        private Label lblDetail;
        private Label lblAdress;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbxPaymentType;
        private ComboBox cbxDelivery;
        private Label lblPaymentType;
        private Label lblDelivery;
        private Button btnAdd;
        private Button btnPatch;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button btnTotal;
        private Button btnTotalDeliveries;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}