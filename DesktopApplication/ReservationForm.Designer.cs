namespace DesktopApplication
{
    partial class DesktopApplicationForm
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
            this.ReservationDataGridView = new System.Windows.Forms.DataGridView();
            this.ReservationCreateButton = new System.Windows.Forms.Button();
            this.ReservationModifyButton = new System.Windows.Forms.Button();
            this.ReservationDeleteButton = new System.Windows.Forms.Button();
            this.ReservationObtainButton = new System.Windows.Forms.Button();
            this.ReservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReservationDateTimeLabel = new System.Windows.Forms.Label();
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.ObservationsLabel = new System.Windows.Forms.Label();
            this.ObservationsTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.GuestsAmountLabel = new System.Windows.Forms.Label();
            this.EMailLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EMailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.ReservationCommitButton = new System.Windows.Forms.Button();
            this.ApplicationExitButton = new System.Windows.Forms.Button();
            this.TableNumberTextBox = new System.Windows.Forms.NumericUpDown();
            this.GuestsAmountTextBox = new System.Windows.Forms.NumericUpDown();
            this.SaleChannelLabel = new System.Windows.Forms.Label();
            this.SaleChannelComboBox = new System.Windows.Forms.ComboBox();
            this.ReservationCancelButton = new System.Windows.Forms.Button();
            this.ReservationViewObservation = new System.Windows.Forms.Button();
            this.DateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EMailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsAmountTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMailErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationDataGridView
            // 
            this.ReservationDataGridView.AllowUserToOrderColumns = true;
            this.ReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationDataGridView.Location = new System.Drawing.Point(12, 238);
            this.ReservationDataGridView.Name = "ReservationDataGridView";
            this.ReservationDataGridView.ReadOnly = true;
            this.ReservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationDataGridView.Size = new System.Drawing.Size(1040, 250);
            this.ReservationDataGridView.TabIndex = 0;
            // 
            // ReservationCreateButton
            // 
            this.ReservationCreateButton.Location = new System.Drawing.Point(13, 13);
            this.ReservationCreateButton.Name = "ReservationCreateButton";
            this.ReservationCreateButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationCreateButton.TabIndex = 1;
            this.ReservationCreateButton.Text = "Crear Reserva";
            this.ReservationCreateButton.UseVisualStyleBackColor = true;
            this.ReservationCreateButton.Click += new System.EventHandler(this.ReservationCreateButton_Click);
            // 
            // ReservationModifyButton
            // 
            this.ReservationModifyButton.Location = new System.Drawing.Point(12, 66);
            this.ReservationModifyButton.Name = "ReservationModifyButton";
            this.ReservationModifyButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationModifyButton.TabIndex = 2;
            this.ReservationModifyButton.Text = "Modificar Reserva";
            this.ReservationModifyButton.UseVisualStyleBackColor = true;
            this.ReservationModifyButton.Click += new System.EventHandler(this.ReservationModifyButton_Click);
            // 
            // ReservationDeleteButton
            // 
            this.ReservationDeleteButton.Location = new System.Drawing.Point(12, 119);
            this.ReservationDeleteButton.Name = "ReservationDeleteButton";
            this.ReservationDeleteButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationDeleteButton.TabIndex = 3;
            this.ReservationDeleteButton.Text = "Eliminar Reserva";
            this.ReservationDeleteButton.UseVisualStyleBackColor = true;
            this.ReservationDeleteButton.Click += new System.EventHandler(this.ReservationDeleteButton_Click);
            // 
            // ReservationObtainButton
            // 
            this.ReservationObtainButton.Location = new System.Drawing.Point(12, 185);
            this.ReservationObtainButton.Name = "ReservationObtainButton";
            this.ReservationObtainButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationObtainButton.TabIndex = 4;
            this.ReservationObtainButton.Text = "Obtener Reservas";
            this.ReservationObtainButton.UseVisualStyleBackColor = true;
            this.ReservationObtainButton.Click += new System.EventHandler(this.ReservationObtainButton_Click);
            // 
            // ReservationDateTimePicker
            // 
            this.ReservationDateTimePicker.Location = new System.Drawing.Point(190, 29);
            this.ReservationDateTimePicker.MinDate = new System.DateTime(2014, 10, 19, 17, 51, 13, 0);
            this.ReservationDateTimePicker.Name = "ReservationDateTimePicker";
            this.ReservationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ReservationDateTimePicker.TabIndex = 5;
            this.ReservationDateTimePicker.Value = new System.DateTime(2014, 10, 19, 17, 51, 13, 0);
            this.ReservationDateTimePicker.Visible = false;
            this.ReservationDateTimePicker.ValueChanged += new System.EventHandler(this.ReservationDateTimePicker_ValueChanged);
            // 
            // ReservationDateTimeLabel
            // 
            this.ReservationDateTimeLabel.AutoSize = true;
            this.ReservationDateTimeLabel.Location = new System.Drawing.Point(188, 13);
            this.ReservationDateTimeLabel.Name = "ReservationDateTimeLabel";
            this.ReservationDateTimeLabel.Size = new System.Drawing.Size(82, 13);
            this.ReservationDateTimeLabel.TabIndex = 6;
            this.ReservationDateTimeLabel.Text = "Fecha y Horario";
            this.ReservationDateTimeLabel.Visible = false;
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.AutoSize = true;
            this.TableNumberLabel.Location = new System.Drawing.Point(656, 9);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(88, 13);
            this.TableNumberLabel.TabIndex = 7;
            this.TableNumberLabel.Text = "Número de Mesa";
            this.TableNumberLabel.Visible = false;
            // 
            // ObservationsLabel
            // 
            this.ObservationsLabel.AutoSize = true;
            this.ObservationsLabel.Location = new System.Drawing.Point(423, 10);
            this.ObservationsLabel.Name = "ObservationsLabel";
            this.ObservationsLabel.Size = new System.Drawing.Size(78, 13);
            this.ObservationsLabel.TabIndex = 9;
            this.ObservationsLabel.Text = "Observaciones";
            this.ObservationsLabel.Visible = false;
            // 
            // ObservationsTextBox
            // 
            this.ObservationsTextBox.Location = new System.Drawing.Point(423, 27);
            this.ObservationsTextBox.MaxLength = 150;
            this.ObservationsTextBox.Multiline = true;
            this.ObservationsTextBox.Name = "ObservationsTextBox";
            this.ObservationsTextBox.Size = new System.Drawing.Size(200, 86);
            this.ObservationsTextBox.TabIndex = 10;
            this.ObservationsTextBox.Visible = false;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(423, 119);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(104, 13);
            this.PhoneNumberLabel.TabIndex = 11;
            this.PhoneNumberLabel.Text = "Número de Teléfono";
            this.PhoneNumberLabel.Visible = false;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(423, 135);
            this.PhoneNumberTextBox.MaxLength = 20;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneNumberTextBox.TabIndex = 12;
            this.PhoneNumberTextBox.Visible = false;
            // 
            // GuestsAmountLabel
            // 
            this.GuestsAmountLabel.AutoSize = true;
            this.GuestsAmountLabel.Location = new System.Drawing.Point(188, 66);
            this.GuestsAmountLabel.Name = "GuestsAmountLabel";
            this.GuestsAmountLabel.Size = new System.Drawing.Size(124, 13);
            this.GuestsAmountLabel.TabIndex = 13;
            this.GuestsAmountLabel.Text = "Cantidad de Comensales";
            this.GuestsAmountLabel.Visible = false;
            this.GuestsAmountLabel.Click += new System.EventHandler(this.GuestsAmountLabel_Click);
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(423, 168);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(157, 13);
            this.EMailLabel.TabIndex = 15;
            this.EMailLabel.Text = "Dirección de Correo Electrónico";
            this.EMailLabel.Visible = false;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(190, 133);
            this.FirstNameTextBox.MaxLength = 60;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 16;
            this.FirstNameTextBox.Visible = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(188, 117);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(44, 13);
            this.FirstNameLabel.TabIndex = 17;
            this.FirstNameLabel.Text = "Nombre";
            this.FirstNameLabel.Visible = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(187, 168);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.LastNameLabel.TabIndex = 18;
            this.LastNameLabel.Text = "Apellido";
            this.LastNameLabel.Visible = false;
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.Location = new System.Drawing.Point(423, 185);
            this.EMailTextBox.MaxLength = 100;
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(200, 20);
            this.EMailTextBox.TabIndex = 19;
            this.EMailTextBox.Visible = false;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(190, 185);
            this.LastNameTextBox.MaxLength = 100;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 20;
            this.LastNameTextBox.Visible = false;
            // 
            // ReservationCommitButton
            // 
            this.ReservationCommitButton.Location = new System.Drawing.Point(659, 133);
            this.ReservationCommitButton.Name = "ReservationCommitButton";
            this.ReservationCommitButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationCommitButton.TabIndex = 21;
            this.ReservationCommitButton.UseVisualStyleBackColor = true;
            this.ReservationCommitButton.Visible = false;
            this.ReservationCommitButton.Click += new System.EventHandler(this.ReservationCommitButton_Click);
            // 
            // ApplicationExitButton
            // 
            this.ApplicationExitButton.Location = new System.Drawing.Point(941, 185);
            this.ApplicationExitButton.Name = "ApplicationExitButton";
            this.ApplicationExitButton.Size = new System.Drawing.Size(110, 47);
            this.ApplicationExitButton.TabIndex = 22;
            this.ApplicationExitButton.Text = "Salir";
            this.ApplicationExitButton.UseVisualStyleBackColor = true;
            this.ApplicationExitButton.Click += new System.EventHandler(this.ApplicationExitButton_Click);
            // 
            // TableNumberTextBox
            // 
            this.TableNumberTextBox.Location = new System.Drawing.Point(659, 27);
            this.TableNumberTextBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TableNumberTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TableNumberTextBox.Name = "TableNumberTextBox";
            this.TableNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.TableNumberTextBox.TabIndex = 23;
            this.TableNumberTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TableNumberTextBox.Visible = false;
            // 
            // GuestsAmountTextBox
            // 
            this.GuestsAmountTextBox.Location = new System.Drawing.Point(191, 82);
            this.GuestsAmountTextBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GuestsAmountTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GuestsAmountTextBox.Name = "GuestsAmountTextBox";
            this.GuestsAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.GuestsAmountTextBox.TabIndex = 24;
            this.GuestsAmountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GuestsAmountTextBox.Visible = false;
            // 
            // SaleChannelLabel
            // 
            this.SaleChannelLabel.AutoSize = true;
            this.SaleChannelLabel.Location = new System.Drawing.Point(659, 65);
            this.SaleChannelLabel.Name = "SaleChannelLabel";
            this.SaleChannelLabel.Size = new System.Drawing.Size(80, 13);
            this.SaleChannelLabel.TabIndex = 25;
            this.SaleChannelLabel.Text = "Canal de Venta";
            this.SaleChannelLabel.Visible = false;
            // 
            // SaleChannelComboBox
            // 
            this.SaleChannelComboBox.FormattingEnabled = true;
            this.SaleChannelComboBox.Location = new System.Drawing.Point(659, 82);
            this.SaleChannelComboBox.Name = "SaleChannelComboBox";
            this.SaleChannelComboBox.Size = new System.Drawing.Size(121, 21);
            this.SaleChannelComboBox.TabIndex = 26;
            this.SaleChannelComboBox.Visible = false;
            // 
            // ReservationCancelButton
            // 
            this.ReservationCancelButton.Location = new System.Drawing.Point(797, 133);
            this.ReservationCancelButton.Name = "ReservationCancelButton";
            this.ReservationCancelButton.Size = new System.Drawing.Size(110, 47);
            this.ReservationCancelButton.TabIndex = 27;
            this.ReservationCancelButton.Text = "Cancelar";
            this.ReservationCancelButton.UseVisualStyleBackColor = true;
            this.ReservationCancelButton.Visible = false;
            this.ReservationCancelButton.Click += new System.EventHandler(this.ReservationCancelButton_Click);
            // 
            // ReservationViewObservation
            // 
            this.ReservationViewObservation.Location = new System.Drawing.Point(941, 9);
            this.ReservationViewObservation.Name = "ReservationViewObservation";
            this.ReservationViewObservation.Size = new System.Drawing.Size(117, 40);
            this.ReservationViewObservation.TabIndex = 28;
            this.ReservationViewObservation.Text = "Ver Observaciones";
            this.ReservationViewObservation.UseVisualStyleBackColor = true;
            this.ReservationViewObservation.Click += new System.EventHandler(this.ReservationViewObservation_Click);
            // 
            // DateErrorProvider
            // 
            this.DateErrorProvider.ContainerControl = this;
            // 
            // FirstNameErrorProvider
            // 
            this.FirstNameErrorProvider.ContainerControl = this;
            // 
            // LastNameErrorProvider
            // 
            this.LastNameErrorProvider.ContainerControl = this;
            // 
            // PhoneNumberErrorProvider
            // 
            this.PhoneNumberErrorProvider.ContainerControl = this;
            // 
            // EMailErrorProvider
            // 
            this.EMailErrorProvider.ContainerControl = this;
            // 
            // DesktopApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 495);
            this.Controls.Add(this.ReservationViewObservation);
            this.Controls.Add(this.ReservationCancelButton);
            this.Controls.Add(this.SaleChannelComboBox);
            this.Controls.Add(this.SaleChannelLabel);
            this.Controls.Add(this.GuestsAmountTextBox);
            this.Controls.Add(this.TableNumberTextBox);
            this.Controls.Add(this.ApplicationExitButton);
            this.Controls.Add(this.ReservationCommitButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.EMailTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EMailLabel);
            this.Controls.Add(this.GuestsAmountLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.ObservationsTextBox);
            this.Controls.Add(this.ObservationsLabel);
            this.Controls.Add(this.TableNumberLabel);
            this.Controls.Add(this.ReservationDateTimeLabel);
            this.Controls.Add(this.ReservationDateTimePicker);
            this.Controls.Add(this.ReservationObtainButton);
            this.Controls.Add(this.ReservationDeleteButton);
            this.Controls.Add(this.ReservationModifyButton);
            this.Controls.Add(this.ReservationCreateButton);
            this.Controls.Add(this.ReservationDataGridView);
            this.MaximizeBox = false;
            this.Name = "DesktopApplicationForm";
            this.Text = "Sistema de Gestión de Reservas";
            this.Load += new System.EventHandler(this.DesktopApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsAmountTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMailErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReservationDataGridView;
        private System.Windows.Forms.Button ReservationCreateButton;
        private System.Windows.Forms.Button ReservationModifyButton;
        private System.Windows.Forms.Button ReservationDeleteButton;
        private System.Windows.Forms.Button ReservationObtainButton;
        private System.Windows.Forms.DateTimePicker ReservationDateTimePicker;
        private System.Windows.Forms.Label ReservationDateTimeLabel;
        private System.Windows.Forms.Label TableNumberLabel;
        private System.Windows.Forms.Label ObservationsLabel;
        private System.Windows.Forms.TextBox ObservationsTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label GuestsAmountLabel;
        private System.Windows.Forms.Label EMailLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button ReservationCommitButton;
        private System.Windows.Forms.Button ApplicationExitButton;
        private System.Windows.Forms.NumericUpDown TableNumberTextBox;
        private System.Windows.Forms.NumericUpDown GuestsAmountTextBox;
        private System.Windows.Forms.Label SaleChannelLabel;
        private System.Windows.Forms.ComboBox SaleChannelComboBox;
        private System.Windows.Forms.Button ReservationCancelButton;
        private System.Windows.Forms.Button ReservationViewObservation;
        private System.Windows.Forms.ErrorProvider DateErrorProvider;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PhoneNumberErrorProvider;
        private System.Windows.Forms.ErrorProvider EMailErrorProvider;
    }
}

