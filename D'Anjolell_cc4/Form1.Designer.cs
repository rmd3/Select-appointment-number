
namespace D_Anjolell_cc4
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
            System.Windows.Forms.Label apptpatientnameLabel;
            System.Windows.Forms.Label apptdateLabel;
            System.Windows.Forms.Label appttimeLabel;
            System.Windows.Forms.Label apptdoctornameLabel;
            this.lstBxAptID = new System.Windows.Forms.ListBox();
            this.lblAptID = new System.Windows.Forms.Label();
            this._D_AnjolellMedicalDataSet = new D_Anjolell_cc4._D_AnjolellMedicalDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new D_Anjolell_cc4._D_AnjolellMedicalDataSetTableAdapters.AppointmentsTableAdapter();
            this.tableAdapterManager = new D_Anjolell_cc4._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager();
            this.apptpatientnameTextBox = new System.Windows.Forms.TextBox();
            this.apptdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appttimeTextBox = new System.Windows.Forms.TextBox();
            this.apptdoctornameTextBox = new System.Windows.Forms.TextBox();
            apptpatientnameLabel = new System.Windows.Forms.Label();
            apptdateLabel = new System.Windows.Forms.Label();
            appttimeLabel = new System.Windows.Forms.Label();
            apptdoctornameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBxAptID
            // 
            this.lstBxAptID.DataSource = this.appointmentsBindingSource;
            this.lstBxAptID.DisplayMember = "apptID";
            this.lstBxAptID.FormattingEnabled = true;
            this.lstBxAptID.ItemHeight = 16;
            this.lstBxAptID.Location = new System.Drawing.Point(12, 51);
            this.lstBxAptID.Name = "lstBxAptID";
            this.lstBxAptID.Size = new System.Drawing.Size(204, 116);
            this.lstBxAptID.TabIndex = 0;
            // 
            // lblAptID
            // 
            this.lblAptID.AutoSize = true;
            this.lblAptID.Location = new System.Drawing.Point(12, 13);
            this.lblAptID.Name = "lblAptID";
            this.lblAptID.Size = new System.Drawing.Size(204, 17);
            this.lblAptID.TabIndex = 1;
            this.lblAptID.Text = "Select an Appointment Number";
            // 
            // _D_AnjolellMedicalDataSet
            // 
            this._D_AnjolellMedicalDataSet.DataSetName = "_D_AnjolellMedicalDataSet";
            this._D_AnjolellMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this._D_AnjolellMedicalDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = D_Anjolell_cc4._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // apptpatientnameLabel
            // 
            apptpatientnameLabel.AutoSize = true;
            apptpatientnameLabel.Location = new System.Drawing.Point(279, 16);
            apptpatientnameLabel.Name = "apptpatientnameLabel";
            apptpatientnameLabel.Size = new System.Drawing.Size(118, 17);
            apptpatientnameLabel.TabIndex = 2;
            apptpatientnameLabel.Text = "apptpatientname:";
            // 
            // apptpatientnameTextBox
            // 
            this.apptpatientnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptpatientname", true));
            this.apptpatientnameTextBox.Location = new System.Drawing.Point(403, 13);
            this.apptpatientnameTextBox.Name = "apptpatientnameTextBox";
            this.apptpatientnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.apptpatientnameTextBox.TabIndex = 3;
            // 
            // apptdateLabel
            // 
            apptdateLabel.AutoSize = true;
            apptdateLabel.Location = new System.Drawing.Point(329, 59);
            apptdateLabel.Name = "apptdateLabel";
            apptdateLabel.Size = new System.Drawing.Size(68, 17);
            apptdateLabel.TabIndex = 4;
            apptdateLabel.Text = "apptdate:";
            // 
            // apptdateDateTimePicker
            // 
            this.apptdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentsBindingSource, "apptdate", true));
            this.apptdateDateTimePicker.Location = new System.Drawing.Point(403, 55);
            this.apptdateDateTimePicker.Name = "apptdateDateTimePicker";
            this.apptdateDateTimePicker.Size = new System.Drawing.Size(264, 22);
            this.apptdateDateTimePicker.TabIndex = 5;
            // 
            // appttimeLabel
            // 
            appttimeLabel.AutoSize = true;
            appttimeLabel.Location = new System.Drawing.Point(331, 101);
            appttimeLabel.Name = "appttimeLabel";
            appttimeLabel.Size = new System.Drawing.Size(66, 17);
            appttimeLabel.TabIndex = 6;
            appttimeLabel.Text = "appttime:";
            // 
            // appttimeTextBox
            // 
            this.appttimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "appttime", true));
            this.appttimeTextBox.Location = new System.Drawing.Point(403, 98);
            this.appttimeTextBox.Name = "appttimeTextBox";
            this.appttimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.appttimeTextBox.TabIndex = 7;
            // 
            // apptdoctornameLabel
            // 
            apptdoctornameLabel.AutoSize = true;
            apptdoctornameLabel.Location = new System.Drawing.Point(282, 144);
            apptdoctornameLabel.Name = "apptdoctornameLabel";
            apptdoctornameLabel.Size = new System.Drawing.Size(115, 17);
            apptdoctornameLabel.TabIndex = 8;
            apptdoctornameLabel.Text = "apptdoctorname:";
            // 
            // apptdoctornameTextBox
            // 
            this.apptdoctornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptdoctorname", true));
            this.apptdoctornameTextBox.Location = new System.Drawing.Point(403, 141);
            this.apptdoctornameTextBox.Name = "apptdoctornameTextBox";
            this.apptdoctornameTextBox.Size = new System.Drawing.Size(100, 22);
            this.apptdoctornameTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 339);
            this.Controls.Add(apptdoctornameLabel);
            this.Controls.Add(this.apptdoctornameTextBox);
            this.Controls.Add(appttimeLabel);
            this.Controls.Add(this.appttimeTextBox);
            this.Controls.Add(apptdateLabel);
            this.Controls.Add(this.apptdateDateTimePicker);
            this.Controls.Add(apptpatientnameLabel);
            this.Controls.Add(this.apptpatientnameTextBox);
            this.Controls.Add(this.lblAptID);
            this.Controls.Add(this.lstBxAptID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxAptID;
        private System.Windows.Forms.Label lblAptID;
        private _D_AnjolellMedicalDataSet _D_AnjolellMedicalDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private _D_AnjolellMedicalDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private _D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox apptpatientnameTextBox;
        private System.Windows.Forms.DateTimePicker apptdateDateTimePicker;
        private System.Windows.Forms.TextBox appttimeTextBox;
        private System.Windows.Forms.TextBox apptdoctornameTextBox;
    }
}

