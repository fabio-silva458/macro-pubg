
namespace WinFormsApp
{
    partial class ControlForm
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
            this.weaponComboBox = new System.Windows.Forms.ComboBox();
            this.crosshairTypeComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.showCrosshairButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.crosshairTypeLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.startMacroButton = new System.Windows.Forms.Button();
            this.stopMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weaponComboBox
            // 
            this.weaponComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponComboBox.FormattingEnabled = true;
            this.weaponComboBox.Items.AddRange(new object[] {
            "SMG (Recuo Leve)",
            "Rifle 556 (Recuo Médio)",
            "Rifle 762 (Recuo Alto)"});
            this.weaponComboBox.Location = new System.Drawing.Point(12, 25);
            this.weaponComboBox.Name = "weaponComboBox";
            this.weaponComboBox.Size = new System.Drawing.Size(300, 23);
            this.weaponComboBox.TabIndex = 0;
            // 
            // crosshairTypeComboBox
            // 
            this.crosshairTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crosshairTypeComboBox.FormattingEnabled = true;
            this.crosshairTypeComboBox.Items.AddRange(new object[] {
            "Cross",
            "Circle",
            "Dot"});
            this.crosshairTypeComboBox.Location = new System.Drawing.Point(12, 79);
            this.crosshairTypeComboBox.Name = "crosshairTypeComboBox";
            this.crosshairTypeComboBox.Size = new System.Drawing.Size(300, 23);
            this.crosshairTypeComboBox.TabIndex = 1;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "White"});
            this.colorComboBox.Location = new System.Drawing.Point(12, 133);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(300, 23);
            this.colorComboBox.TabIndex = 2;
            // 
            // showCrosshairButton
            // 
            this.showCrosshairButton.Location = new System.Drawing.Point(12, 172);
            this.showCrosshairButton.Name = "showCrosshairButton";
            this.showCrosshairButton.Size = new System.Drawing.Size(145, 23);
            this.showCrosshairButton.TabIndex = 3;
            this.showCrosshairButton.Text = "Show Crosshair";
            this.showCrosshairButton.UseVisualStyleBackColor = true;
            this.showCrosshairButton.Click += new System.EventHandler(this.showCrosshairButton_Click);
            // 
            // startMacroButton
            // 
            this.startMacroButton.Location = new System.Drawing.Point(167, 172);
            this.startMacroButton.Name = "startMacroButton";
            this.startMacroButton.Size = new System.Drawing.Size(145, 23);
            this.startMacroButton.TabIndex = 8;
            this.startMacroButton.Text = "Start Macro (F5)";
            this.startMacroButton.UseVisualStyleBackColor = true;
            this.startMacroButton.Click += new System.EventHandler(this.startMacroButton_Click);
            // 
            // stopMacroButton
            // 
            this.stopMacroButton.Location = new System.Drawing.Point(12, 201);
            this.stopMacroButton.Name = "stopMacroButton";
            this.stopMacroButton.Size = new System.Drawing.Size(300, 23);
            this.stopMacroButton.TabIndex = 9;
            this.stopMacroButton.Text = "Stop Macro (F6)";
            this.stopMacroButton.UseVisualStyleBackColor = true;
            this.stopMacroButton.Click += new System.EventHandler(this.stopMacroButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(12, 237);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(296, 45);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Pressione F5 para iniciar a macro\nPressione F6 para parar a macro\nPressione Ctrl + Alt + K para fechar a sobreposição";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(12, 7);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(101, 15);
            this.weaponLabel.TabIndex = 5;
            this.weaponLabel.Text = "Selecione a arma:";
            // 
            // crosshairTypeLabel
            // 
            this.crosshairTypeLabel.AutoSize = true;
            this.crosshairTypeLabel.Location = new System.Drawing.Point(12, 61);
            this.crosshairTypeLabel.Name = "crosshairTypeLabel";
            this.crosshairTypeLabel.Size = new System.Drawing.Size(125, 15);
            this.crosshairTypeLabel.TabIndex = 6;
            this.crosshairTypeLabel.Text = "Selecione o tipo de mira:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 115);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(121, 15);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Selecione a cor da mira:";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 291);
            this.Controls.Add(this.stopMacroButton);
            this.Controls.Add(this.startMacroButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.crosshairTypeLabel);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.showCrosshairButton);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.crosshairTypeComboBox);
            this.Controls.Add(this.weaponComboBox);
            this.KeyPreview = true;
            this.Name = "ControlForm";
            this.Text = "Crosshair & Macro Selector";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox weaponComboBox;
        private System.Windows.Forms.ComboBox crosshairTypeComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button showCrosshairButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label crosshairTypeLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button startMacroButton;
        private System.Windows.Forms.Button stopMacroButton;
    }
}
