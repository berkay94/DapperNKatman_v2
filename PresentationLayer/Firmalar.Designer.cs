namespace PresentationLayer
{
    partial class Firmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firmalar));
            this.testDataSet1 = new PresentationLayer.testDataSet1();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new PresentationLayer.testDataSet1TableAdapters.FirmaTableAdapter();
            this.tableAdapterManager = new PresentationLayer.testDataSet1TableAdapters.TableAdapterManager();
            this.firmaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.firmaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firmaDataGridView = new System.Windows.Forms.DataGridView();
            this.firmaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verginoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingNavigator)).BeginInit();
            this.firmaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.testDataSet1;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmaTableAdapter = this.firmaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PresentationLayer.testDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firmaBindingNavigator
            // 
            this.firmaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.firmaBindingNavigator.BindingSource = this.firmaBindingSource;
            this.firmaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.firmaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.firmaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.firmaBindingNavigatorSaveItem});
            this.firmaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.firmaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.firmaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.firmaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.firmaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.firmaBindingNavigator.Name = "firmaBindingNavigator";
            this.firmaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.firmaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.firmaBindingNavigator.TabIndex = 0;
            this.firmaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // firmaBindingNavigatorSaveItem
            // 
            this.firmaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firmaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaBindingNavigatorSaveItem.Image")));
            this.firmaBindingNavigatorSaveItem.Name = "firmaBindingNavigatorSaveItem";
            this.firmaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.firmaBindingNavigatorSaveItem.Text = "Save Data";
            this.firmaBindingNavigatorSaveItem.Click += new System.EventHandler(this.firmaBindingNavigatorSaveItem_Click_1);
            // 
            // firmaDataGridView
            // 
            this.firmaDataGridView.AutoGenerateColumns = false;
            this.firmaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaIdDataGridViewTextBoxColumn,
            this.unvaniDataGridViewTextBoxColumn,
            this.firmaTipiDataGridViewTextBoxColumn,
            this.adres1DataGridViewTextBoxColumn,
            this.adres2DataGridViewTextBoxColumn,
            this.vergidairesiDataGridViewTextBoxColumn,
            this.verginoDataGridViewTextBoxColumn});
            this.firmaDataGridView.DataSource = this.firmaBindingSource;
            this.firmaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.firmaDataGridView.Name = "firmaDataGridView";
            this.firmaDataGridView.Size = new System.Drawing.Size(748, 220);
            this.firmaDataGridView.TabIndex = 1;
            // 
            // firmaIdDataGridViewTextBoxColumn
            // 
            this.firmaIdDataGridViewTextBoxColumn.DataPropertyName = "firmaId";
            this.firmaIdDataGridViewTextBoxColumn.HeaderText = "firmaId";
            this.firmaIdDataGridViewTextBoxColumn.Name = "firmaIdDataGridViewTextBoxColumn";
            this.firmaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unvaniDataGridViewTextBoxColumn
            // 
            this.unvaniDataGridViewTextBoxColumn.DataPropertyName = "Unvani";
            this.unvaniDataGridViewTextBoxColumn.HeaderText = "Unvani";
            this.unvaniDataGridViewTextBoxColumn.Name = "unvaniDataGridViewTextBoxColumn";
            // 
            // firmaTipiDataGridViewTextBoxColumn
            // 
            this.firmaTipiDataGridViewTextBoxColumn.DataPropertyName = "firmaTipi";
            this.firmaTipiDataGridViewTextBoxColumn.HeaderText = "firmaTipi";
            this.firmaTipiDataGridViewTextBoxColumn.Name = "firmaTipiDataGridViewTextBoxColumn";
            // 
            // adres1DataGridViewTextBoxColumn
            // 
            this.adres1DataGridViewTextBoxColumn.DataPropertyName = "adres1";
            this.adres1DataGridViewTextBoxColumn.HeaderText = "adres1";
            this.adres1DataGridViewTextBoxColumn.Name = "adres1DataGridViewTextBoxColumn";
            // 
            // adres2DataGridViewTextBoxColumn
            // 
            this.adres2DataGridViewTextBoxColumn.DataPropertyName = "adres2";
            this.adres2DataGridViewTextBoxColumn.HeaderText = "adres2";
            this.adres2DataGridViewTextBoxColumn.Name = "adres2DataGridViewTextBoxColumn";
            // 
            // vergidairesiDataGridViewTextBoxColumn
            // 
            this.vergidairesiDataGridViewTextBoxColumn.DataPropertyName = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.HeaderText = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.Name = "vergidairesiDataGridViewTextBoxColumn";
            // 
            // verginoDataGridViewTextBoxColumn
            // 
            this.verginoDataGridViewTextBoxColumn.DataPropertyName = "vergino";
            this.verginoDataGridViewTextBoxColumn.HeaderText = "vergino";
            this.verginoDataGridViewTextBoxColumn.Name = "verginoDataGridViewTextBoxColumn";
            // 
            // Firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firmaDataGridView);
            this.Controls.Add(this.firmaBindingNavigator);
            this.Name = "Firmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Firmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingNavigator)).EndInit();
            this.firmaBindingNavigator.ResumeLayout(false);
            this.firmaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private testDataSet1TableAdapters.FirmaTableAdapter firmaTableAdapter;
        private testDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator firmaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton firmaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView firmaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verginoDataGridViewTextBoxColumn;
    }
}