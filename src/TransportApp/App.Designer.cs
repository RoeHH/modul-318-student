﻿namespace TransportApp
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stationTab = new System.Windows.Forms.TabPage();
            this.stationBoardHeading = new System.Windows.Forms.Label();
            this.stationBoard = new System.Windows.Forms.DataGridView();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationSearchBox = new System.Windows.Forms.TextBox();
            this.foundStations = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showBoard = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.connectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conectionBoard = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReiseZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtsZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftsZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.stationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.switchFromTo = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.stationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectionBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.stationTab);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(2, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(611, 439);
            this.tabControl.TabIndex = 0;
            // 
            // stationTab
            // 
            this.stationTab.Controls.Add(this.stationBoardHeading);
            this.stationTab.Controls.Add(this.stationBoard);
            this.stationTab.Controls.Add(this.stationSearchBox);
            this.stationTab.Controls.Add(this.foundStations);
            this.stationTab.Location = new System.Drawing.Point(4, 24);
            this.stationTab.Name = "stationTab";
            this.stationTab.Padding = new System.Windows.Forms.Padding(3);
            this.stationTab.Size = new System.Drawing.Size(603, 411);
            this.stationTab.TabIndex = 0;
            this.stationTab.Text = "Stationen Suche";
            this.stationTab.UseVisualStyleBackColor = true;
            // 
            // stationBoardHeading
            // 
            this.stationBoardHeading.AutoSize = true;
            this.stationBoardHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stationBoardHeading.Location = new System.Drawing.Point(256, 8);
            this.stationBoardHeading.Name = "stationBoardHeading";
            this.stationBoardHeading.Size = new System.Drawing.Size(225, 25);
            this.stationBoardHeading.TabIndex = 4;
            this.stationBoardHeading.Text = "Keine Station Ausgewählt";
            // 
            // stationBoard
            // 
            this.stationBoard.AllowUserToAddRows = false;
            this.stationBoard.AllowUserToDeleteRows = false;
            this.stationBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stationBoard.AutoGenerateColumns = false;
            this.stationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.To,
            this.Departure,
            this.Operator});
            this.stationBoard.DataSource = this.stationBoardBindingSource;
            this.stationBoard.Location = new System.Drawing.Point(256, 37);
            this.stationBoard.Name = "stationBoard";
            this.stationBoard.ReadOnly = true;
            this.stationBoard.RowTemplate.Height = 25;
            this.stationBoard.Size = new System.Drawing.Size(344, 374);
            this.stationBoard.TabIndex = 3;
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "Nach";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.DataPropertyName = "Departure";
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "Anbieter";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // stationBoardBindingSource
            // 
            this.stationBoardBindingSource.DataSource = typeof(SwissTransport.Models.StationBoard);
            // 
            // stationSearchBox
            // 
            this.stationSearchBox.Location = new System.Drawing.Point(6, 8);
            this.stationSearchBox.Name = "stationSearchBox";
            this.stationSearchBox.PlaceholderText = "Suche nach einer Station...";
            this.stationSearchBox.Size = new System.Drawing.Size(244, 23);
            this.stationSearchBox.TabIndex = 2;
            this.stationSearchBox.TextChanged += new System.EventHandler(this.StationSearchBoxTextChanged);
            // 
            // foundStations
            // 
            this.foundStations.AllowUserToAddRows = false;
            this.foundStations.AllowUserToDeleteRows = false;
            this.foundStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.foundStations.AutoGenerateColumns = false;
            this.foundStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foundStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.showBoard});
            this.foundStations.DataSource = this.stationBindingSource;
            this.foundStations.Location = new System.Drawing.Point(6, 37);
            this.foundStations.Name = "foundStations";
            this.foundStations.ReadOnly = true;
            this.foundStations.RowTemplate.Height = 25;
            this.foundStations.Size = new System.Drawing.Size(244, 374);
            this.foundStations.TabIndex = 0;
            this.foundStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoundStationsCellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showBoard
            // 
            this.showBoard.DataPropertyName = "Id";
            this.showBoard.HeaderText = "Abfahrtstafel";
            this.showBoard.Name = "showBoard";
            this.showBoard.ReadOnly = true;
            this.showBoard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.showBoard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showBoard.Text = "Anzeigen";
            this.showBoard.UseColumnTextForButtonValue = true;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(SwissTransport.Models.Station);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.switchFromTo);
            this.tabPage2.Controls.Add(this.connectionDateTimePicker);
            this.tabPage2.Controls.Add(this.conectionBoard);
            this.tabPage2.Controls.Add(this.toTextBox);
            this.tabPage2.Controls.Add(this.fromTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VerbindungsSuche";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // connectionDateTimePicker
            // 
            this.connectionDateTimePicker.CausesValidation = false;
            this.connectionDateTimePicker.Checked = false;
            this.connectionDateTimePicker.CustomFormat = "HH:mm dd.MM.yy";
            this.connectionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.connectionDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.connectionDateTimePicker.Location = new System.Drawing.Point(259, 7);
            this.connectionDateTimePicker.Name = "connectionDateTimePicker";
            this.connectionDateTimePicker.ShowCheckBox = true;
            this.connectionDateTimePicker.ShowUpDown = true;
            this.connectionDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.connectionDateTimePicker.TabIndex = 3;
            this.connectionDateTimePicker.Value = new System.DateTime(2022, 4, 13, 0, 0, 0, 0);
            // 
            // conectionBoard
            // 
            this.conectionBoard.AllowUserToAddRows = false;
            this.conectionBoard.AllowUserToDeleteRows = false;
            this.conectionBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conectionBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.ReiseZeit,
            this.AbfahrtsZeit,
            this.AnkunftsZeit});
            this.conectionBoard.Location = new System.Drawing.Point(6, 38);
            this.conectionBoard.Name = "conectionBoard";
            this.conectionBoard.ReadOnly = true;
            this.conectionBoard.RowTemplate.Height = 25;
            this.conectionBoard.Size = new System.Drawing.Size(594, 373);
            this.conectionBoard.TabIndex = 2;
            // 
            // Von
            // 
            this.Von.DataPropertyName = "FromWithPlatform";
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            this.Von.ReadOnly = true;
            this.Von.Width = 110;
            // 
            // Nach
            // 
            this.Nach.DataPropertyName = "ToWithPlatform";
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            this.Nach.ReadOnly = true;
            this.Nach.Width = 110;
            // 
            // ReiseZeit
            // 
            this.ReiseZeit.DataPropertyName = "TravelTime";
            this.ReiseZeit.HeaderText = "Reise Zeit";
            this.ReiseZeit.Name = "ReiseZeit";
            this.ReiseZeit.ReadOnly = true;
            this.ReiseZeit.Width = 110;
            // 
            // AbfahrtsZeit
            // 
            this.AbfahrtsZeit.DataPropertyName = "Departure";
            this.AbfahrtsZeit.HeaderText = "Abfahrts Zeit";
            this.AbfahrtsZeit.Name = "AbfahrtsZeit";
            this.AbfahrtsZeit.ReadOnly = true;
            this.AbfahrtsZeit.Width = 110;
            // 
            // AnkunftsZeit
            // 
            this.AnkunftsZeit.DataPropertyName = "Arrival";
            this.AnkunftsZeit.HeaderText = "Ankunfts Zeit";
            this.AnkunftsZeit.Name = "AnkunftsZeit";
            this.AnkunftsZeit.ReadOnly = true;
            this.AnkunftsZeit.Width = 110;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(144, 7);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.PlaceholderText = "Nach";
            this.toTextBox.Size = new System.Drawing.Size(109, 23);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.TextChanged += new System.EventHandler(this.ConnectionSearchTextBoxTextChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(6, 7);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.PlaceholderText = "Von";
            this.fromTextBox.Size = new System.Drawing.Size(100, 23);
            this.fromTextBox.TabIndex = 0;
            this.fromTextBox.TextChanged += new System.EventHandler(this.ConnectionSearchTextBoxTextChanged);
            // 
            // stationBindingSource1
            // 
            this.stationBindingSource1.DataSource = typeof(SwissTransport.Models.Station);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SwissTransport.Core.Transport);
            // 
            // switchFromTo
            // 
            this.switchFromTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchFromTo.BackgroundImage")));
            this.switchFromTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchFromTo.FlatAppearance.BorderSize = 0;
            this.switchFromTo.Location = new System.Drawing.Point(112, 7);
            this.switchFromTo.Name = "switchFromTo";
            this.switchFromTo.Size = new System.Drawing.Size(26, 23);
            this.switchFromTo.TabIndex = 4;
            this.switchFromTo.UseVisualStyleBackColor = true;
            this.switchFromTo.Click += new System.EventHandler(this.switchFromTo_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 436);
            this.Controls.Add(this.tabControl);
            this.Name = "App";
            this.Text = "Transportapp";
            this.tabControl.ResumeLayout(false);
            this.stationTab.ResumeLayout(false);
            this.stationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectionBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage stationTab;
        private TabPage tabPage2;
        private DataGridView foundStations;
        private BindingSource transportBindingSource;
        private TextBox stationSearchBox;
        private BindingSource stationBindingSource;
        private DataGridView stationBoard;
        private Label stationBoardHeading;
        private BindingSource stationBoardBindingSource;
        private BindingSource stationBindingSource1;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Operator;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn showBoard;
        private TextBox toTextBox;
        private TextBox fromTextBox;
        private DataGridView conectionBoard;
        private DataGridViewTextBoxColumn Von;
        private DataGridViewTextBoxColumn Nach;
        private DataGridViewTextBoxColumn ReiseZeit;
        private DataGridViewTextBoxColumn AbfahrtsZeit;
        private DataGridViewTextBoxColumn AnkunftsZeit;
        private DateTimePicker connectionDateTimePicker;
        private Button switchFromTo;
    }
}