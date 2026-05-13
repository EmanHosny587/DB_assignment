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
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.iS_SCHEDULEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS_SCHEDULEDTableAdapter = new DB.HospitalDataSetTableAdapters.IS_SCHEDULEDTableAdapter();
            this.tableAdapterManager = new DB.HospitalDataSetTableAdapters.TableAdapterManager();
            this.iS_SCHEDULEDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iS_SCHEDULEDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRACTITIONER_BRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACTITIONER_BRANCHTableAdapter = new DB.HospitalDataSetTableAdapters.PRACTITIONER_BRANCHTableAdapter();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTTableAdapter = new DB.HospitalDataSetTableAdapters.PATIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDBindingNavigator)).BeginInit();
            this.iS_SCHEDULEDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONER_BRANCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iS_SCHEDULEDBindingSource
            // 
            this.iS_SCHEDULEDBindingSource.DataMember = "IS_SCHEDULED";
            this.iS_SCHEDULEDBindingSource.DataSource = this.hospitalDataSet;
            // 
            // iS_SCHEDULEDTableAdapter
            // 
            this.iS_SCHEDULEDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLINICAL_SUMMARYTableAdapter = null;
            this.tableAdapterManager.IS_SCHEDULEDTableAdapter = this.iS_SCHEDULEDTableAdapter;
            this.tableAdapterManager.MEDICAL_FACILITY_BRANCHTableAdapter = null;
            this.tableAdapterManager.MEDICATIONTableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.PRACTITIONER_BRANCHTableAdapter = this.pRACTITIONER_BRANCHTableAdapter;
            this.tableAdapterManager.PRACTITIONERTableAdapter = null;
            this.tableAdapterManager.PRESCRIBEDINTableAdapter = null;
            this.tableAdapterManager.PRESCRIPTIONTableAdapter = null;
            this.tableAdapterManager.REGIONAL_HEALTHCARE_PROVIDERTableAdapter = null;
            this.tableAdapterManager.SPECIALITYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iS_SCHEDULEDBindingNavigator
            // 
            this.iS_SCHEDULEDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iS_SCHEDULEDBindingNavigator.BindingSource = this.iS_SCHEDULEDBindingSource;
            this.iS_SCHEDULEDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iS_SCHEDULEDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iS_SCHEDULEDBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iS_SCHEDULEDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iS_SCHEDULEDBindingNavigatorSaveItem});
            this.iS_SCHEDULEDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iS_SCHEDULEDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iS_SCHEDULEDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iS_SCHEDULEDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iS_SCHEDULEDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iS_SCHEDULEDBindingNavigator.Name = "iS_SCHEDULEDBindingNavigator";
            this.iS_SCHEDULEDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iS_SCHEDULEDBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.iS_SCHEDULEDBindingNavigator.TabIndex = 0;
            this.iS_SCHEDULEDBindingNavigator.Text = "bindingNavigator1";
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
            // iS_SCHEDULEDBindingNavigatorSaveItem
            // 
            this.iS_SCHEDULEDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iS_SCHEDULEDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iS_SCHEDULEDBindingNavigatorSaveItem.Image")));
            this.iS_SCHEDULEDBindingNavigatorSaveItem.Name = "iS_SCHEDULEDBindingNavigatorSaveItem";
            this.iS_SCHEDULEDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iS_SCHEDULEDBindingNavigatorSaveItem.Text = "Save Data";
            this.iS_SCHEDULEDBindingNavigatorSaveItem.Click += new System.EventHandler(this.iS_SCHEDULEDBindingNavigatorSaveItem_Click);
            // 
            // pRACTITIONER_BRANCHBindingSource
            // 
            this.pRACTITIONER_BRANCHBindingSource.DataMember = "PRACTITIONER_BRANCH";
            this.pRACTITIONER_BRANCHBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pRACTITIONER_BRANCHTableAdapter
            // 
            this.pRACTITIONER_BRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iS_SCHEDULEDBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDBindingNavigator)).EndInit();
            this.iS_SCHEDULEDBindingNavigator.ResumeLayout(false);
            this.iS_SCHEDULEDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONER_BRANCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource iS_SCHEDULEDBindingSource;
        private HospitalDataSetTableAdapters.IS_SCHEDULEDTableAdapter iS_SCHEDULEDTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iS_SCHEDULEDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iS_SCHEDULEDBindingNavigatorSaveItem;
        private HospitalDataSetTableAdapters.PRACTITIONER_BRANCHTableAdapter pRACTITIONER_BRANCHTableAdapter;
        private System.Windows.Forms.BindingSource pRACTITIONER_BRANCHBindingSource;
        private HospitalDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
    }
}