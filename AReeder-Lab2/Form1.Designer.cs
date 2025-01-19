namespace AReeder_Lab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tStripAscend = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCityName = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnMaxPop = new System.Windows.Forms.Button();
            this.btnMinPop = new System.Windows.Forms.Button();
            this.btnPopAsc = new System.Windows.Forms.Button();
            this.btnPopDesc = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataSet = new AReeder_Lab2.CityDataSet();
            this.cityTableAdapter = new AReeder_Lab2.CityDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new AReeder_Lab2.CityDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem,
            this.tStripAscend});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(799, 25);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // tStripAscend
            // 
            this.tStripAscend.Name = "tStripAscend";
            this.tStripAscend.Size = new System.Drawing.Size(23, 22);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(12, 40);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.Size = new System.Drawing.Size(574, 453);
            this.cityDataGridView.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 59);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCityName
            // 
            this.btnCityName.Location = new System.Drawing.Point(607, 232);
            this.btnCityName.Name = "btnCityName";
            this.btnCityName.Size = new System.Drawing.Size(143, 58);
            this.btnCityName.TabIndex = 3;
            this.btnCityName.Text = "List By City Name";
            this.btnCityName.UseVisualStyleBackColor = true;
            this.btnCityName.Click += new System.EventHandler(this.btnCityName_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(607, 168);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(143, 58);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Average Population";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnMaxPop
            // 
            this.btnMaxPop.Location = new System.Drawing.Point(607, 40);
            this.btnMaxPop.Name = "btnMaxPop";
            this.btnMaxPop.Size = new System.Drawing.Size(143, 58);
            this.btnMaxPop.TabIndex = 5;
            this.btnMaxPop.Text = "Max Population";
            this.btnMaxPop.UseVisualStyleBackColor = true;
            this.btnMaxPop.Click += new System.EventHandler(this.btnMaxPop_Click);
            // 
            // btnMinPop
            // 
            this.btnMinPop.Location = new System.Drawing.Point(607, 104);
            this.btnMinPop.Name = "btnMinPop";
            this.btnMinPop.Size = new System.Drawing.Size(143, 58);
            this.btnMinPop.TabIndex = 6;
            this.btnMinPop.Text = "Minimum Population";
            this.btnMinPop.UseVisualStyleBackColor = true;
            this.btnMinPop.Click += new System.EventHandler(this.btnMinPop_Click);
            // 
            // btnPopAsc
            // 
            this.btnPopAsc.Location = new System.Drawing.Point(607, 293);
            this.btnPopAsc.Name = "btnPopAsc";
            this.btnPopAsc.Size = new System.Drawing.Size(143, 58);
            this.btnPopAsc.TabIndex = 7;
            this.btnPopAsc.Text = "List Ascending";
            this.btnPopAsc.UseVisualStyleBackColor = true;
            this.btnPopAsc.Click += new System.EventHandler(this.btnPopAsc_Click);
            // 
            // btnPopDesc
            // 
            this.btnPopDesc.Location = new System.Drawing.Point(607, 357);
            this.btnPopDesc.Name = "btnPopDesc";
            this.btnPopDesc.Size = new System.Drawing.Size(143, 58);
            this.btnPopDesc.TabIndex = 8;
            this.btnPopDesc.Text = "List Descending";
            this.btnPopDesc.UseVisualStyleBackColor = true;
            this.btnPopDesc.Click += new System.EventHandler(this.btnPopDesc_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDataSet;
            // 
            // cityDataSet
            // 
            this.cityDataSet.DataSetName = "CityDataSet";
            this.cityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = AReeder_Lab2.CityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 505);
            this.Controls.Add(this.btnPopDesc);
            this.Controls.Add(this.btnPopAsc);
            this.Controls.Add(this.btnMinPop);
            this.Controls.Add(this.btnMaxPop);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnCityName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Population Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDataSet cityDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private CityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton tStripAscend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCityName;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnMaxPop;
        private System.Windows.Forms.Button btnMinPop;
        private System.Windows.Forms.Button btnPopAsc;
        private System.Windows.Forms.Button btnPopDesc;
    }
}

