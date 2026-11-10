namespace Lab2;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        bool running = true;
        while (running)
        {
            LoginForm login = new LoginForm();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                ChooseForm choose = new ChooseForm(login.Username);
                choose.ShowDialog();
            }
            else
            {
                running = false;
            }
        }
    }
}
