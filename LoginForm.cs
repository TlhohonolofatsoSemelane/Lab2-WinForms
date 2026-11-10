namespace Lab2;

public class LoginForm : Form
{
    Label lblUser = new Label();
    Label lblPass = new Label();
    TextBox txtUser = new TextBox();
    TextBox txtPass = new TextBox();
    Button btnLogin = new Button();

    public string Username = "";

    public LoginForm()
    {
        Text = "Login";
        ClientSize = new Size(340, 170);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        lblUser.Text = "Username:";
        lblUser.Left = 20;
        lblUser.Top = 33;

        lblPass.Text = "Password:";
        lblPass.Left = 20;
        lblPass.Top = 73;

        txtUser.Left = 120;
        txtUser.Top = 30;
        txtUser.Width = 180;

        txtPass.Left = 120;
        txtPass.Top = 70;
        txtPass.Width = 180;
        txtPass.UseSystemPasswordChar = true;

        btnLogin.Text = "Login";
        btnLogin.Left = 120;
        btnLogin.Top = 110;
        btnLogin.Click += btnLogin_Click;
        AcceptButton = btnLogin;

        Controls.Add(lblUser);
        Controls.Add(lblPass);
        Controls.Add(txtUser);
        Controls.Add(txtPass);
        Controls.Add(btnLogin);
    }

    void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUser.Text == "" || txtPass.Text != "1234")
        {
            MessageBox.Show("Wrong login. Enter a username and the password 1234.");
        }
        else
        {
            Username = txtUser.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
