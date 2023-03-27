namespace HW_Week_5
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
            this.label_Tittle = new System.Windows.Forms.Label();
            this.label_ChooseCountry = new System.Windows.Forms.Label();
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.listBox_DaftarPemain = new System.Windows.Forms.ListBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_AddTeam = new System.Windows.Forms.Label();
            this.label_AddPlayer = new System.Windows.Forms.Label();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.label_TeamCountry = new System.Windows.Forms.Label();
            this.label_TeamCity = new System.Windows.Forms.Label();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.label_PlayerNum = new System.Windows.Forms.Label();
            this.label_PlayerPosition = new System.Windows.Forms.Label();
            this.button_AddKiri = new System.Windows.Forms.Button();
            this.button_AddKanan = new System.Windows.Forms.Button();
            this.textBox_TeamName = new System.Windows.Forms.TextBox();
            this.textBox_TeamCountry = new System.Windows.Forms.TextBox();
            this.textBox_TeamCity = new System.Windows.Forms.TextBox();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.textBox_PlayerNum = new System.Windows.Forms.TextBox();
            this.comboBox_PlayerPosistion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.Location = new System.Drawing.Point(42, 45);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(196, 29);
            this.label_Tittle.TabIndex = 0;
            this.label_Tittle.Text = "Soccer Tim List";
            // 
            // label_ChooseCountry
            // 
            this.label_ChooseCountry.AutoSize = true;
            this.label_ChooseCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseCountry.Location = new System.Drawing.Point(43, 109);
            this.label_ChooseCountry.Name = "label_ChooseCountry";
            this.label_ChooseCountry.Size = new System.Drawing.Size(139, 20);
            this.label_ChooseCountry.TabIndex = 1;
            this.label_ChooseCountry.Text = "Choose Country :";
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseTeam.Location = new System.Drawing.Point(43, 193);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(123, 20);
            this.label_ChooseTeam.TabIndex = 2;
            this.label_ChooseTeam.Text = "Choose Team :";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Items.AddRange(new object[] {
            "England",
            "France"});
            this.comboBox_Country.Location = new System.Drawing.Point(248, 105);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(142, 26);
            this.comboBox_Country.TabIndex = 3;
            this.comboBox_Country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Country_SelectionChangeCommitted);
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(248, 191);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(142, 26);
            this.comboBox_Team.TabIndex = 4;
            this.comboBox_Team.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Team_SelectionChangeCommitted);
            // 
            // listBox_DaftarPemain
            // 
            this.listBox_DaftarPemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_DaftarPemain.FormattingEnabled = true;
            this.listBox_DaftarPemain.ItemHeight = 18;
            this.listBox_DaftarPemain.Location = new System.Drawing.Point(47, 290);
            this.listBox_DaftarPemain.Name = "listBox_DaftarPemain";
            this.listBox_DaftarPemain.Size = new System.Drawing.Size(343, 220);
            this.listBox_DaftarPemain.TabIndex = 5;
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(409, 470);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(142, 40);
            this.button_Remove.TabIndex = 6;
            this.button_Remove.Text = "REMOVE";
            this.button_Remove.UseVisualStyleBackColor = true;
            // 
            // label_AddTeam
            // 
            this.label_AddTeam.AutoSize = true;
            this.label_AddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddTeam.Location = new System.Drawing.Point(626, 105);
            this.label_AddTeam.Name = "label_AddTeam";
            this.label_AddTeam.Size = new System.Drawing.Size(107, 20);
            this.label_AddTeam.TabIndex = 7;
            this.label_AddTeam.Text = "Adding Team";
            // 
            // label_AddPlayer
            // 
            this.label_AddPlayer.AutoSize = true;
            this.label_AddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPlayer.Location = new System.Drawing.Point(919, 105);
            this.label_AddPlayer.Name = "label_AddPlayer";
            this.label_AddPlayer.Size = new System.Drawing.Size(121, 20);
            this.label_AddPlayer.TabIndex = 8;
            this.label_AddPlayer.Text = "Adding Players";
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeamName.Location = new System.Drawing.Point(468, 157);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(110, 20);
            this.label_TeamName.TabIndex = 9;
            this.label_TeamName.Text = "Team Name :";
            // 
            // label_TeamCountry
            // 
            this.label_TeamCountry.AutoSize = true;
            this.label_TeamCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeamCountry.Location = new System.Drawing.Point(468, 213);
            this.label_TeamCountry.Name = "label_TeamCountry";
            this.label_TeamCountry.Size = new System.Drawing.Size(124, 20);
            this.label_TeamCountry.TabIndex = 10;
            this.label_TeamCountry.Text = "Team Country :";
            // 
            // label_TeamCity
            // 
            this.label_TeamCity.AutoSize = true;
            this.label_TeamCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeamCity.Location = new System.Drawing.Point(468, 266);
            this.label_TeamCity.Name = "label_TeamCity";
            this.label_TeamCity.Size = new System.Drawing.Size(95, 20);
            this.label_TeamCity.TabIndex = 11;
            this.label_TeamCity.Text = "Team City :";
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerName.Location = new System.Drawing.Point(784, 157);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(115, 20);
            this.label_PlayerName.TabIndex = 12;
            this.label_PlayerName.Text = "Player Name :";
            // 
            // label_PlayerNum
            // 
            this.label_PlayerNum.AutoSize = true;
            this.label_PlayerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerNum.Location = new System.Drawing.Point(784, 213);
            this.label_PlayerNum.Name = "label_PlayerNum";
            this.label_PlayerNum.Size = new System.Drawing.Size(130, 20);
            this.label_PlayerNum.TabIndex = 13;
            this.label_PlayerNum.Text = "Player Number :";
            // 
            // label_PlayerPosition
            // 
            this.label_PlayerPosition.AutoSize = true;
            this.label_PlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerPosition.Location = new System.Drawing.Point(784, 266);
            this.label_PlayerPosition.Name = "label_PlayerPosition";
            this.label_PlayerPosition.Size = new System.Drawing.Size(131, 20);
            this.label_PlayerPosition.TabIndex = 14;
            this.label_PlayerPosition.Text = "Player Position :";
            // 
            // button_AddKiri
            // 
            this.button_AddKiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddKiri.Location = new System.Drawing.Point(612, 323);
            this.button_AddKiri.Name = "button_AddKiri";
            this.button_AddKiri.Size = new System.Drawing.Size(106, 40);
            this.button_AddKiri.TabIndex = 15;
            this.button_AddKiri.Text = "ADD";
            this.button_AddKiri.UseVisualStyleBackColor = true;
            // 
            // button_AddKanan
            // 
            this.button_AddKanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddKanan.Location = new System.Drawing.Point(934, 323);
            this.button_AddKanan.Name = "button_AddKanan";
            this.button_AddKanan.Size = new System.Drawing.Size(106, 40);
            this.button_AddKanan.TabIndex = 16;
            this.button_AddKanan.Text = "ADD";
            this.button_AddKanan.UseVisualStyleBackColor = true;
            // 
            // textBox_TeamName
            // 
            this.textBox_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeamName.Location = new System.Drawing.Point(612, 157);
            this.textBox_TeamName.Name = "textBox_TeamName";
            this.textBox_TeamName.Size = new System.Drawing.Size(144, 24);
            this.textBox_TeamName.TabIndex = 17;
            // 
            // textBox_TeamCountry
            // 
            this.textBox_TeamCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeamCountry.Location = new System.Drawing.Point(612, 211);
            this.textBox_TeamCountry.Name = "textBox_TeamCountry";
            this.textBox_TeamCountry.Size = new System.Drawing.Size(144, 24);
            this.textBox_TeamCountry.TabIndex = 18;
            // 
            // textBox_TeamCity
            // 
            this.textBox_TeamCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeamCity.Location = new System.Drawing.Point(612, 264);
            this.textBox_TeamCity.Name = "textBox_TeamCity";
            this.textBox_TeamCity.Size = new System.Drawing.Size(144, 24);
            this.textBox_TeamCity.TabIndex = 19;
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PlayerName.Location = new System.Drawing.Point(934, 155);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(144, 24);
            this.textBox_PlayerName.TabIndex = 20;
            // 
            // textBox_PlayerNum
            // 
            this.textBox_PlayerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PlayerNum.Location = new System.Drawing.Point(934, 209);
            this.textBox_PlayerNum.Name = "textBox_PlayerNum";
            this.textBox_PlayerNum.Size = new System.Drawing.Size(144, 24);
            this.textBox_PlayerNum.TabIndex = 21;
            // 
            // comboBox_PlayerPosistion
            // 
            this.comboBox_PlayerPosistion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_PlayerPosistion.FormattingEnabled = true;
            this.comboBox_PlayerPosistion.Location = new System.Drawing.Point(936, 266);
            this.comboBox_PlayerPosistion.Name = "comboBox_PlayerPosistion";
            this.comboBox_PlayerPosistion.Size = new System.Drawing.Size(142, 26);
            this.comboBox_PlayerPosistion.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 635);
            this.Controls.Add(this.comboBox_PlayerPosistion);
            this.Controls.Add(this.textBox_PlayerNum);
            this.Controls.Add(this.textBox_PlayerName);
            this.Controls.Add(this.textBox_TeamCity);
            this.Controls.Add(this.textBox_TeamCountry);
            this.Controls.Add(this.textBox_TeamName);
            this.Controls.Add(this.button_AddKanan);
            this.Controls.Add(this.button_AddKiri);
            this.Controls.Add(this.label_PlayerPosition);
            this.Controls.Add(this.label_PlayerNum);
            this.Controls.Add(this.label_PlayerName);
            this.Controls.Add(this.label_TeamCity);
            this.Controls.Add(this.label_TeamCountry);
            this.Controls.Add(this.label_TeamName);
            this.Controls.Add(this.label_AddPlayer);
            this.Controls.Add(this.label_AddTeam);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.listBox_DaftarPemain);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label_ChooseTeam);
            this.Controls.Add(this.label_ChooseCountry);
            this.Controls.Add(this.label_Tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.Label label_ChooseCountry;
        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.ListBox listBox_DaftarPemain;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label_AddTeam;
        private System.Windows.Forms.Label label_AddPlayer;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.Label label_TeamCountry;
        private System.Windows.Forms.Label label_TeamCity;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.Label label_PlayerNum;
        private System.Windows.Forms.Label label_PlayerPosition;
        private System.Windows.Forms.Button button_AddKiri;
        private System.Windows.Forms.Button button_AddKanan;
        private System.Windows.Forms.TextBox textBox_TeamName;
        private System.Windows.Forms.TextBox textBox_TeamCountry;
        private System.Windows.Forms.TextBox textBox_TeamCity;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.TextBox textBox_PlayerNum;
        private System.Windows.Forms.ComboBox comboBox_PlayerPosistion;
    }
}

