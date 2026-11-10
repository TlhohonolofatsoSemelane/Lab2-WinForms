namespace Lab2;

public class ChooseForm : Form
{
    Label lblWelcome = new Label();
    Button btnBicycle = new Button();
    Button btnMushroom = new Button();

    public ChooseForm(string username)
    {
        Text = "Choose";
        ClientSize = new Size(340, 160);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        lblWelcome.Text = "Welcome " + username + ". Choose a program:";
        lblWelcome.Left = 20;
        lblWelcome.Top = 20;
        lblWelcome.Width = 300;

        btnBicycle.Text = "Bicycle";
        btnBicycle.Left = 40;
        btnBicycle.Top = 70;
        btnBicycle.Width = 110;
        btnBicycle.Height = 40;
        btnBicycle.Click += btnBicycle_Click;

        btnMushroom.Text = "Mushroom";
        btnMushroom.Left = 190;
        btnMushroom.Top = 70;
        btnMushroom.Width = 110;
        btnMushroom.Height = 40;
        btnMushroom.Click += btnMushroom_Click;

        Controls.Add(lblWelcome);
        Controls.Add(btnBicycle);
        Controls.Add(btnMushroom);
    }

    void btnBicycle_Click(object sender, EventArgs e)
    {
        Hide();
        BicycleForm form = new BicycleForm();
        DialogResult result = form.ShowDialog();

        if (result == DialogResult.Abort)
        {
            Close();
        }
        else
        {
            Show();
        }
    }

    void btnMushroom_Click(object sender, EventArgs e)
    {
        Hide();
        MushroomForm form = new MushroomForm();
        DialogResult result = form.ShowDialog();

        if (result == DialogResult.Abort)
        {
            Close();
        }
        else
        {
            Show();
        }
    }
}
