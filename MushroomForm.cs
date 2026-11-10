namespace Lab2;

public class MushroomForm : Form
{
    Label lblInfo = new Label();
    Label lblQuestion = new Label();
    Label lblCount = new Label();
    Button btnYes = new Button();
    Button btnNo = new Button();
    Button btnRestart = new Button();
    Button btnLogout = new Button();
    Button btnBack = new Button();

    int step = 1;
    int asked = 0;

    public MushroomForm()
    {
        Text = "Mushroom Finder";
        ClientSize = new Size(420, 240);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        lblInfo.Text = "Think of one of the six mushrooms and answer yes or no.";
        lblInfo.Left = 20;
        lblInfo.Top = 5;
        lblInfo.Width = 380;

        lblQuestion.Left = 20;
        lblQuestion.Top = 25;
        lblQuestion.Width = 380;
        lblQuestion.Height = 40;
        lblQuestion.Font = new Font("Segoe UI", 11);

        lblCount.Left = 20;
        lblCount.Top = 70;
        lblCount.Width = 380;

        btnYes.Text = "Yes";
        btnYes.Left = 20;
        btnYes.Top = 105;
        btnYes.Width = 90;
        btnYes.Height = 32;
        btnYes.Click += btnYes_Click;

        btnNo.Text = "No";
        btnNo.Left = 120;
        btnNo.Top = 105;
        btnNo.Width = 90;
        btnNo.Height = 32;
        btnNo.Click += btnNo_Click;

        btnRestart.Text = "Restart";
        btnRestart.Left = 220;
        btnRestart.Top = 105;
        btnRestart.Width = 90;
        btnRestart.Height = 32;
        btnRestart.Click += btnRestart_Click;

        btnLogout.Text = "Logout";
        btnLogout.Left = 20;
        btnLogout.Top = 190;
        btnLogout.Width = 90;
        btnLogout.Click += btnLogout_Click;

        btnBack.Text = "Back";
        btnBack.Left = 120;
        btnBack.Top = 190;
        btnBack.Width = 90;
        btnBack.Click += btnBack_Click;

        Controls.Add(lblInfo);
        Controls.Add(lblQuestion);
        Controls.Add(lblCount);
        Controls.Add(btnYes);
        Controls.Add(btnNo);
        Controls.Add(btnRestart);
        Controls.Add(btnLogout);
        Controls.Add(btnBack);

        StartOver();
    }

    void StartOver()
    {
        step = 1;
        asked = 0;
        btnYes.Enabled = true;
        btnNo.Enabled = true;
        ShowQuestion();
    }

    void ShowQuestion()
    {
        if (step == 1)
        {
            lblQuestion.Text = "Does your mushroom grow in a forest?";
        }
        else if (step == 2 || step == 3)
        {
            lblQuestion.Text = "Does your mushroom have a convex cup?";
        }
        else if (step == 4)
        {
            lblQuestion.Text = "Does your mushroom have a ring?";
        }
        else if (step == 5)
        {
            lblQuestion.Text = "Does your mushroom have gills?";
        }

        lblCount.Text = "Question " + (asked + 1) + " of at most 3";
    }

    void Answer(bool yes)
    {
        asked = asked + 1;

        if (step == 1)
        {
            if (yes)
            {
                step = 3;
            }
            else
            {
                step = 2;
            }
            ShowQuestion();
        }
        else if (step == 2)
        {
            if (yes)
            {
                ShowResult("Agaric jaunissant");
            }
            else
            {
                ShowResult("Coprin chevelu");
            }
        }
        else if (step == 3)
        {
            if (yes)
            {
                step = 4;
            }
            else
            {
                step = 5;
            }
            ShowQuestion();
        }
        else if (step == 4)
        {
            if (yes)
            {
                ShowResult("Amanite tue-mouche");
            }
            else
            {
                ShowResult("Pied bleu");
            }
        }
        else if (step == 5)
        {
            if (yes)
            {
                ShowResult("Girolle");
            }
            else
            {
                ShowResult("Cepe de Bordeaux");
            }
        }
    }

    void ShowResult(string name)
    {
        btnYes.Enabled = false;
        btnNo.Enabled = false;
        lblQuestion.Text = "Your mushroom is: " + name;
        lblCount.Text = "Found after " + asked + " question(s).";
        MessageBox.Show("Your mushroom is: " + name);
    }

    void btnYes_Click(object sender, EventArgs e)
    {
        Answer(true);
    }

    void btnNo_Click(object sender, EventArgs e)
    {
        Answer(false);
    }

    void btnRestart_Click(object sender, EventArgs e)
    {
        StartOver();
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
