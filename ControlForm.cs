
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Text.Json;
using System.IO;

namespace WinFormsApp
{
    public partial class ControlForm : Form
    {
        private MacroController? macroController;
        private CrosshairForm? crosshairForm;

        public ControlForm()
        {
            InitializeComponent();
            InitializeMacroController();
        }

        private void InitializeMacroController()
        {
            var weaponRecoils = new Dictionary<string, int[]>();
            try
            {
                string json = File.ReadAllText("recoil_patterns.json");
                var recoils = JsonSerializer.Deserialize<Dictionary<string, int[]>>(json);
                if (recoils != null)
                {
                    weaponRecoils = recoils;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recoil patterns: {ex.Message}. Using default patterns.");
                weaponRecoils = new Dictionary<string, int[]>
                {
                    { "SMG (Recuo Leve)", new int[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 } },
                    { "Rifle 556 (Recuo Médio)", new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 4, 4 } },
                    { "Rifle 762 (Recuo Alto)", new int[] { 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 } }
                };
            }
            macroController = new MacroController(weaponRecoils);
        }

        private void showCrosshairButton_Click(object sender, EventArgs e)
        {
            string selectedType = crosshairTypeComboBox.SelectedItem?.ToString() ?? "Cross";
            string selectedColorName = colorComboBox.SelectedItem?.ToString() ?? "Red";
            Color selectedColor = Color.FromName(selectedColorName);

            if (crosshairForm == null || crosshairForm.IsDisposed)
            {
                crosshairForm = new CrosshairForm(selectedType, selectedColor);
                crosshairForm.KeyDown += OverlayForm_KeyDown;
                crosshairForm.Show();
            }
        }

        private void ControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            HandleMacroKeys(e);
        }

        private void OverlayForm_KeyDown(object? sender, KeyEventArgs e)
        {
            HandleMacroKeys(e);

            if (e.Control && e.Alt && e.KeyCode == Keys.K)
            {
                crosshairForm?.Close();
            }
        }

        private void startMacroButton_Click(object sender, EventArgs e)
        {
            StartMacro();
        }

        private void stopMacroButton_Click(object sender, EventArgs e)
        {
            StopMacro();
        }

        private void HandleMacroKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                StartMacro();
            }

            if (e.KeyCode == Keys.F6)
            {
                StopMacro();
            }
        }

        private void StartMacro()
        {
            string? selectedWeapon = weaponComboBox.SelectedItem?.ToString();
            if (selectedWeapon != null && macroController != null)
            {
                macroController.SetWeapon(selectedWeapon);
                macroController.Start();
            }
        }

        private void StopMacro()
        {
            if (macroController != null)
            {
                macroController.Stop();
            }
        }
    }
}
