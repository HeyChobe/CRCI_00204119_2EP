namespace Preparcial.Vista
{
    partial class FrmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewUserTab = new System.Windows.Forms.TabPage();
            this.bttnCreateUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.dgvCreateUser = new System.Windows.Forms.DataGridView();
            this.inventaryTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttnUpdateStockInventary = new System.Windows.Forms.Button();
            this.txtUpdateStockInventary = new System.Windows.Forms.TextBox();
            this.txtUpdateStockIdInventary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnDeleteInventary = new System.Windows.Forms.Button();
            this.txtDeleteInventary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnAddInventary = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescriptionInventary = new System.Windows.Forms.TextBox();
            this.txtPriceInventary = new System.Windows.Forms.TextBox();
            this.txtStockInventary = new System.Windows.Forms.TextBox();
            this.txtProductNameInventary = new System.Windows.Forms.TextBox();
            this.dgvInventary = new System.Windows.Forms.DataGridView();
            this.createOrderTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMyOrders = new System.Windows.Forms.DataGridView();
            this.bttnMakeOrder = new System.Windows.Forms.Button();
            this.txtMakeOrderQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProductMakeOrder = new System.Windows.Forms.ComboBox();
            this.viewOrdersTab = new System.Windows.Forms.TabPage();
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.createNewUserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCreateUser)).BeginInit();
            this.inventaryTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvInventary)).BeginInit();
            this.createOrderTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMyOrders)).BeginInit();
            this.viewOrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.createNewUserTab);
            this.tabControl1.Controls.Add(this.inventaryTab);
            this.tabControl1.Controls.Add(this.createOrderTab);
            this.tabControl1.Controls.Add(this.viewOrdersTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 89);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 313);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.Transparent;
            this.generalTab.Controls.Add(this.label1);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Margin = new System.Windows.Forms.Padding(2);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(2);
            this.generalTab.Size = new System.Drawing.Size(640, 287);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNewUserTab
            // 
            this.createNewUserTab.Controls.Add(this.bttnCreateUser);
            this.createNewUserTab.Controls.Add(this.label2);
            this.createNewUserTab.Controls.Add(this.txtNewUser);
            this.createNewUserTab.Controls.Add(this.dgvCreateUser);
            this.createNewUserTab.Location = new System.Drawing.Point(4, 22);
            this.createNewUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.createNewUserTab.Name = "createNewUserTab";
            this.createNewUserTab.Padding = new System.Windows.Forms.Padding(2);
            this.createNewUserTab.Size = new System.Drawing.Size(640, 287);
            this.createNewUserTab.TabIndex = 1;
            this.createNewUserTab.Text = "Crear usuario";
            this.createNewUserTab.UseVisualStyleBackColor = true;
            // 
            // bttnCreateUser
            // 
            this.bttnCreateUser.Location = new System.Drawing.Point(437, 15);
            this.bttnCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCreateUser.Name = "bttnCreateUser";
            this.bttnCreateUser.Size = new System.Drawing.Size(78, 22);
            this.bttnCreateUser.TabIndex = 3;
            this.bttnCreateUser.Text = "Agregar";
            this.bttnCreateUser.UseVisualStyleBackColor = true;
            this.bttnCreateUser.Click += new System.EventHandler(this.bttnCreateUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo usuario";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(250, 17);
            this.txtNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(149, 20);
            this.txtNewUser.TabIndex = 1;
            // 
            // dgvCreateUser
            // 
            this.dgvCreateUser.AllowUserToAddRows = false;
            this.dgvCreateUser.AllowUserToDeleteRows = false;
            this.dgvCreateUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateUser.Location = new System.Drawing.Point(4, 60);
            this.dgvCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCreateUser.Name = "dgvCreateUser";
            this.dgvCreateUser.ReadOnly = true;
            this.dgvCreateUser.RowHeadersWidth = 51;
            this.dgvCreateUser.RowTemplate.Height = 24;
            this.dgvCreateUser.Size = new System.Drawing.Size(633, 224);
            this.dgvCreateUser.TabIndex = 0;
            // 
            // inventaryTab
            // 
            this.inventaryTab.Controls.Add(this.groupBox3);
            this.inventaryTab.Controls.Add(this.groupBox2);
            this.inventaryTab.Controls.Add(this.groupBox1);
            this.inventaryTab.Controls.Add(this.dgvInventary);
            this.inventaryTab.Location = new System.Drawing.Point(4, 22);
            this.inventaryTab.Margin = new System.Windows.Forms.Padding(2);
            this.inventaryTab.Name = "inventaryTab";
            this.inventaryTab.Size = new System.Drawing.Size(640, 287);
            this.inventaryTab.TabIndex = 2;
            this.inventaryTab.Text = "Inventario";
            this.inventaryTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttnUpdateStockInventary);
            this.groupBox3.Controls.Add(this.txtUpdateStockInventary);
            this.groupBox3.Controls.Add(this.txtUpdateStockIdInventary);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(454, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 85);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar producto";
            // 
            // bttnUpdateStockInventary
            // 
            this.bttnUpdateStockInventary.Location = new System.Drawing.Point(4, 54);
            this.bttnUpdateStockInventary.Margin = new System.Windows.Forms.Padding(2);
            this.bttnUpdateStockInventary.Name = "bttnUpdateStockInventary";
            this.bttnUpdateStockInventary.Size = new System.Drawing.Size(165, 23);
            this.bttnUpdateStockInventary.TabIndex = 2;
            this.bttnUpdateStockInventary.Text = "Actualizar";
            this.bttnUpdateStockInventary.UseVisualStyleBackColor = true;
            this.bttnUpdateStockInventary.Click += new System.EventHandler(this.bttnUpdateStockInventary_Click);
            // 
            // txtUpdateStockInventary
            // 
            this.txtUpdateStockInventary.Location = new System.Drawing.Point(143, 25);
            this.txtUpdateStockInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateStockInventary.Name = "txtUpdateStockInventary";
            this.txtUpdateStockInventary.Size = new System.Drawing.Size(27, 20);
            this.txtUpdateStockInventary.TabIndex = 0;
            // 
            // txtUpdateStockIdInventary
            // 
            this.txtUpdateStockIdInventary.Location = new System.Drawing.Point(68, 27);
            this.txtUpdateStockIdInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateStockIdInventary.Name = "txtUpdateStockIdInventary";
            this.txtUpdateStockIdInventary.Size = new System.Drawing.Size(27, 20);
            this.txtUpdateStockIdInventary.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Id producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnDeleteInventary);
            this.groupBox2.Controls.Add(this.txtDeleteInventary);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(314, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(122, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar producto";
            // 
            // bttnDeleteInventary
            // 
            this.bttnDeleteInventary.Location = new System.Drawing.Point(4, 54);
            this.bttnDeleteInventary.Margin = new System.Windows.Forms.Padding(2);
            this.bttnDeleteInventary.Name = "bttnDeleteInventary";
            this.bttnDeleteInventary.Size = new System.Drawing.Size(113, 23);
            this.bttnDeleteInventary.TabIndex = 2;
            this.bttnDeleteInventary.Text = "Eliminar";
            this.bttnDeleteInventary.UseVisualStyleBackColor = true;
            this.bttnDeleteInventary.Click += new System.EventHandler(this.bttnDeleteInventary_Click);
            // 
            // txtDeleteInventary
            // 
            this.txtDeleteInventary.Location = new System.Drawing.Point(68, 27);
            this.txtDeleteInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeleteInventary.Name = "txtDeleteInventary";
            this.txtDeleteInventary.Size = new System.Drawing.Size(50, 20);
            this.txtDeleteInventary.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnAddInventary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescriptionInventary);
            this.groupBox1.Controls.Add(this.txtPriceInventary);
            this.groupBox1.Controls.Add(this.txtStockInventary);
            this.groupBox1.Controls.Add(this.txtProductNameInventary);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(297, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar producto";
            // 
            // bttnAddInventary
            // 
            this.bttnAddInventary.Location = new System.Drawing.Point(236, 22);
            this.bttnAddInventary.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAddInventary.Name = "bttnAddInventary";
            this.bttnAddInventary.Size = new System.Drawing.Size(50, 54);
            this.bttnAddInventary.TabIndex = 2;
            this.bttnAddInventary.Text = "Anadir";
            this.bttnAddInventary.UseVisualStyleBackColor = true;
            this.bttnAddInventary.Click += new System.EventHandler(this.bttnAddInventary_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Producto";
            // 
            // txtDescriptionInventary
            // 
            this.txtDescriptionInventary.Location = new System.Drawing.Point(74, 63);
            this.txtDescriptionInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriptionInventary.Name = "txtDescriptionInventary";
            this.txtDescriptionInventary.Size = new System.Drawing.Size(89, 20);
            this.txtDescriptionInventary.TabIndex = 0;
            // 
            // txtPriceInventary
            // 
            this.txtPriceInventary.Location = new System.Drawing.Point(74, 40);
            this.txtPriceInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceInventary.Name = "txtPriceInventary";
            this.txtPriceInventary.Size = new System.Drawing.Size(89, 20);
            this.txtPriceInventary.TabIndex = 0;
            // 
            // txtStockInventary
            // 
            this.txtStockInventary.Location = new System.Drawing.Point(173, 37);
            this.txtStockInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockInventary.Name = "txtStockInventary";
            this.txtStockInventary.Size = new System.Drawing.Size(50, 20);
            this.txtStockInventary.TabIndex = 0;
            // 
            // txtProductNameInventary
            // 
            this.txtProductNameInventary.Location = new System.Drawing.Point(74, 17);
            this.txtProductNameInventary.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductNameInventary.Name = "txtProductNameInventary";
            this.txtProductNameInventary.Size = new System.Drawing.Size(89, 20);
            this.txtProductNameInventary.TabIndex = 0;
            // 
            // dgvInventary
            // 
            this.dgvInventary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventary.Location = new System.Drawing.Point(12, 128);
            this.dgvInventary.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventary.Name = "dgvInventary";
            this.dgvInventary.RowHeadersWidth = 51;
            this.dgvInventary.RowTemplate.Height = 24;
            this.dgvInventary.Size = new System.Drawing.Size(619, 149);
            this.dgvInventary.TabIndex = 0;
            // 
            // createOrderTab
            // 
            this.createOrderTab.Controls.Add(this.groupBox4);
            this.createOrderTab.Location = new System.Drawing.Point(4, 22);
            this.createOrderTab.Margin = new System.Windows.Forms.Padding(2);
            this.createOrderTab.Name = "createOrderTab";
            this.createOrderTab.Size = new System.Drawing.Size(640, 287);
            this.createOrderTab.TabIndex = 4;
            this.createOrderTab.Text = "Hacer pedido/Ver mis pedidos";
            this.createOrderTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMyOrders);
            this.groupBox4.Controls.Add(this.bttnMakeOrder);
            this.groupBox4.Controls.Add(this.txtMakeOrderQuantity);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cmbProductMakeOrder);
            this.groupBox4.Location = new System.Drawing.Point(14, 37);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(614, 241);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Realizar un pedido";
            // 
            // dgvMyOrders
            // 
            this.dgvMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrders.Location = new System.Drawing.Point(4, 65);
            this.dgvMyOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMyOrders.Name = "dgvMyOrders";
            this.dgvMyOrders.RowHeadersWidth = 51;
            this.dgvMyOrders.RowTemplate.Height = 24;
            this.dgvMyOrders.Size = new System.Drawing.Size(604, 167);
            this.dgvMyOrders.TabIndex = 4;
            // 
            // bttnMakeOrder
            // 
            this.bttnMakeOrder.Location = new System.Drawing.Point(463, 25);
            this.bttnMakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.bttnMakeOrder.Name = "bttnMakeOrder";
            this.bttnMakeOrder.Size = new System.Drawing.Size(129, 19);
            this.bttnMakeOrder.TabIndex = 3;
            this.bttnMakeOrder.Text = "Hacer pedido";
            this.bttnMakeOrder.UseVisualStyleBackColor = true;
            this.bttnMakeOrder.Click += new System.EventHandler(this.bttnMakeOrder_Click);
            // 
            // txtMakeOrderQuantity
            // 
            this.txtMakeOrderQuantity.Location = new System.Drawing.Point(300, 28);
            this.txtMakeOrderQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtMakeOrderQuantity.Name = "txtMakeOrderQuantity";
            this.txtMakeOrderQuantity.Size = new System.Drawing.Size(103, 20);
            this.txtMakeOrderQuantity.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Producto";
            // 
            // cmbProductMakeOrder
            // 
            this.cmbProductMakeOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductMakeOrder.FormattingEnabled = true;
            this.cmbProductMakeOrder.Location = new System.Drawing.Point(76, 24);
            this.cmbProductMakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductMakeOrder.Name = "cmbProductMakeOrder";
            this.cmbProductMakeOrder.Size = new System.Drawing.Size(105, 21);
            this.cmbProductMakeOrder.TabIndex = 0;
            // 
            // viewOrdersTab
            // 
            this.viewOrdersTab.Controls.Add(this.dgvAllOrders);
            this.viewOrdersTab.Location = new System.Drawing.Point(4, 22);
            this.viewOrdersTab.Margin = new System.Windows.Forms.Padding(2);
            this.viewOrdersTab.Name = "viewOrdersTab";
            this.viewOrdersTab.Size = new System.Drawing.Size(640, 287);
            this.viewOrdersTab.TabIndex = 3;
            this.viewOrdersTab.Text = "Ver pedidos";
            this.viewOrdersTab.UseVisualStyleBackColor = true;
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.AllowUserToAddRows = false;
            this.dgvAllOrders.AllowUserToDeleteRows = false;
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.Location = new System.Drawing.Point(9, 13);
            this.dgvAllOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.ReadOnly = true;
            this.dgvAllOrders.RowHeadersWidth = 51;
            this.dgvAllOrders.RowTemplate.Height = 24;
            this.dgvAllOrders.Size = new System.Drawing.Size(625, 266);
            this.dgvAllOrders.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 411);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.createNewUserTab.ResumeLayout(false);
            this.createNewUserTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCreateUser)).EndInit();
            this.inventaryTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvInventary)).EndInit();
            this.createOrderTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMyOrders)).EndInit();
            this.viewOrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAllOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnAddInventary;
        private System.Windows.Forms.Button bttnCreateUser;
        private System.Windows.Forms.Button bttnDeleteInventary;
        private System.Windows.Forms.Button bttnMakeOrder;
        private System.Windows.Forms.Button bttnUpdateStockInventary;
        private System.Windows.Forms.ComboBox cmbProductMakeOrder;
        private System.Windows.Forms.TabPage createNewUserTab;
        private System.Windows.Forms.TabPage createOrderTab;
        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.DataGridView dgvCreateUser;
        private System.Windows.Forms.DataGridView dgvInventary;
        private System.Windows.Forms.DataGridView dgvMyOrders;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage inventaryTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtDeleteInventary;
        private System.Windows.Forms.TextBox txtDescriptionInventary;
        private System.Windows.Forms.TextBox txtMakeOrderQuantity;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtPriceInventary;
        private System.Windows.Forms.TextBox txtProductNameInventary;
        private System.Windows.Forms.TextBox txtStockInventary;
        private System.Windows.Forms.TextBox txtUpdateStockIdInventary;
        private System.Windows.Forms.TextBox txtUpdateStockInventary;
        private System.Windows.Forms.TabPage viewOrdersTab;

        #endregion
    }
}