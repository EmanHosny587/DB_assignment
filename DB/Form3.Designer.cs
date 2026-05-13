namespace DB
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label sPECIALITY_IDLabel;
            System.Windows.Forms.Label sPECIALITY_NAMELabel;
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.sPECIALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPECIALITYTableAdapter = new DB.HospitalDataSetTableAdapters.SPECIALITYTableAdapter();
            this.tableAdapterManager = new DB.HospitalDataSetTableAdapters.TableAdapterManager();
            this.sPECIALITYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sPECIALITYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sPECIALITY_IDTextBox = new System.Windows.Forms.TextBox();
            this.sPECIALITY_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pRACTITIONERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACTITIONERTableAdapter = new DB.HospitalDataSetTableAdapters.PRACTITIONERTableAdapter();
            this.pRACTITIONERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPRACTITIHASASPECIALIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sPECIALITY_IDLabel = new System.Windows.Forms.Label();
            sPECIALITY_NAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingNavigator)).BeginInit();
            this.sPECIALITYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRACTITIHASASPECIALIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPECIALITYBindingSource
            // 
            this.sPECIALITYBindingSource.DataMember = "SPECIALITY";
            this.sPECIALITYBindingSource.DataSource = this.hospitalDataSet;
            // 
            // sPECIALITYTableAdapter
            // 
            this.sPECIALITYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLINICAL_SUMMARYTableAdapter = null;
            this.tableAdapterManager.IS_SCHEDULEDTableAdapter = null;
            this.tableAdapterManager.MEDICAL_FACILITY_BRANCHTableAdapter = null;
            this.tableAdapterManager.MEDICATIONTableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = null;
            this.tableAdapterManager.PRACTITIONER_BRANCHTableAdapter = null;
            this.tableAdapterManager.PRACTITIONERTableAdapter = this.pRACTITIONERTableAdapter;
            this.tableAdapterManager.PRESCRIBEDINTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.REGIONAL_HEALTHCARE_PROVIDERTableAdapter = null;
            this.tableAdapterManager.SPECIALITYTableAdapter = this.sPECIALITYTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sPECIALITYBindingNavigator
            // 
            this.sPECIALITYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sPECIALITYBindingNavigator.BindingSource = this.sPECIALITYBindingSource;
            this.sPECIALITYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sPECIALITYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sPECIALITYBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sPECIALITYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sPECIALITYBindingNavigatorSaveItem});
            this.sPECIALITYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sPECIALITYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sPECIALITYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sPECIALITYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sPECIALITYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sPECIALITYBindingNavigator.Name = "sPECIALITYBindingNavigator";
            this.sPECIALITYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sPECIALITYBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.sPECIALITYBindingNavigator.TabIndex = 0;
            this.sPECIALITYBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sPECIALITYBindingNavigatorSaveItem
            // 
            this.sPECIALITYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sPECIALITYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sPECIALITYBindingNavigatorSaveItem.Image")));
            this.sPECIALITYBindingNavigatorSaveItem.Name = "sPECIALITYBindingNavigatorSaveItem";
            this.sPECIALITYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sPECIALITYBindingNavigatorSaveItem.Text = "Save Data";
            this.sPECIALITYBindingNavigatorSaveItem.Click += new System.EventHandler(this.sPECIALITYBindingNavigatorSaveItem_Click);
            // 
            // sPECIALITY_IDLabel
            // 
            sPECIALITY_IDLabel.AutoSize = true;
            sPECIALITY_IDLabel.Location = new System.Drawing.Point(268, 63);
            sPECIALITY_IDLabel.Name = "sPECIALITY_IDLabel";
            sPECIALITY_IDLabel.Size = new System.Drawing.Size(102, 16);
            sPECIALITY_IDLabel.TabIndex = 1;
            sPECIALITY_IDLabel.Text = "SPECIALITY ID:";
            // 
            // sPECIALITY_IDTextBox
            // 
            this.sPECIALITY_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPECIALITYBindingSource, "SPECIALITY_ID", true));
            this.sPECIALITY_IDTextBox.Location = new System.Drawing.Point(402, 60);
            this.sPECIALITY_IDTextBox.Name = "sPECIALITY_IDTextBox";
            this.sPECIALITY_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.sPECIALITY_IDTextBox.TabIndex = 2;
            // 
            // sPECIALITY_NAMELabel
            // 
            sPECIALITY_NAMELabel.AutoSize = true;
            sPECIALITY_NAMELabel.Location = new System.Drawing.Point(268, 91);
            sPECIALITY_NAMELabel.Name = "sPECIALITY_NAMELabel";
            sPECIALITY_NAMELabel.Size = new System.Drawing.Size(128, 16);
            sPECIALITY_NAMELabel.TabIndex = 3;
            sPECIALITY_NAMELabel.Text = "SPECIALITY NAME:";
            // 
            // sPECIALITY_NAMETextBox
            // 
            this.sPECIALITY_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPECIALITYBindingSource, "SPECIALITY_NAME", true));
            this.sPECIALITY_NAMETextBox.Location = new System.Drawing.Point(402, 88);
            this.sPECIALITY_NAMETextBox.Name = "sPECIALITY_NAMETextBox";
            this.sPECIALITY_NAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.sPECIALITY_NAMETextBox.TabIndex = 4;
            // 
            // pRACTITIONERBindingSource
            // 
            this.pRACTITIONERBindingSource.DataMember = "PRACTITIONER";
            this.pRACTITIONERBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pRACTITIONERTableAdapter
            // 
            this.pRACTITIONERTableAdapter.ClearBeforeFill = true;
            // 
            // pRACTITIONERDataGridView
            // 
            this.pRACTITIONERDataGridView.AutoGenerateColumns = false;
            this.pRACTITIONERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRACTITIONERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pRACTITIONERDataGridView.DataSource = this.fKPRACTITIHASASPECIALIBindingSource;
            this.pRACTITIONERDataGridView.Location = new System.Drawing.Point(142, 144);
            this.pRACTITIONERDataGridView.Name = "pRACTITIONERDataGridView";
            this.pRACTITIONERDataGridView.RowHeadersWidth = 51;
            this.pRACTITIONERDataGridView.RowTemplate.Height = 24;
            this.pRACTITIONERDataGridView.Size = new System.Drawing.Size(496, 175);
            this.pRACTITIONERDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRACTITIONER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRACTITIONER_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SPECIALITY_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SPECIALITY_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MEDICAL_EXPERTISE";
            this.dataGridViewTextBoxColumn3.HeaderText = "MEDICAL_EXPERTISE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // fKPRACTITIHASASPECIALIBindingSource
            // 
            this.fKPRACTITIHASASPECIALIBindingSource.DataMember = "FK_PRACTITI_HASA_SPECIALI";
            this.fKPRACTITIHASASPECIALIBindingSource.DataSource = this.sPECIALITYBindingSource;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pRACTITIONERDataGridView);
            this.Controls.Add(sPECIALITY_IDLabel);
            this.Controls.Add(this.sPECIALITY_IDTextBox);
            this.Controls.Add(sPECIALITY_NAMELabel);
            this.Controls.Add(this.sPECIALITY_NAMETextBox);
            this.Controls.Add(this.sPECIALITYBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingNavigator)).EndInit();
            this.sPECIALITYBindingNavigator.ResumeLayout(false);
            this.sPECIALITYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRACTITIHASASPECIALIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource sPECIALITYBindingSource;
        private HospitalDataSetTableAdapters.SPECIALITYTableAdapter sPECIALITYTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sPECIALITYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sPECIALITYBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sPECIALITY_IDTextBox;
        private System.Windows.Forms.TextBox sPECIALITY_NAMETextBox;
        private HospitalDataSetTableAdapters.PRACTITIONERTableAdapter pRACTITIONERTableAdapter;
        private System.Windows.Forms.BindingSource pRACTITIONERBindingSource;
        private System.Windows.Forms.DataGridView pRACTITIONERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource fKPRACTITIHASASPECIALIBindingSource;
    }
}