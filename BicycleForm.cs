namespace Lab2;

public class BicycleForm : Form
{
    Label lblStart = new Label();
    Label lblEnd = new Label();
    Label lblTotal = new Label();
    NumericUpDown numStart = new NumericUpDown();
    NumericUpDown numEnd = new NumericUpDown();
    TextBox txtTotal = new TextBox();
    Button btnCalculate = new Button();
    Button btnLogout = new Button();
    Button btnBack = new Button();

    public BicycleForm()
    {
        Text = "Bicycle Rental";
        ClientSize = new Size(340, 260);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        lblStart.Text = "Start hour (0-23):";
        lblStart.Left = 20;
        lblStart.Top = 28;
        lblStart.Width = 115;

        lblEnd.Text = "End hour (1-24):";
        lblEnd.Left = 20;
        lblEnd.Top = 68;
        lblEnd.Width = 115;

        lblTotal.Text = "Total (RWF):";
        lblTotal.Left = 20;
        lblTotal.Top = 153;
        lblTotal.Width = 115;

        numStart.Left = 140;
        numStart.Top = 25;
        numStart.Width = 80;
        numStart.Minimum = 0;
        numStart.Maximum = 23;

        numEnd.Left = 140;
        numEnd.Top = 65;
        numEnd.Width = 80;
        numEnd.Minimum = 1;
        numEnd.Maximum = 24;
        numEnd.Value = 1;

        txtTotal.Left = 140;
        txtTotal.Top = 150;
        txtTotal.Width = 140;
        txtTotal.ReadOnly = true;

        btnCalculate.Text = "Calculate";
        btnCalculate.Left = 140;
        btnCalculate.Top = 105;
        btnCalculate.Width = 90;
        btnCalculate.Click += btnCalculate_Click;

        btnLogout.Text = "Logout";
        btnLogout.Left = 140;
        btnLogout.Top = 200;
        btnLogout.Width = 90;
        btnLogout.Click += btnLogout_Click;

        btnBack.Text = "Back";
        btnBack.Left = 240;
        btnBack.Top = 200;
        btnBack.Width = 70;
        btnBack.Click += btnBack_Click;

        Controls.Add(lblStart);
        Controls.Add(lblEnd);
        Controls.Add(lblTotal);
        Controls.Add(numStart);
        Controls.Add(numEnd);
        Controls.Add(txtTotal);
        Controls.Add(btnCalculate);
        Controls.Add(btnLogout);
        Controls.Add(btnBack);
    }

    void btnCalculate_Click(object sender, EventArgs e)
    {
        int start = (int)numStart.Value;
        int end = (int)numEnd.Value;

        if (start >= end)
        {
            MessageBox.Show("The starting time must be less than the ending time.");
            return;
        }

        int total = 0;

        for (int hour = start; hour < end; hour++)
        {
            if (hour < 7)
            {
                total = total + 500;
            }
            else if (hour < 14)
            {
                total = total + 1000;
            }
            else if (hour < 19)
            {
                total = total + 1500;
            }
            else if (hour < 21)
            {
                total = total + 1000;
            }
            else
            {
                total = total + 500;
            }
        }

        txtTotal.Text = total.ToString();
        MessageBox.Show("Total to pay: " + total + " RWF");
    }

    void btnLogout_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Abort;
    }

    void btnBack_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }
}
