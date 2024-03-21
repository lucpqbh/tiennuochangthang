namespace ManagerApp
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            tabControlDashboard = new TabControl();
            tabPageHome = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabPageWater = new TabPage();
            groupBoxData = new GroupBox();
            listViewWaterBill = new ListView();
            groupBoxUser = new GroupBox();
            btnupload = new Button();
            PictureBoxAvatar = new PictureBox();
            label8 = new Label();
            Delete = new Button();
            btnClear = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            txtWaterCurrentMonth = new TextBox();
            label7 = new Label();
            txtWaterLastMonth = new TextBox();
            label6 = new Label();
            txtPeople = new TextBox();
            label5 = new Label();
            cboCustomerType = new ComboBox();
            label4 = new Label();
            txtCustomer = new TextBox();
            label3 = new Label();
            tabPageExit = new TabPage();
            button1 = new Button();
            imageListTabPage = new ImageList(components);
            openFileDialogavt = new OpenFileDialog();
            tabControlDashboard.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageWater.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAvatar).BeginInit();
            tabPageExit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabPageHome);
            tabControlDashboard.Controls.Add(tabPageWater);
            tabControlDashboard.Controls.Add(tabPageExit);
            tabControlDashboard.Dock = DockStyle.Fill;
            tabControlDashboard.ImageList = imageListTabPage;
            tabControlDashboard.Location = new Point(0, 0);
            tabControlDashboard.Margin = new Padding(4, 5, 4, 5);
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(1143, 1020);
            tabControlDashboard.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(label2);
            tabPageHome.Controls.Add(label1);
            tabPageHome.ImageIndex = 0;
            tabPageHome.Location = new Point(4, 39);
            tabPageHome.Margin = new Padding(4, 5, 4, 5);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(4, 5, 4, 5);
            tabPageHome.Size = new Size(1135, 977);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(429, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 45);
            label2.TabIndex = 1;
            label2.Text = "Water Bill software";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(453, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 48);
            label1.TabIndex = 0;
            label1.Text = "Welcome You";
            // 
            // tabPageWater
            // 
            tabPageWater.Controls.Add(groupBoxData);
            tabPageWater.Controls.Add(groupBoxUser);
            tabPageWater.ImageIndex = 1;
            tabPageWater.Location = new Point(4, 39);
            tabPageWater.Margin = new Padding(4, 5, 4, 5);
            tabPageWater.Name = "tabPageWater";
            tabPageWater.Padding = new Padding(4, 5, 4, 5);
            tabPageWater.Size = new Size(1135, 977);
            tabPageWater.TabIndex = 1;
            tabPageWater.Text = "Water Bill";
            tabPageWater.UseVisualStyleBackColor = true;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(listViewWaterBill);
            groupBoxData.Location = new Point(11, 512);
            groupBoxData.Margin = new Padding(4, 5, 4, 5);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Padding = new Padding(4, 5, 4, 5);
            groupBoxData.Size = new Size(1106, 270);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data";
            // 
            // listViewWaterBill
            // 
            listViewWaterBill.Location = new Point(9, 37);
            listViewWaterBill.Margin = new Padding(4, 5, 4, 5);
            listViewWaterBill.Name = "listViewWaterBill";
            listViewWaterBill.Size = new Size(1087, 536);
            listViewWaterBill.TabIndex = 0;
            listViewWaterBill.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(btnupload);
            groupBoxUser.Controls.Add(PictureBoxAvatar);
            groupBoxUser.Controls.Add(label8);
            groupBoxUser.Controls.Add(Delete);
            groupBoxUser.Controls.Add(btnClear);
            groupBoxUser.Controls.Add(btnRemove);
            groupBoxUser.Controls.Add(btnAdd);
            groupBoxUser.Controls.Add(txtWaterCurrentMonth);
            groupBoxUser.Controls.Add(label7);
            groupBoxUser.Controls.Add(txtWaterLastMonth);
            groupBoxUser.Controls.Add(label6);
            groupBoxUser.Controls.Add(txtPeople);
            groupBoxUser.Controls.Add(label5);
            groupBoxUser.Controls.Add(cboCustomerType);
            groupBoxUser.Controls.Add(label4);
            groupBoxUser.Controls.Add(txtCustomer);
            groupBoxUser.Controls.Add(label3);
            groupBoxUser.Location = new Point(11, 13);
            groupBoxUser.Margin = new Padding(4, 5, 4, 5);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Padding = new Padding(4, 5, 4, 5);
            groupBoxUser.Size = new Size(1109, 462);
            groupBoxUser.TabIndex = 0;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "User's information";
            // 
            // btnupload
            // 
            btnupload.Location = new Point(390, 372);
            btnupload.Margin = new Padding(4, 5, 4, 5);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(114, 38);
            btnupload.TabIndex = 16;
            btnupload.Text = "Choose File";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // PictureBoxAvatar
            // 
            PictureBoxAvatar.Location = new Point(201, 277);
            PictureBoxAvatar.Margin = new Padding(4, 5, 4, 5);
            PictureBoxAvatar.Name = "PictureBoxAvatar";
            PictureBoxAvatar.Size = new Size(161, 168);
            PictureBoxAvatar.TabIndex = 15;
            PictureBoxAvatar.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 317);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 14;
            label8.Text = "iamge";
            // 
            // Delete
            // 
            Delete.Location = new Point(864, 208);
            Delete.Margin = new Padding(4, 5, 4, 5);
            Delete.Name = "Delete";
            Delete.Size = new Size(107, 52);
            Delete.TabIndex = 13;
            Delete.Text = "Delete All";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += button2_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(993, 210);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 50);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(694, 208);
            btnRemove.Margin = new Padding(4, 5, 4, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 50);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(579, 210);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 50);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add +";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWaterCurrentMonth
            // 
            txtWaterCurrentMonth.Location = new Point(800, 123);
            txtWaterCurrentMonth.Margin = new Padding(4, 5, 4, 5);
            txtWaterCurrentMonth.Name = "txtWaterCurrentMonth";
            txtWaterCurrentMonth.Size = new Size(268, 31);
            txtWaterCurrentMonth.TabIndex = 9;
            txtWaterCurrentMonth.TextChanged += txtWaterCurrentMonth_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(606, 137);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 8;
            label7.Text = "Water current month";
            // 
            // txtWaterLastMonth
            // 
            txtWaterLastMonth.Location = new Point(800, 45);
            txtWaterLastMonth.Margin = new Padding(4, 5, 4, 5);
            txtWaterLastMonth.Name = "txtWaterLastMonth";
            txtWaterLastMonth.Size = new Size(268, 31);
            txtWaterLastMonth.TabIndex = 7;
            txtWaterLastMonth.TextChanged += txtWaterLastMonth_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(637, 58);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 6;
            label6.Text = "Water last month";
            // 
            // txtPeople
            // 
            txtPeople.Enabled = false;
            txtPeople.Location = new Point(201, 208);
            txtPeople.Margin = new Padding(4, 5, 4, 5);
            txtPeople.Name = "txtPeople";
            txtPeople.Size = new Size(353, 31);
            txtPeople.TabIndex = 5;
            txtPeople.TextChanged += txtPeople_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 222);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "People";
            // 
            // cboCustomerType
            // 
            cboCustomerType.FormattingEnabled = true;
            cboCustomerType.Items.AddRange(new object[] { "Household", "Administrative", "Production", "Business" });
            cboCustomerType.Location = new Point(201, 132);
            cboCustomerType.Margin = new Padding(4, 5, 4, 5);
            cboCustomerType.Name = "cboCustomerType";
            cboCustomerType.Size = new Size(350, 33);
            cboCustomerType.TabIndex = 3;
            cboCustomerType.SelectedIndexChanged += cboCustomerType_SelectedIndexChanged;
            cboCustomerType.DropDownClosed += cboCustomerType_DropDownClosed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 2;
            label4.Text = "Customer type";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(201, 45);
            txtCustomer.Margin = new Padding(4, 5, 4, 5);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(353, 31);
            txtCustomer.TabIndex = 1;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Customer";
            label3.Click += label3_Click;
            // 
            // tabPageExit
            // 
            tabPageExit.Controls.Add(button1);
            tabPageExit.ImageIndex = 2;
            tabPageExit.Location = new Point(4, 39);
            tabPageExit.Margin = new Padding(4, 5, 4, 5);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Padding = new Padding(4, 5, 4, 5);
            tabPageExit.Size = new Size(1135, 977);
            tabPageExit.TabIndex = 2;
            tabPageExit.Text = "Exit Application";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(411, 38);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(283, 100);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageListTabPage
            // 
            imageListTabPage.ColorDepth = ColorDepth.Depth8Bit;
            imageListTabPage.ImageStream = (ImageListStreamer)resources.GetObject("imageListTabPage.ImageStream");
            imageListTabPage.TransparentColor = Color.Transparent;
            imageListTabPage.Images.SetKeyName(0, "Home-icon.png");
            imageListTabPage.Images.SetKeyName(1, "Bill-icon.png");
            imageListTabPage.Images.SetKeyName(2, "Users-Exit-icon.png");
            // 
            // openFileDialogavt
            // 
            openFileDialogavt.FileName = "openFileDialog1";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 1020);
            Controls.Add(tabControlDashboard);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDashboard";
            Text = "Dashboard";
            Load += FormDashboard_Load;
            tabControlDashboard.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPageWater.ResumeLayout(false);
            groupBoxData.ResumeLayout(false);
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAvatar).EndInit();
            tabPageExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDashboard;
        private TabPage tabPageHome;
        private TabPage tabPageWater;
        private ImageList imageListTabPage;
        private Label label2;
        private Label label1;
        private TabPage tabPageExit;
        private Button button1;
        private GroupBox groupBoxUser;
        private Label label4;
        private TextBox txtCustomer;
        private Label label3;
        private Label label5;
        private ComboBox cboCustomerType;
        private TextBox txtWaterLastMonth;
        private Label label6;
        private TextBox txtPeople;
        private Button btnClear;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtWaterCurrentMonth;
        private Label label7;
        private GroupBox groupBoxData;
        private ListView listViewWaterBill;
        private Button Delete;
        private Button btnupload;
        private PictureBox PictureBoxAvatar;
        private Label label8;
        private OpenFileDialog openFileDialogavt;
    }
}