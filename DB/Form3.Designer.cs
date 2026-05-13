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
            System.Windows.Forms.Label sPECIALITY_IDLabel;
            System.Windows.Forms.Label sPECIALITY_NAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button goToForm3;
            System.Windows.Forms.Button goToForm1;
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.sPECIALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPECIALITYTableAdapter = new DB.HospitalDataSetTableAdapters.SPECIALITYTableAdapter();
            this.tableAdapterManager = new DB.HospitalDataSetTableAdapters.TableAdapterManager();
            this.pRACTITIONERTableAdapter = new DB.HospitalDataSetTableAdapters.PRACTITIONERTableAdapter();
            this.sPECIALITYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sPECIALITYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sPECIALITY_IDTextBox = new System.Windows.Forms.TextBox();
            this.sPECIALITY_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pRACTITIONERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACTITIONERDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPRACTITIHASASPECIALIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sPECIALITY_IDLabel = new System.Windows.Forms.Label();
            sPECIALITY_NAMELabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            goToForm3 = new System.Windows.Forms.Button();
            goToForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPECIALITYBindingNavigator)).BeginInit();
            this.sPECIALITYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRACTITIHASASPECIALIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPECIALITY_IDLabel
            // 
            sPECIALITY_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            sPECIALITY_IDLabel.AutoSize = true;
            sPECIALITY_IDLabel.Location = new System.Drawing.Point(619, 219);
            sPECIALITY_IDLabel.Name = "sPECIALITY_IDLabel";
            sPECIALITY_IDLabel.Size = new System.Drawing.Size(116, 16);
            sPECIALITY_IDLabel.TabIndex = 1;
            sPECIALITY_IDLabel.Text = "SPECIALITY ID:";
            // 
            // sPECIALITY_NAMELabel
            // 
            sPECIALITY_NAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            sPECIALITY_NAMELabel.AutoSize = true;
            sPECIALITY_NAMELabel.Location = new System.Drawing.Point(619, 247);
            sPECIALITY_NAMELabel.Name = "sPECIALITY_NAMELabel";
            sPECIALITY_NAMELabel.Size = new System.Drawing.Size(144, 16);
            sPECIALITY_NAMELabel.TabIndex = 3;
            sPECIALITY_NAMELabel.Text = "SPECIALITY NAME:";
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
            // pRACTITIONERTableAdapter
            // 
            this.pRACTITIONERTableAdapter.ClearBeforeFill = true;
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
            this.sPECIALITYBindingNavigator.Size = new System.Drawing.Size(1475, 27);
            this.sPECIALITYBindingNavigator.TabIndex = 0;
            this.sPECIALITYBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(55, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sPECIALITYBindingNavigatorSaveItem
            // 
            this.sPECIALITYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sPECIALITYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sPECIALITYBindingNavigatorSaveItem.Image")));
            this.sPECIALITYBindingNavigatorSaveItem.Name = "sPECIALITYBindingNavigatorSaveItem";
            this.sPECIALITYBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sPECIALITYBindingNavigatorSaveItem.Text = "Save Data";
            this.sPECIALITYBindingNavigatorSaveItem.Click += new System.EventHandler(this.sPECIALITYBindingNavigatorSaveItem_Click);
            // 
            // sPECIALITY_IDTextBox
            // 
            this.sPECIALITY_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sPECIALITY_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPECIALITYBindingSource, "SPECIALITY_ID", true));
            this.sPECIALITY_IDTextBox.Location = new System.Drawing.Point(771, 216);
            this.sPECIALITY_IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sPECIALITY_IDTextBox.Name = "sPECIALITY_IDTextBox";
            this.sPECIALITY_IDTextBox.Size = new System.Drawing.Size(112, 22);
            this.sPECIALITY_IDTextBox.TabIndex = 2;
            // 
            // sPECIALITY_NAMETextBox
            // 
            this.sPECIALITY_NAMETextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sPECIALITY_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPECIALITYBindingSource, "SPECIALITY_NAME", true));
            this.sPECIALITY_NAMETextBox.Location = new System.Drawing.Point(771, 245);
            this.sPECIALITY_NAMETextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sPECIALITY_NAMETextBox.Name = "sPECIALITY_NAMETextBox";
            this.sPECIALITY_NAMETextBox.Size = new System.Drawing.Size(112, 22);
            this.sPECIALITY_NAMETextBox.TabIndex = 4;
            // 
            // pRACTITIONERBindingSource
            // 
            this.pRACTITIONERBindingSource.DataMember = "PRACTITIONER";
            this.pRACTITIONERBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pRACTITIONERDataGridView
            // 
            this.pRACTITIONERDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pRACTITIONERDataGridView.AutoGenerateColumns = false;
            this.pRACTITIONERDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pRACTITIONERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRACTITIONERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pRACTITIONERDataGridView.DataSource = this.fKPRACTITIHASASPECIALIBindingSource;
            this.pRACTITIONERDataGridView.Location = new System.Drawing.Point(388, 305);
            this.pRACTITIONERDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRACTITIONERDataGridView.Name = "pRACTITIONERDataGridView";
            this.pRACTITIONERDataGridView.RowHeadersWidth = 51;
            this.pRACTITIONERDataGridView.RowTemplate.Height = 24;
            this.pRACTITIONERDataGridView.Size = new System.Drawing.Size(693, 135);
            this.pRACTITIONERDataGridView.TabIndex = 5;
            this.pRACTITIONERDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pRACTITIONERDataGridView_CellContentClick);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            button1.Location = new System.Drawing.Point(33, 200);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(186, 38);
            button1.TabIndex = 21;
            button1.Text = "Go to form 4";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goToForm3
            // 
            goToForm3.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm3.Location = new System.Drawing.Point(33, 125);
            goToForm3.Name = "goToForm3";
            goToForm3.Size = new System.Drawing.Size(186, 38);
            goToForm3.TabIndex = 20;
            goToForm3.Text = "Go to form 2";
            goToForm3.UseVisualStyleBackColor = false;
            goToForm3.Click += new System.EventHandler(this.goToForm3_Click);
            // 
            // goToForm1
            // 
            goToForm1.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm1.Location = new System.Drawing.Point(33, 53);
            goToForm1.Name = "goToForm1";
            goToForm1.Size = new System.Drawing.Size(186, 38);
            goToForm1.TabIndex = 19;
            goToForm1.Text = "Go to form 1";
            goToForm1.UseVisualStyleBackColor = false;
            goToForm1.Click += new System.EventHandler(this.goToForm1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(939, 72);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select from Practitioner filterd by speciality";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRACTITIONER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRACTITIONER_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SPECIALITY_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SPECIALITY_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MEDICAL_EXPERTISE";
            this.dataGridViewTextBoxColumn3.HeaderText = "MEDICAL_EXPERTISE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fKPRACTITIHASASPECIALIBindingSource
            // 
            this.fKPRACTITIHASASPECIALIBindingSource.DataMember = "FK_PRACTITI_HASA_SPECIALI";
            this.fKPRACTITIHASASPECIALIBindingSource.DataSource = this.sPECIALITYBindingSource;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1475, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(button1);
            this.Controls.Add(goToForm3);
            this.Controls.Add(goToForm1);
            this.Controls.Add(this.pRACTITIONERDataGridView);
            this.Controls.Add(sPECIALITY_IDLabel);
            this.Controls.Add(this.sPECIALITY_IDTextBox);
            this.Controls.Add(sPECIALITY_NAMELabel);
            this.Controls.Add(this.sPECIALITY_NAMETextBox);
            this.Controls.Add(this.sPECIALITYBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label3;
    }
}